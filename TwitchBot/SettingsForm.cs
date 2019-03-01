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
        private MainScreen screen;

        public SettingsForm()
        {
            screen = (MainScreen) Application.OpenForms["MainScreen"];
            InitializeComponent();
            pointTimerText.Text = (screen.pointsTimer.Interval / 60000).ToString();
            prefixBox.Text = ChatLink.BotCommandPrefix;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pointTimerText.Text.Length > 0)
            {
                if (int.TryParse(pointTimerText.Text, out int interval))
                {
                    screen.pointsTimer.Interval = interval * 60000;
                }
            }

            if (prefixBox.Text.Length > 0)
            {
                ChatLink.BotCommandPrefix = prefixBox.Text;
            }

            this.Hide();
            MessageBox.Show($"Interval set to {screen.pointsTimer.Interval / 60000} minutes \r\n" +
                            $"Bot command prefix set to '{ChatLink.BotCommandPrefix}'", "", MessageBoxButtons.OK);
        }

        private void pointTimerHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The amount of time users need to watch to get 1 point (in minutes).", "",
                MessageBoxButtons.OK);
        }

        private void prefixHelp_Click(object sender, EventArgs e) {
            MessageBox.Show("The prefix used to call bot commands (default: '!'). Every character is taken into account (including spaces etc.).", "",
                MessageBoxButtons.OK);
        }

        private void resetPointsButton_Click(object sender, EventArgs e)
        {
            UserHandler.ClearPoints();
            MessageBox.Show("Points Cleared!", "Clear Commands", MessageBoxButtons.OK);
        }

        private void resetCommandsButton_Click(object sender, EventArgs e) 
        {
            screen.ClearCommands();
            MessageBox.Show("Commands Cleared!", "Clear Commands", MessageBoxButtons.OK);
        }
    }
}
