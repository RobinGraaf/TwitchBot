using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchBot.Objects;

namespace TwitchBot.Minigames {
    class Raffle
    {
        private MinigamesForm minigamesForm = (MinigamesForm) Application.OpenForms["MinigamesForm"];

        private string _keyword;
        private int _entryFee, _followerBonus, _subscriberBonus;
        private int _secondsLeft;
        List<string> _joinedViewers = new List<string>();

        public void StartRaffle(int entryFee, string keyword, int closeTimer, int followerBonus, int subscriberBonus)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                ChatLink.OnNewMessage += ListenForEntries;

                _entryFee = entryFee;
                _keyword = keyword;
                _secondsLeft = closeTimer;

                minigamesForm.raffleTimer.Interval = closeTimer * 1000;
                minigamesForm.raffleTimer.Enabled = true;

                minigamesForm.raffleTimeLabel.Text = "Time Remaining: " + _secondsLeft;
                minigamesForm.secondsCounter.Enabled = true;

                _followerBonus = followerBonus;
                _subscriberBonus = subscriberBonus;

                minigamesForm.startRaffleButton.Hide();
                minigamesForm.raffleOnGoingLabel.Show();
                minigamesForm.stopRaffleButton.Show();
                minigamesForm.raffleTimeLabel.Show();
            }
        }

        private void ListenForEntries(object sender, NewMessageArgs args)
        {
            var message = minigamesForm.keywordCaseSensitive.Checked ? args.Message : args.Message.ToLower();

            if (message.Contains(_keyword)) {
                if (!_joinedViewers.Contains(args.Speaker))
                {
                    _joinedViewers.Add(args.Speaker);
                    minigamesForm.raffleJoinedLabel.Text += $"\r\n{args.Speaker}";
                }
            }
        }

        public void Tick()
        {
            Random r = new Random();
            if (_joinedViewers.Count > 0)
            {
                var chosenViewer = _joinedViewers[r.Next(0, _joinedViewers.Count)];
                minigamesForm.raffleWonLabel.Text = "Won: \r\n" + chosenViewer;
                minigamesForm.raffleWonLabel.Show();
                minigamesForm.startRaffleButton.Show();
                minigamesForm.raffleOnGoingLabel.Hide();
                minigamesForm.raffleTimeLabel.Hide();
            } else StopRaffle();
        }

        public void secondsTick()
        {
            minigamesForm.raffleTimeLabel.Text = "Time Remaining: " + --_secondsLeft;
        }

        public void StopRaffle()
        {
            ChatLink.OnNewMessage -= ListenForEntries;
            minigamesForm.startRaffleButton.Show();
            minigamesForm.raffleOnGoingLabel.Hide();
            minigamesForm.stopRaffleButton.Hide();
            minigamesForm.raffleWonLabel.Hide();
            minigamesForm.raffleTimeLabel.Hide();
        }
    }
}
