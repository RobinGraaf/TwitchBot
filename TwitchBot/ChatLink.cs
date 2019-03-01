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
        public static string Channel { get; set; }
        public static string ChannelName { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string ChatLog { get; set; }
        public static string BotCommandPrefix { get; set; }

        private static TcpClient _tcpClient;
        private static StreamReader _reader;
        private static StreamWriter _writer;

        private static string _chatMessagePrefix;
        private static DateTime _lastMessageSendtime;

        private static Queue<string> _sendMessageQueue;
        
        private static IList<Command> _commands;
        private static JArray _userCommandsArray, _botCommandsArray, _allCommandsArray;

        public static void StartBot()
        {
            _sendMessageQueue = new Queue<string>();

            if (string.IsNullOrEmpty(BotCommandPrefix)) { BotCommandPrefix = "!"; }

            ChannelName = Channel.ToLower();
            _chatMessagePrefix = String.Format(":{0}!{0}@{0}.tmi.twitch.tv PRIVMSG #{1} :", Username.ToLower(), ChannelName);

            Connect();
        }

        private static void Connect() {
            _tcpClient = new TcpClient("irc.twitch.tv", 6667);
            _reader = new StreamReader(_tcpClient.GetStream());
            _writer = new StreamWriter(_tcpClient.GetStream());
            _writer.AutoFlush = true;

            //password = File.ReadAllText("password.txt");

            _writer.WriteLine("PASS " + Password + Environment.NewLine
                             + "NICK " + Username + Environment.NewLine
                             + "USER " + Username + " 8 * :" + Username);

            //_writer.WriteLine("CAP REQ :twitch.tv/membership");
            _writer.WriteLine("JOIN #" + ChannelName);
            _lastMessageSendtime = DateTime.Now;
            if (_tcpClient.Connected) {
                MessageBox.Show("Connected!", "", MessageBoxButtons.OK);
            } else {
                MessageBox.Show("Could not connect, please try again!", "", MessageBoxButtons.OK);
            }
        }

        private static void SendTwitchMessage(string speaker, string message) {
            _sendMessageQueue.Enqueue(message);
        }

        public static void TimerTick()
        {
            if (!_tcpClient.Connected) {
                Connect();
            }

            TryReceivingMessages();
            TrySendingMessages();
        }

        private static void TryReceivingMessages() {
            if (_tcpClient.Available > 0) {
                var message = _reader.ReadLine();
                //ChatLog += $"\r\n[speaker]: {message}";

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

                _commands = GetAllCommands();

                if (_commands != null && _commands.Count > 0) {
                    foreach (dynamic command in _commands) {
                        if (message.ToLower().Contains(command.CommandText)) {
                            if (command.Response.Length > 0) {
                                SendTwitchMessage(speaker, command.Response);
                            }
                        }
                    }
                }
            }
        }

        private static void TrySendingMessages()
        {
            if (DateTime.Now - _lastMessageSendtime > TimeSpan.FromSeconds(2))
            {
                if (_sendMessageQueue.Count > 0)
                {
                    var message = _sendMessageQueue.Dequeue();
                    _writer.WriteLine("{0}{1} \r\n", _chatMessagePrefix, message);
                    _lastMessageSendtime = DateTime.Now;
                }
            }
        }

        public static IList<Command> GetAllCommands()
        {
            IList<Command> commandsList = new List<Command>();
            dynamic allBotCommands = File.ReadAllText("botcommands.txt");
            dynamic allUserCommands = File.ReadAllText("userbotcommands.txt");
            if (allUserCommands.Length > 0 || allBotCommands.Length > 0) {
                _botCommandsArray = JArray.Parse(allBotCommands);
                _userCommandsArray = JArray.Parse(allUserCommands);

                _allCommandsArray = new JArray { _botCommandsArray, _userCommandsArray };

                commandsList = _allCommandsArray.Select(c => new Command() {
                    CommandText = (string)c["CommandText"],
                    Response = (string)c["Response"],
                    Description = (string)c["Description"]
                }).ToList();
            }

            return commandsList;
        }
        
        public static void ClearCommands() {
            File.WriteAllText("userbotcommands.txt", "");
            _userCommandsArray?.Clear();
            _commands?.Clear();
        }
    }
}
