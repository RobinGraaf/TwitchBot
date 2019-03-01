using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchBot {
    public partial class SettingsForm : Form
    {
        private readonly MainScreen _screen;

        public SettingsForm()
        {
            _screen = (MainScreen) Application.OpenForms["MainScreen"];
            InitializeComponent();
            pointTimerText.Text = (_screen.pointsTimer.Interval / 60000).ToString();
            prefixBox.Text = ChatLink.BotCommandPrefix;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pointTimerText.Text.Length > 0)
            {
                if (int.TryParse(pointTimerText.Text, out int interval))
                {
                    _screen.pointsTimer.Interval = interval * 60000;
                }
            }

            if (prefixBox.Text.Length > 0)
            {
                ChatLink.BotCommandPrefix = prefixBox.Text;
            }

            this.Hide();
            MessageBox.Show($"Interval set to {_screen.pointsTimer.Interval / 60000} minutes \r\n" +
                            $"Bot command prefix set to '{ChatLink.BotCommandPrefix}'", "", MessageBoxButtons.OK);
        }

        private void pointTimerHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The amount of time users need to watch to get 1 point (in minutes).", "",
                MessageBoxButtons.OK);
        }

        private void prefixHelp_Click(object sender, EventArgs e) {
            MessageBox.Show("The prefix used to call bot commands (default: '!'). Don't use spaces!.", "",
                MessageBoxButtons.OK);
        }

        private void resetPointsButton_Click(object sender, EventArgs e)
        {
            UserHandler.ClearPoints();
            MessageBox.Show("Points Cleared!", "Clear Points", MessageBoxButtons.OK);
        }

        private void resetCommandsButton_Click(object sender, EventArgs e) 
        {
            ChatLink.ClearCommands();
            MessageBox.Show("Commands Cleared!", "Clear Commands", MessageBoxButtons.OK);
        }
    }
}
