namespace VocabExpress
{
    partial class AddWord
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
            this.finishButton = new System.Windows.Forms.Button();
            this.addAnotherWordButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.imageBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // finishButton
            // 
            this.finishButton.Enabled = false;
            this.finishButton.Location = new System.Drawing.Point(165, 241);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 0;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // addAnotherWordButton
            // 
            this.addAnotherWordButton.Enabled = false;
            this.addAnotherWordButton.Location = new System.Drawing.Point(12, 241);
            this.addAnotherWordButton.Name = "addAnotherWordButton";
            this.addAnotherWordButton.Size = new System.Drawing.Size(124, 23);
            this.addAnotherWordButton.TabIndex = 1;
            this.addAnotherWordButton.Text = "Add Another Word";
            this.addAnotherWordButton.UseVisualStyleBackColor = true;
            this.addAnotherWordButton.Click += new System.EventHandler(this.addAnotherWordButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(37, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(181, 120);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(82, 208);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(158, 20);
            this.inputTextBox.TabIndex = 3;
            // 
            // imageBrowseButton
            // 
            this.imageBrowseButton.Location = new System.Drawing.Point(68, 176);
            this.imageBrowseButton.Name = "imageBrowseButton";
            this.imageBrowseButton.Size = new System.Drawing.Size(111, 23);
            this.imageBrowseButton.TabIndex = 4;
            this.imageBrowseButton.Text = "Browse for Image";
            this.imageBrowseButton.UseVisualStyleBackColor = true;
            this.imageBrowseButton.Click += new System.EventHandler(this.imageBrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a image and enter word below ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter word :";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(37, 31);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(181, 13);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "* A image and  word must be entered";
            this.errorLabel.Visible = false;
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 276);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBrowseButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.addAnotherWordButton);
            this.Controls.Add(this.finishButton);
            this.Name = "AddWord";
            this.Text = "AddWord";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button addAnotherWordButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button imageBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorLabel;
    }
}