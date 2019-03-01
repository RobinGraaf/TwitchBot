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
            this.raffleButton = new System.Windows.Forms.Button();
            this.rafflePanel = new System.Windows.Forms.Panel();
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
            this.subscriberBar = new System.Windows.Forms.TrackBar();
            this.rafflePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.followerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBar)).BeginInit();
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
            // followerBar
            // 
            this.followerBar.Location = new System.Drawing.Point(30, 175);
            this.followerBar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.followerBar.Name = "followerBar";
            this.followerBar.Size = new System.Drawing.Size(104, 45);
            this.followerBar.TabIndex = 14;
            this.followerBar.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Subscriber Bonus (0-10)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Follower Bonus (0-10)";
            // 
            // stopRaffleButton
            // 
            this.stopRaffleButton.Location = new System.Drawing.Point(34, 323);
            this.stopRaffleButton.Name = "stopRaffleButton";
            this.stopRaffleButton.Size = new System.Drawing.Size(100, 23);
            this.stopRaffleButton.TabIndex = 10;
            this.stopRaffleButton.Text = "Stop Raffle";
            this.stopRaffleButton.UseVisualStyleBackColor = true;
            this.stopRaffleButton.Click += new System.EventHandler(this.stopRaffleButton_Click);
            // 
            // startRaffleButton
            // 
            this.startRaffleButton.Location = new System.Drawing.Point(34, 294);
            this.startRaffleButton.Name = "startRaffleButton";
            this.startRaffleButton.Size = new System.Drawing.Size(100, 23);
            this.startRaffleButton.TabIndex = 9;
            this.startRaffleButton.Text = "Start Raffle";
            this.startRaffleButton.UseVisualStyleBackColor = true;
            this.startRaffleButton.Click += new System.EventHandler(this.startRaffleButton_Click);
            // 
            // timerBox
            // 
            this.timerBox.Location = new System.Drawing.Point(34, 121);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(100, 20);
            this.timerBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 105);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry Fee";
            // 
            // subscriberBar
            // 
            this.subscriberBar.Location = new System.Drawing.Point(30, 236);
            this.subscriberBar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.subscriberBar.Name = "subscriberBar";
            this.subscriberBar.Size = new System.Drawing.Size(104, 45);
            this.subscriberBar.TabIndex = 15;
            this.subscriberBar.Tag = "";
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
            ((System.ComponentModel.ISupportInitialize)(this.followerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button raffleButton;
        private System.Windows.Forms.Panel rafflePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stopRaffleButton;
        private System.Windows.Forms.Button startRaffleButton;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keywordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entryfeeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar followerBar;
        private System.Windows.Forms.TrackBar subscriberBar;
    }
}