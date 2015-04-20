namespace VocabExpress
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.newListButton = new System.Windows.Forms.Button();
            this.viewListButton = new System.Windows.Forms.Button();
            this.takeTestButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.viewReportButton = new System.Windows.Forms.Button();
            this.playMatchButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Vocab Express!!!";
            // 
            // newListButton
            // 
            this.newListButton.Location = new System.Drawing.Point(89, 56);
            this.newListButton.Name = "newListButton";
            this.newListButton.Size = new System.Drawing.Size(134, 42);
            this.newListButton.TabIndex = 1;
            this.newListButton.Text = "Create\\Clear A New Word List";
            this.newListButton.UseVisualStyleBackColor = true;
            this.newListButton.Click += new System.EventHandler(this.newListButton_Click);
            // 
            // viewListButton
            // 
            this.viewListButton.Location = new System.Drawing.Point(89, 104);
            this.viewListButton.Name = "viewListButton";
            this.viewListButton.Size = new System.Drawing.Size(134, 42);
            this.viewListButton.TabIndex = 2;
            this.viewListButton.Text = "View\\Edit Word List";
            this.viewListButton.UseVisualStyleBackColor = true;
            this.viewListButton.Click += new System.EventHandler(this.viewListButton_Click);
            // 
            // takeTestButton
            // 
            this.takeTestButton.Location = new System.Drawing.Point(89, 152);
            this.takeTestButton.Name = "takeTestButton";
            this.takeTestButton.Size = new System.Drawing.Size(134, 42);
            this.takeTestButton.TabIndex = 3;
            this.takeTestButton.Text = "Take A Pratice Test ";
            this.takeTestButton.UseVisualStyleBackColor = true;
            this.takeTestButton.Click += new System.EventHandler(this.takeTestButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select an option form below ";
            // 
            // viewReportButton
            // 
            this.viewReportButton.Location = new System.Drawing.Point(89, 248);
            this.viewReportButton.Name = "viewReportButton";
            this.viewReportButton.Size = new System.Drawing.Size(134, 42);
            this.viewReportButton.TabIndex = 5;
            this.viewReportButton.Text = "View Test Report";
            this.viewReportButton.UseVisualStyleBackColor = true;
            this.viewReportButton.Click += new System.EventHandler(this.viewReportButton_Click);
            // 
            // playMatchButton
            // 
            this.playMatchButton.Location = new System.Drawing.Point(89, 200);
            this.playMatchButton.Name = "playMatchButton";
            this.playMatchButton.Size = new System.Drawing.Size(134, 42);
            this.playMatchButton.TabIndex = 6;
            this.playMatchButton.Text = "Match That Word";
            this.playMatchButton.UseVisualStyleBackColor = true;
            this.playMatchButton.Click += new System.EventHandler(this.playMatchButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel.Location = new System.Drawing.Point(12, 41);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(297, 13);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Need to add more words to list before you can use that option";
            this.errorLabel.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 299);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.playMatchButton);
            this.Controls.Add(this.viewReportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.takeTestButton);
            this.Controls.Add(this.viewListButton);
            this.Controls.Add(this.newListButton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "VocabExpress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newListButton;
        private System.Windows.Forms.Button viewListButton;
        private System.Windows.Forms.Button takeTestButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewReportButton;
        private System.Windows.Forms.Button playMatchButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

