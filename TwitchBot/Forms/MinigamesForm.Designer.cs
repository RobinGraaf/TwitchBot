namespace TwitchBot {
    partial class MinigamesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.raffleButton = new System.Windows.Forms.Button();
            this.rafflePanel = new System.Windows.Forms.Panel();
            this.subscriberBar = new System.Windows.Forms.TrackBar();
            this.followerBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stopRaffleButton = new System.Windows.Forms.Button();
            this.startRaffleButton = new System.Windows.Forms.Button();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keywordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entryfeeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.raffleTimer = new System.Windows.Forms.Timer(this.components);
            this.raffleJoinedLabel = new System.Windows.Forms.Label();
            this.raffleWonLabel = new System.Windows.Forms.Label();
            this.raffleOnGoingLabel = new System.Windows.Forms.Label();
            this.keywordCaseSensitive = new System.Windows.Forms.CheckBox();
            this.raffleTimeLabel = new System.Windows.Forms.Label();
            this.secondsCounter = new System.Windows.Forms.Timer(this.components);
            this.rafflePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.followerBar)).BeginInit();
            this.SuspendLayout();
            // 
            // raffleButton
            // 
            this.raffleButton.Location = new System.Drawing.Point(46, 27);
            this.raffleButton.Name = "raffleButton";
            this.raffleButton.Size = new System.Drawing.Size(115, 23);
            this.raffleButton.TabIndex = 0;
            this.raffleButton.Text = "Raffle";
            this.raffleButton.UseVisualStyleBackColor = true;
            this.raffleButton.Click += new System.EventHandler(this.raffleButton_Click);
            // 
            // rafflePanel
            // 
            this.rafflePanel.Controls.Add(this.raffleTimeLabel);
            this.rafflePanel.Controls.Add(this.keywordCaseSensitive);
            this.rafflePanel.Controls.Add(this.raffleOnGoingLabel);
            this.rafflePanel.Controls.Add(this.raffleWonLabel);
            this.rafflePanel.Controls.Add(this.raffleJoinedLabel);
            this.rafflePanel.Controls.Add(this.subscriberBar);
            this.rafflePanel.Controls.Add(this.followerBar);
            this.rafflePanel.Controls.Add(this.label5);
            this.rafflePanel.Controls.Add(this.label4);
            this.rafflePanel.Controls.Add(this.stopRaffleButton);
            this.rafflePanel.Controls.Add(this.startRaffleButton);
            this.rafflePanel.Controls.Add(this.timerBox);
            this.rafflePanel.Controls.Add(this.label3);
            this.rafflePanel.Controls.Add(this.keywordBox);
            this.rafflePanel.Controls.Add(this.label2);
            this.rafflePanel.Controls.Add(this.entryfeeBox);
            this.rafflePanel.Controls.Add(this.label1);
            this.rafflePanel.Location = new System.Drawing.Point(12, 56);
            this.rafflePanel.Name = "rafflePanel";
            this.rafflePanel.Size = new System.Drawing.Size(776, 382);
            this.rafflePanel.TabIndex = 1;
            this.rafflePanel.Visible = false;
            // 
            // subscriberBar
            // 
            this.subscriberBar.Location = new System.Drawing.Point(30, 244);
            this.subscriberBar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.subscriberBar.Name = "subscriberBar";
            this.subscriberBar.Size = new System.Drawing.Size(104, 45);
            this.subscriberBar.TabIndex = 15;
            this.subscriberBar.Tag = "";
            this.subscriberBar.Visible = false;
            // 
            // followerBar
            // 
            this.followerBar.Location = new System.Drawing.Point(30, 183);
            this.followerBar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.followerBar.Name = "followerBar";
            this.followerBar.Size = new System.Drawing.Size(104, 45);
            this.followerBar.TabIndex = 14;
            this.followerBar.Tag = "";
            this.followerBar.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Subscriber Bonus (0-10)";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Follower Bonus (0-10)";
            this.label4.Visible = false;
            // 
            // stopRaffleButton
            // 
            this.stopRaffleButton.Location = new System.Drawing.Point(34, 321);
            this.stopRaffleButton.Name = "stopRaffleButton";
            this.stopRaffleButton.Size = new System.Drawing.Size(100, 23);
            this.stopRaffleButton.TabIndex = 10;
            this.stopRaffleButton.Text = "Stop Raffle";
            this.stopRaffleButton.UseVisualStyleBackColor = true;
            this.stopRaffleButton.Visible = false;
            this.stopRaffleButton.Click += new System.EventHandler(this.stopRaffleButton_Click);
            // 
            // startRaffleButton
            // 
            this.startRaffleButton.Location = new System.Drawing.Point(34, 292);
            this.startRaffleButton.Name = "startRaffleButton";
            this.startRaffleButton.Size = new System.Drawing.Size(100, 23);
            this.startRaffleButton.TabIndex = 9;
            this.startRaffleButton.Text = "Start Raffle";
            this.startRaffleButton.UseVisualStyleBackColor = true;
            this.startRaffleButton.Click += new System.EventHandler(this.startRaffleButton_Click);
            // 
            // timerBox
            // 
            this.timerBox.Location = new System.Drawing.Point(34, 144);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(100, 20);
            this.timerBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Close Timer";
            // 
            // keywordBox
            // 
            this.keywordBox.Location = new System.Drawing.Point(34, 82);
            this.keywordBox.Name = "keywordBox";
            this.keywordBox.Size = new System.Drawing.Size(100, 20);
            this.keywordBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Keyword";
            // 
            // entryfeeBox
            // 
            this.entryfeeBox.Location = new System.Drawing.Point(34, 43);
            this.entryfeeBox.Name = "entryfeeBox";
            this.entryfeeBox.Size = new System.Drawing.Size(100, 20);
            this.entryfeeBox.TabIndex = 1;
            this.entryfeeBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry Fee";
            this.label1.Visible = false;
            // 
            // raffleTimer
            // 
            this.raffleTimer.Tick += new System.EventHandler(this.raffleTimer_Tick);
            // 
            // raffleJoinedLabel
            // 
            this.raffleJoinedLabel.AutoSize = true;
            this.raffleJoinedLabel.Location = new System.Drawing.Point(194, 66);
            this.raffleJoinedLabel.Name = "raffleJoinedLabel";
            this.raffleJoinedLabel.Size = new System.Drawing.Size(81, 13);
            this.raffleJoinedLabel.TabIndex = 16;
            this.raffleJoinedLabel.Text = "Joined Viewers:";
            // 
            // raffleWonLabel
            // 
            this.raffleWonLabel.AutoSize = true;
            this.raffleWonLabel.Location = new System.Drawing.Point(658, 158);
            this.raffleWonLabel.Name = "raffleWonLabel";
            this.raffleWonLabel.Size = new System.Drawing.Size(44, 13);
            this.raffleWonLabel.TabIndex = 17;
            this.raffleWonLabel.Text = "Winner:";
            this.raffleWonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.raffleWonLabel.Visible = false;
            // 
            // raffleOnGoingLabel
            // 
            this.raffleOnGoingLabel.AutoSize = true;
            this.raffleOnGoingLabel.Location = new System.Drawing.Point(194, 27);
            this.raffleOnGoingLabel.Name = "raffleOnGoingLabel";
            this.raffleOnGoingLabel.Size = new System.Drawing.Size(80, 13);
            this.raffleOnGoingLabel.TabIndex = 18;
            this.raffleOnGoingLabel.Text = "Raffle is started";
            this.raffleOnGoingLabel.Visible = false;
            // 
            // keywordCaseSensitive
            // 
            this.keywordCaseSensitive.AutoSize = true;
            this.keywordCaseSensitive.Location = new System.Drawing.Point(34, 108);
            this.keywordCaseSensitive.Name = "keywordCaseSensitive";
            this.keywordCaseSensitive.Size = new System.Drawing.Size(94, 17);
            this.keywordCaseSensitive.TabIndex = 19;
            this.keywordCaseSensitive.Text = "Case sensitive";
            this.keywordCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // raffleTimeLabel
            // 
            this.raffleTimeLabel.AutoSize = true;
            this.raffleTimeLabel.Location = new System.Drawing.Point(292, 27);
            this.raffleTimeLabel.Name = "raffleTimeLabel";
            this.raffleTimeLabel.Size = new System.Drawing.Size(89, 13);
            this.raffleTimeLabel.TabIndex = 20;
            this.raffleTimeLabel.Text = "Time Remaining: ";
            this.raffleTimeLabel.Visible = false;
            // 
            // secondsCounter
            // 
            this.secondsCounter.Interval = 1000;
            this.secondsCounter.Tick += new System.EventHandler(this.secondsCounter_Tick);
            // 
            // MinigamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rafflePanel);
            this.Controls.Add(this.raffleButton);
            this.Name = "MinigamesForm";
            this.Text = "MinigamesForm";
            this.rafflePanel.ResumeLayout(false);
            this.rafflePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.followerBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button raffleButton;
        private System.Windows.Forms.Panel rafflePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keywordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entryfeeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar followerBar;
        private System.Windows.Forms.TrackBar subscriberBar;
        public System.Windows.Forms.Timer raffleTimer;
        public System.Windows.Forms.Label raffleJoinedLabel;
        public System.Windows.Forms.Label raffleWonLabel;
        public System.Windows.Forms.Button stopRaffleButton;
        public System.Windows.Forms.Button startRaffleButton;
        public System.Windows.Forms.Label raffleOnGoingLabel;
        public System.Windows.Forms.CheckBox keywordCaseSensitive;
        public System.Windows.Forms.Label raffleTimeLabel;
        public System.Windows.Forms.Timer secondsCounter;
    }
}