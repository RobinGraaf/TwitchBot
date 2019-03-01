using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace TwitchBot {
    public static class ChatLink {
        private static TcpClient tcpClient;
        private static StreamReader reader;
        private static StreamWriter writer;

        public static string Channel { get; set; }
        public static string ChannelName { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string ChatLog { get; set; }
        public static string BotCommandPrefix { get; set; }

        private static string chatMessagePrefix;
        private static DateTime lastMessageSendtime;

        private static Queue<string> sendMessageQueue;
        
        private static IList<Command> commands;
        private static JArray commandsArray;

        public static void StartBot()
        {
            sendMessageQueue = new Queue<string>();

            if (string.IsNullOrEmpty(BotCommandPrefix)) { BotCommandPrefix = "!"; }

            ChannelName = Channel.ToLower();
            chatMessagePrefix = String.Format(":{0}!{0}@{0}.tmi.twitch.tv PRIVMSG #{1} :", Username.ToLower(), ChannelName);

            Connect();
        }

        private static void Connect() {
            tcpClient = new TcpClient("irc.twitch.tv", 6667);
            reader = new StreamReader(tcpClient.GetStream());
            writer = new StreamWriter(tcpClient.GetStream());
            writer.AutoFlush = true;

            //password = File.ReadAllText("password.txt");

            writer.WriteLine("PASS " + Password + Environment.NewLine
                             + "NICK " + Username + Environment.NewLine
                             + "USER " + Username + " 8 * :" + Username);

            //writer.WriteLine("CAP REQ :twitch.tv/membership");
            writer.WriteLine("JOIN #" + ChannelName);
            lastMessageSendtime = DateTime.Now;
            if (tcpClient.Connected) {
                MessageBox.Show("Connected!", "", MessageBoxButtons.OK);
            } else {
                MessageBox.Show("Could not connect, please try again!", "", MessageBoxButtons.OK);
            }
        }

        private static void SendTwitchMessage(string speaker, string message) {
            sendMessageQueue.Enqueue(message);
        }

        public static void TimerTick()
        {
            if (!tcpClient.Connected) {
                Connect();
            }

            TryReceivingMessages();
            TrySendingMessages();
        }

        private static void TryReceivingMessages() {
            if (tcpClient.Available > 0) {
                var message = reader.ReadLine();
                ChatLog += $"\r\n[speaker]: {message}";

                //aLabel.Text += $"\r\n{message}";

                var iCollon = message.IndexOf(":", 1);
                if (iCollon > 0) {
                    var command = message.Substring(1, iCollon);
                    if (command.Contains("PRIVMSG #")) {
                        var iBang = command.IndexOf("!");
                        if (iBang > 0) {
                            var speaker = command.Substring(0, iBang);
                            var chatMessage = message.Substring(iCollon + 1);

                            ReceiveMessage(speaker, chatMessage);
                        }
                    }
                }
            }
        }

        private static void ReceiveMessage(string speaker, string message) {

            if (message.ToLower().StartsWith(BotCommandPrefix)) {
                ChatLog += $"\r\n[{speaker}]: {message}";

                dynamic allCommands = File.ReadAllText("botcommands.txt");
                if (allCommands.Length > 0)
                {
                    commandsArray = JArray.Parse(allCommands);

                    commands = commandsArray.Select(c => new Command()
                    {
                        CommandText = (string) c["CommandText"],
                        Response = (string) c["Response"],
                        Description = (string) c["Description"]
                    }).ToList();
                }

                if (commands != null && commands.Count > 0) {
                    foreach (dynamic command in commands) {
                        if (message.ToLower().Contains(command.CommandText)) {
                            if (command.Response.Length > 0) {
                                SendTwitchMessage(speaker, command.Response);
                            }
                        }
                    }
                }
            }
        }

        private static void TrySendingMessages() {
            
                if (sendMessageQueue.Count > 0) {
                    var message = sendMessageQueue.Dequeue();
                    writer.WriteLine("{0}{1} \r\n", chatMessagePrefix, message);
                    lastMessageSendtime = DateTime.Now;
                }
        }
    }
}
