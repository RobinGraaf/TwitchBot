namespace TwitchBot {
    partial class SettingsForm {
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
            this.pointTimerText = new System.Windows.Forms.TextBox();
            this.pointTimer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pointTimerHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pointTimerText
            // 
            this.pointTimerText.Location = new System.Drawing.Point(29, 50);
            this.pointTimerText.Name = "pointTimerText";
            this.pointTimerText.Size = new System.Drawing.Size(100, 20);
            this.pointTimerText.TabIndex = 0;
            // 
            // pointTimer
            // 
            this.pointTimer.AutoSize = true;
            this.pointTimer.Location = new System.Drawing.Point(50, 34);
            this.pointTimer.Name = "pointTimer";
            this.pointTimer.Size = new System.Drawing.Size(60, 13);
            this.pointTimer.TabIndex = 1;
            this.pointTimer.Text = "Point Timer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pointTimerHelp
            // 
            this.pointTimerHelp.Location = new System.Drawing.Point(135, 50);
            this.pointTimerHelp.Name = "pointTimerHelp";
            this.pointTimerHelp.Size = new System.Drawing.Size(19, 20);
            this.pointTimerHelp.TabIndex = 3;
            this.pointTimerHelp.Text = "?";
            this.pointTimerHelp.UseVisualStyleBackColor = true;
            this.pointTimerHelp.Click += new System.EventHandler(this.pointTimerHelp_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 230);
            this.Controls.Add(this.pointTimerHelp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pointTimer);
            this.Controls.Add(this.pointTimerText);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pointTimerText;
        private System.Windows.Forms.Label pointTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pointTimerHelp;
    }
}