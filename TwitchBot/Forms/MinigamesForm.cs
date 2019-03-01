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
            raffle.StartRaffle(int.TryParse(entryfeeBox.Text, out var entryfee) ? entryfee : 0, 
                TextBoxHandler.CheckForInput(keywordBox, out string keyword) ? (keywordCaseSensitive.Checked ? keyword : keyword.ToLower()) : "", 
                TextBoxHandler.CheckForInput(timerBox, out string timerText) ? int.Parse(timerText) : 1,
                followerBar.Value, 
                subscriberBar.Value);
        }

        private void stopRaffleButton_Click(object sender, EventArgs e)
        {
            startRaffleButton.Show();
            raffleOnGoingLabel.Hide();
            stopRaffleButton.Hide();
            raffle.StopRaffle();
        }

        private void raffleTimer_Tick(object sender, EventArgs e)
        {
            raffle.Tick();
        }

        private void secondsCounter_Tick(object sender, EventArgs e)
        {
            raffle.secondsTick();
        }
    }
}
