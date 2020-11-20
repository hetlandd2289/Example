namespace exam3Practical
{
    partial class exam3Practical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exam3Practical));
            this.instructionLabel = new System.Windows.Forms.Label();
            this.problemLabel1 = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.missedProblemsListBox = new System.Windows.Forms.ListBox();
            this.problemLabel2 = new System.Windows.Forms.Label();
            this.problemLabel3 = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.missedProblemsLabel = new System.Windows.Forms.Label();
            this.kilroyPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kilroyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(90, 24);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(458, 17);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter the answer to the addition problem in the text box provided below.";
            // 
            // problemLabel1
            // 
            this.problemLabel1.AutoSize = true;
            this.problemLabel1.Location = new System.Drawing.Point(90, 55);
            this.problemLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.problemLabel1.Name = "problemLabel1";
            this.problemLabel1.Size = new System.Drawing.Size(0, 17);
            this.problemLabel1.TabIndex = 1;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(93, 137);
            this.answerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(132, 22);
            this.answerTextBox.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(93, 188);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 28);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(93, 265);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(93, 229);
            this.displayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(100, 28);
            this.displayButton.TabIndex = 5;
            this.displayButton.Text = "Display Incorrect Answers";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // missedProblemsListBox
            // 
            this.missedProblemsListBox.FormattingEnabled = true;
            this.missedProblemsListBox.ItemHeight = 16;
            this.missedProblemsListBox.Location = new System.Drawing.Point(256, 177);
            this.missedProblemsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.missedProblemsListBox.Name = "missedProblemsListBox";
            this.missedProblemsListBox.Size = new System.Drawing.Size(274, 116);
            this.missedProblemsListBox.TabIndex = 6;
            this.missedProblemsListBox.Visible = false;
            // 
            // problemLabel2
            // 
            this.problemLabel2.AutoSize = true;
            this.problemLabel2.Location = new System.Drawing.Point(90, 83);
            this.problemLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.problemLabel2.Name = "problemLabel2";
            this.problemLabel2.Size = new System.Drawing.Size(0, 17);
            this.problemLabel2.TabIndex = 7;
            // 
            // problemLabel3
            // 
            this.problemLabel3.AutoSize = true;
            this.problemLabel3.Location = new System.Drawing.Point(90, 107);
            this.problemLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.problemLabel3.Name = "problemLabel3";
            this.problemLabel3.Size = new System.Drawing.Size(0, 17);
            this.problemLabel3.TabIndex = 8;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // missedProblemsLabel
            // 
            this.missedProblemsLabel.AutoSize = true;
            this.missedProblemsLabel.Location = new System.Drawing.Point(253, 156);
            this.missedProblemsLabel.Name = "missedProblemsLabel";
            this.missedProblemsLabel.Size = new System.Drawing.Size(119, 17);
            this.missedProblemsLabel.TabIndex = 9;
            this.missedProblemsLabel.Text = "Missed Problems:";
            this.missedProblemsLabel.Visible = false;
            // 
            // kilroyPictureBox
            // 
            this.kilroyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("kilroyPictureBox.Image")));
            this.kilroyPictureBox.Location = new System.Drawing.Point(420, 118);
            this.kilroyPictureBox.Name = "kilroyPictureBox";
            this.kilroyPictureBox.Size = new System.Drawing.Size(100, 120);
            this.kilroyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kilroyPictureBox.TabIndex = 10;
            this.kilroyPictureBox.TabStop = false;
            this.kilroyPictureBox.Visible = false;
            // 
            // exam3Practical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 360);
            this.Controls.Add(this.kilroyPictureBox);
            this.Controls.Add(this.missedProblemsLabel);
            this.Controls.Add(this.problemLabel3);
            this.Controls.Add(this.problemLabel2);
            this.Controls.Add(this.missedProblemsListBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.problemLabel1);
            this.Controls.Add(this.instructionLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "exam3Practical";
            this.Text = "Exam 3 Practical";
            this.Load += new System.EventHandler(this.exam3Practical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kilroyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label problemLabel1;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ListBox missedProblemsListBox;
        private System.Windows.Forms.Label problemLabel2;
        private System.Windows.Forms.Label problemLabel3;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label missedProblemsLabel;
        private System.Windows.Forms.PictureBox kilroyPictureBox;
    }
}

