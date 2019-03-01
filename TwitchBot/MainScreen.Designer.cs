namespace TwitchBot {
    partial class MainScreen {
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
            this.aLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.botnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.tokenLinkLabel = new System.Windows.Forms.LinkLabel();
            this.startBotButton = new System.Windows.Forms.Button();
            this.showCommandsButton = new System.Windows.Forms.Button();
            this.addCommandButton = new System.Windows.Forms.Button();
            this.clearCommandsButton = new System.Windows.Forms.Button();
            this.pointsTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsButton = new System.Windows.Forms.Button();
            this.minigamesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(12, 107);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(32, 13);
            this.aLabel.TabIndex = 0;
            this.aLabel.Text = "Chat:";
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(12, 31);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(143, 20);
            this.channelTextBox.TabIndex = 1;
            // 
            // botnameTextBox
            // 
            this.botnameTextBox.Location = new System.Drawing.Point(12, 71);
            this.botnameTextBox.Name = "botnameTextBox";
            this.botnameTextBox.Size = new System.Drawing.Size(143, 20);
            this.botnameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Channel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bot name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "OAUTH Token";
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Location = new System.Drawing.Point(173, 31);
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.PasswordChar = '*';
            this.tokenTextBox.Size = new System.Drawing.Size(143, 20);
            this.tokenTextBox.TabIndex = 5;
            this.tokenTextBox.UseSystemPasswordChar = true;
            // 
            // tokenLinkLabel
            // 
            this.tokenLinkLabel.AutoSize = true;
            this.tokenLinkLabel.Location = new System.Drawing.Point(258, 15);
            this.tokenLinkLabel.Name = "tokenLinkLabel";
            this.tokenLinkLabel.Size = new System.Drawing.Size(58, 13);
            this.tokenLinkLabel.TabIndex = 7;
            this.tokenLinkLabel.TabStop = true;
            this.tokenLinkLabel.Text = "Get Token";
            this.tokenLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // startBotButton
            // 
            this.startBotButton.Location = new System.Drawing.Point(173, 69);
            this.startBotButton.Name = "startBotButton";
            this.startBotButton.Size = new System.Drawing.Size(143, 23);
            this.startBotButton.TabIndex = 8;
            this.startBotButton.Text = "Start Bot";
            this.startBotButton.UseVisualStyleBackColor = true;
            this.startBotButton.Click += new System.EventHandler(this.startBotButton_Click);
            // 
            // showCommandsButton
            // 
            this.showCommandsButton.Location = new System.Drawing.Point(370, 29);
            this.showCommandsButton.Name = "showCommandsButton";
            this.showCommandsButton.Size = new System.Drawing.Size(143, 23);
            this.showCommandsButton.TabIndex = 9;
            this.showCommandsButton.Text = "Show Commands";
            this.showCommandsButton.UseVisualStyleBackColor = true;
            this.showCommandsButton.Click += new System.EventHandler(this.showCommandsButton_Click);
            // 
            // addCommandButton
            // 
            this.addCommandButton.Location = new System.Drawing.Point(530, 29);
            this.addCommandButton.Name = "addCommandButton";
            this.addCommandButton.Size = new System.Drawing.Size(143, 23);
            this.addCommandButton.TabIndex = 10;
            this.addCommandButton.Text = "Add Command";
            this.addCommandButton.UseVisualStyleBackColor = true;
            this.addCommandButton.Click += new System.EventHandler(this.addCommandButton_Click);
            // 
            // clearCommandsButton
            // 
            this.clearCommandsButton.Location = new System.Drawing.Point(690, 29);
            this.clearCommandsButton.Name = "clearCommandsButton";
            this.clearCommandsButton.Size = new System.Drawing.Size(143, 23);
            this.clearCommandsButton.TabIndex = 11;
            this.clearCommandsButton.Text = "Clear Commands";
            this.clearCommandsButton.UseVisualStyleBackColor = true;
            this.clearCommandsButton.Click += new System.EventHandler(this.clearCommandsButton_Click);
            // 
            // pointsTimer
            // 
            this.pointsTimer.Interval = 600000;
            this.pointsTimer.Tick += new System.EventHandler(this.pointsTimer_Tick);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(690, 69);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(143, 23);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.Text = "Other Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // minigamesButton
            // 
            this.minigamesButton.Location = new System.Drawing.Point(530, 69);
            this.minigamesButton.Name = "minigamesButton";
            this.minigamesButton.Size = new System.Drawing.Size(143, 23);
            this.minigamesButton.TabIndex = 13;
            this.minigamesButton.Text = "Minigames";
            this.minigamesButton.UseVisualStyleBackColor = true;
            this.minigamesButton.Click += new System.EventHandler(this.minigamesButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.minigamesButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.clearCommandsButton);
            this.Controls.Add(this.addCommandButton);
            this.Controls.Add(this.showCommandsButton);
            this.Controls.Add(this.startBotButton);
            this.Controls.Add(this.tokenLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botnameTextBox);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.aLabel);
            this.Name = "MainScreen";
            this.Text = "Twitch Bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.TextBox botnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.LinkLabel tokenLinkLabel;
        private System.Windows.Forms.Button startBotButton;
        private System.Windows.Forms.Button showCommandsButton;
        private System.Windows.Forms.Button addCommandButton;
        private System.Windows.Forms.Button clearCommandsButton;
        private System.Windows.Forms.Button settingsButton;
        public System.Windows.Forms.Timer pointsTimer;
        private System.Windows.Forms.Button minigamesButton;
    }
}

