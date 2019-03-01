using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TwitchBot
{
    public partial class MainScreen : Form
    {
        private bool _channelIsSet, _botnameIsSet, _tokenIsSet;
        private IList<Command> _commands;

        public MainScreen()
        {
            if (!File.Exists("userbotcommands.txt")) File.Create("userbotcommands.txt");
            if (!File.Exists("botcommands.txt")) File.Create("botcommands.txt");
            if (!File.Exists("botvalues.txt")) File.Create("botvalues.txt");
            if (string.IsNullOrEmpty(ChatLink.BotCommandPrefix)) ChatLink.BotCommandPrefix = "!";

            InitializeComponent();
            SetValues();
        }

        private void SetValues()
        {
            var tokenLink = new LinkLabel.Link();
            tokenLink.LinkData = "https://twitchapps.com/tmi/";
            tokenLinkLabel.Links.Add(tokenLink);

            var siteLink = new LinkLabel.Link();
            siteLink.LinkData = "https://robingraaf.nl/";
            websiteLinkLabel.Links.Add(siteLink);

            var botvalues = File.ReadAllText("botvalues.txt");
            var values = botvalues.Split(',');

            if (botvalues.Length > 0)
            {
                channelTextBox.Text = values[0];
                botnameTextBox.Text = values[1];
                tokenTextBox.Text = values[2];
                ChatLink.BotCommandPrefix = values[3];
            }
        }

        private void SetupBot()
        {
            _channelIsSet = TextBoxHandler.CheckForInput(channelTextBox, out var channelText);
            ChatLink.Channel = channelText;

            _botnameIsSet = TextBoxHandler.CheckForInput(botnameTextBox, out var botnameText);
            ChatLink.Username = botnameText;

            _tokenIsSet = TextBoxHandler.CheckForInput(tokenTextBox, out var passwordText);
            ChatLink.Password = passwordText;

            if (_channelIsSet && _botnameIsSet && _tokenIsSet)
            {
                SaveValues();
                StartBot();
            }
        }

        private void SaveValues()
        {
            var values = ChatLink.Channel + "," + ChatLink.Username + "," + ChatLink.Password + "," +
                         ChatLink.BotCommandPrefix;
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
            _commands = ChatLink.GetAllCommands();
            if (_commands.Count > 0)
            {
                var commandStringToPrint = "";
                foreach (dynamic commandData in _commands)
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

        private void addCommandButton_Click(object sender, EventArgs e)
        {
            new AddCommandForm().Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void pointsTimer_Tick(object sender, EventArgs e)
        {
            UserHandler.AddPoints();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void minigamesButton_Click(object sender, EventArgs e)
        {
            var minigamesForm = new MinigamesForm();
            minigamesForm.Show();
        }

        private void websiteLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void startBotButton_Click(object sender, EventArgs e)
        {
            SetupBot();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChatLink.TimerTick();
            aLabel.Text = ChatLink.ChatLog;
        }
    }
}