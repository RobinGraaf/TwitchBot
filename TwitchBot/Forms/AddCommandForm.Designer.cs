namespace TwitchBot {
    partial class AddCommandForm {
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
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveCommandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(43, 25);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(100, 20);
            this.commandTextBox.TabIndex = 0;
            this.commandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bot Response";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // responseTextBox
            // 
            this.responseTextBox.Location = new System.Drawing.Point(21, 79);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.Size = new System.Drawing.Size(146, 46);
            this.responseTextBox.TabIndex = 2;
            this.responseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(21, 157);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(146, 108);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveCommandButton
            // 
            this.saveCommandButton.Location = new System.Drawing.Point(43, 285);
            this.saveCommandButton.Name = "saveCommandButton";
            this.saveCommandButton.Size = new System.Drawing.Size(100, 23);
            this.saveCommandButton.TabIndex = 7;
            this.saveCommandButton.Text = "Save Command";
            this.saveCommandButton.UseVisualStyleBackColor = true;
            this.saveCommandButton.Click += new System.EventHandler(this.saveCommandButton_Click);
            // 
            // AddCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 330);
            this.Controls.Add(this.saveCommandButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.responseTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commandTextBox);
            this.Name = "AddCommandForm";
            this.Text = "AddCommandForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button saveCommandButton;
    }
}