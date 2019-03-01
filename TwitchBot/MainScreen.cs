using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TwitchBot {
    public partial class MainScreen : Form
    {
        private bool channelIsSet, botnameIsSet, tokenIsSet;
        
        private AddCommandForm commandForm;
        private IList<Command> commands;
        private JArray commandsArray;

        public MainScreen()
        {
            if (!File.Exists("botcommands.txt")) { File.Create("botcommands.txt"); }
            if (!File.Exists("botvalues.txt")) { File.Create("botvalues.txt"); }
            if (string.IsNullOrEmpty(ChatLink.BotCommandPrefix)) { ChatLink.BotCommandPrefix = "!"; }

            InitializeComponent();
            SetValues();
        }

        private void SetValues()
        {
            LinkLabel.Link tokenLink = new LinkLabel.Link();
            tokenLink.LinkData = "https://twitchapps.com/tmi/";
            tokenLinkLabel.Links.Add(tokenLink);

            LinkLabel.Link siteLink = new LinkLabel.Link();
            siteLink.LinkData = "https://robingraaf.nl/";
            websiteLinkLabel.Links.Add(siteLink);

            string botvalues = File.ReadAllText("botvalues.txt");
            string[] values = botvalues.Split(',');

            if (botvalues.Length > 0) {
                channelTextBox.Text = values[0];
                botnameTextBox.Text = values[1];
                tokenTextBox.Text = values[2];
                ChatLink.BotCommandPrefix = values[3];
            }
        }

        private void SetupBot()
        {
            channelIsSet = TextBoxHandler.CheckForInput(channelTextBox, out string channelText);
            ChatLink.Channel = channelText;

            botnameIsSet = TextBoxHandler.CheckForInput(botnameTextBox, out string botnameText);
            ChatLink.Username = botnameText;

            tokenIsSet = TextBoxHandler.CheckForInput(tokenTextBox, out string passwordText);
            ChatLink.Password = passwordText;

            if (channelIsSet && botnameIsSet && tokenIsSet)
            {
                SaveValues();
                StartBot();
            }
        }

        private void SaveValues()
        {
            string values = ChatLink.Channel + "," + ChatLink.Username + "," + ChatLink.Password + "," + ChatLink.BotCommandPrefix;
            File.WriteAllText("botvalues.txt", values);
        }

        private void StartBot()
        {
            updateTimer.Enabled = true;
            pointsTimer.Enabled = true;
            ChatLink.StartBot();
        }
        
        private void showCommandsButton_Click(object sender, EventArgs e)
        {
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

                string commandStringToPrint = "";

                foreach (dynamic commandData in commands)
                {
                    commandStringToPrint += $"\r\nCommand: {ChatLink.BotCommandPrefix}{commandData.CommandText} | Response: {commandData.Response} | Description: {commandData.Description}";
                }
                MessageBox.Show(commandStringToPrint, "All Commands", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No commands added yet!", "All Commands", MessageBoxButtons.OK);
            }
        }

        private void addCommandButton_Click(object sender, EventArgs e) {
            commandForm = new AddCommandForm();
            commandForm.Show();
        }

        public void ClearCommands() {
            File.WriteAllText("botcommands.txt", "");
            commandsArray?.Clear();
            commands?.Clear();
        }

        private void settingsButton_Click(object sender, EventArgs e) {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void pointsTimer_Tick(object sender, EventArgs e) {
            UserHandler.AddPoints();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(e.Link.LinkData as string);
        }

        private void minigamesButton_Click(object sender, EventArgs e) {
            MinigamesForm minigamesForm = new MinigamesForm();
            minigamesForm.Show();
        }

        private void websiteLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void startBotButton_Click(object sender, EventArgs e) {
            SetupBot();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            ChatLink.TimerTick();
            aLabel.Text = ChatLink.ChatLog;
        }
    }
}
