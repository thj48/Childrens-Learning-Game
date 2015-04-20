namespace VocabExpress
{
    partial class TestResults
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
            this.displayWordsTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.finishedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayWordsTextBox
            // 
            this.displayWordsTextBox.Location = new System.Drawing.Point(17, 36);
            this.displayWordsTextBox.Name = "displayWordsTextBox";
            this.displayWordsTextBox.ReadOnly = true;
            this.displayWordsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.displayWordsTextBox.Size = new System.Drawing.Size(229, 189);
            this.displayWordsTextBox.TabIndex = 0;
            this.displayWordsTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "These are the results from the most recent test taken";
            // 
            // finishedButton
            // 
            this.finishedButton.Location = new System.Drawing.Point(97, 236);
            this.finishedButton.Name = "finishedButton";
            this.finishedButton.Size = new System.Drawing.Size(75, 23);
            this.finishedButton.TabIndex = 2;
            this.finishedButton.Text = "Finished";
            this.finishedButton.UseVisualStyleBackColor = true;
            this.finishedButton.Click += new System.EventHandler(this.finishedButton_Click);
            // 
            // TestResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 268);
            this.Controls.Add(this.finishedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayWordsTextBox);
            this.Name = "TestResults";
            this.Text = "TestResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayWordsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button finishedButton;
    }
}