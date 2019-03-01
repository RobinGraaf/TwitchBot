using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchBot.Minigames;

namespace TwitchBot {
    public partial class MinigamesForm : Form
    {
        private Raffle raffle;

        public MinigamesForm() {
            InitializeComponent();
        }

        private void raffleButton_Click(object sender, EventArgs e) {
            if (rafflePanel.Visible) { rafflePanel.Hide(); }
            else { rafflePanel.Show(); }
        }

        private void startRaffleButton_Click(object sender, EventArgs e)
        {
            raffle = new Raffle();
            raffle.StartRaffle(int.Parse(entryfeeBox.Text), keywordBox.Text, int.Parse(timerBox.Text), followerBar.Value, subscriberBar.Value);
        }

        private void stopRaffleButton_Click(object sender, EventArgs e)
        {
            raffle.StopRaffle();
        }
    }
}
