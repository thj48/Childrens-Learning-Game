namespace VocabExpress
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.voiceButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(72, 268);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // voiceButton
            // 
            this.voiceButton.Location = new System.Drawing.Point(52, 196);
            this.voiceButton.Name = "voiceButton";
            this.voiceButton.Size = new System.Drawing.Size(110, 23);
            this.voiceButton.TabIndex = 1;
            this.voiceButton.Text = "Click to Hear Word ";
            this.voiceButton.UseVisualStyleBackColor = true;
            this.voiceButton.Click += new System.EventHandler(this.voiceButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(12, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(188, 152);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(44, 222);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(127, 13);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "*Must enter a word below";
            this.errorLabel.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(141, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Enter the word shown below";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(56, 239);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(145, 20);
            this.inputTextBox.TabIndex = 5;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(4, 242);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(48, 13);
            this.inputLabel.TabIndex = 6;
            this.inputLabel.Text = "Answer :";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 299);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.voiceButton);
            this.Controls.Add(this.submitButton);
            this.Name = "Test";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button voiceButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
    }
}