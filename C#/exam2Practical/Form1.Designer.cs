namespace exam2Practical
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.programListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.yearsLeftInProgramLabel = new System.Windows.Forms.Label();
            this.yearsLeftInProgramTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.hobbiesOutputLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.ageOutputLabel = new System.Windows.Forms.Label();
            this.programLabel = new System.Windows.Forms.Label();
            this.hobbiesGroupBox = new System.Windows.Forms.GroupBox();
            this.sportsCheckBox = new System.Windows.Forms.CheckBox();
            this.videoGamesCheckBox = new System.Windows.Forms.CheckBox();
            this.photographyCheckBox = new System.Windows.Forms.CheckBox();
            this.readingCheckBox = new System.Windows.Forms.CheckBox();
            this.writingCheckBox = new System.Windows.Forms.CheckBox();
            this.animeCheckBox = new System.Windows.Forms.CheckBox();
            this.collectingCheckBox = new System.Windows.Forms.CheckBox();
            this.hobbiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(35, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(35, 79);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(37, 17);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Age:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(108, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(108, 79);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(155, 22);
            this.ageTextBox.TabIndex = 1;
            // 
            // programListBox
            // 
            this.programListBox.FormattingEnabled = true;
            this.programListBox.ItemHeight = 16;
            this.programListBox.Items.AddRange(new object[] {
            "A/A or A/S",
            "Aviation",
            "Computer Programming",
            "Engineering Technology",
            "Environmental Science",
            "Music",
            "Video Game Design",
            "Web Design"});
            this.programListBox.Location = new System.Drawing.Point(38, 127);
            this.programListBox.Name = "programListBox";
            this.programListBox.Size = new System.Drawing.Size(225, 132);
            this.programListBox.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(394, 292);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // yearsLeftInProgramLabel
            // 
            this.yearsLeftInProgramLabel.AutoSize = true;
            this.yearsLeftInProgramLabel.Location = new System.Drawing.Point(277, 267);
            this.yearsLeftInProgramLabel.Name = "yearsLeftInProgramLabel";
            this.yearsLeftInProgramLabel.Size = new System.Drawing.Size(150, 17);
            this.yearsLeftInProgramLabel.TabIndex = 7;
            this.yearsLeftInProgramLabel.Text = "Years Left in Program:";
            // 
            // yearsLeftInProgramTextBox
            // 
            this.yearsLeftInProgramTextBox.Location = new System.Drawing.Point(433, 264);
            this.yearsLeftInProgramTextBox.Name = "yearsLeftInProgramTextBox";
            this.yearsLeftInProgramTextBox.Size = new System.Drawing.Size(36, 22);
            this.yearsLeftInProgramTextBox.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(280, 292);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // hobbiesOutputLabel
            // 
            this.hobbiesOutputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.hobbiesOutputLabel.Location = new System.Drawing.Point(35, 329);
            this.hobbiesOutputLabel.Name = "hobbiesOutputLabel";
            this.hobbiesOutputLabel.Size = new System.Drawing.Size(434, 38);
            this.hobbiesOutputLabel.TabIndex = 12;
            this.hobbiesOutputLabel.Text = "Hobbies:";
            this.hobbiesOutputLabel.Visible = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.userNameLabel.Location = new System.Drawing.Point(35, 278);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(49, 17);
            this.userNameLabel.TabIndex = 13;
            this.userNameLabel.Text = "Name:";
            this.userNameLabel.Visible = false;
            // 
            // ageOutputLabel
            // 
            this.ageOutputLabel.AutoSize = true;
            this.ageOutputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ageOutputLabel.Location = new System.Drawing.Point(35, 295);
            this.ageOutputLabel.Name = "ageOutputLabel";
            this.ageOutputLabel.Size = new System.Drawing.Size(150, 17);
            this.ageOutputLabel.TabIndex = 14;
            this.ageOutputLabel.Text = "Age Upon Graduation:";
            this.ageOutputLabel.Visible = false;
            // 
            // programLabel
            // 
            this.programLabel.AutoSize = true;
            this.programLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.programLabel.Location = new System.Drawing.Point(35, 312);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(66, 17);
            this.programLabel.TabIndex = 15;
            this.programLabel.Text = "Program:";
            this.programLabel.Visible = false;
            // 
            // hobbiesGroupBox
            // 
            this.hobbiesGroupBox.Controls.Add(this.collectingCheckBox);
            this.hobbiesGroupBox.Controls.Add(this.animeCheckBox);
            this.hobbiesGroupBox.Controls.Add(this.writingCheckBox);
            this.hobbiesGroupBox.Controls.Add(this.readingCheckBox);
            this.hobbiesGroupBox.Controls.Add(this.photographyCheckBox);
            this.hobbiesGroupBox.Controls.Add(this.videoGamesCheckBox);
            this.hobbiesGroupBox.Controls.Add(this.sportsCheckBox);
            this.hobbiesGroupBox.Location = new System.Drawing.Point(280, 48);
            this.hobbiesGroupBox.Name = "hobbiesGroupBox";
            this.hobbiesGroupBox.Size = new System.Drawing.Size(189, 210);
            this.hobbiesGroupBox.TabIndex = 3;
            this.hobbiesGroupBox.TabStop = false;
            this.hobbiesGroupBox.Text = "Hobbies";
            // 
            // sportsCheckBox
            // 
            this.sportsCheckBox.AutoSize = true;
            this.sportsCheckBox.Location = new System.Drawing.Point(6, 21);
            this.sportsCheckBox.Name = "sportsCheckBox";
            this.sportsCheckBox.Size = new System.Drawing.Size(71, 21);
            this.sportsCheckBox.TabIndex = 0;
            this.sportsCheckBox.Text = "Sports";
            this.sportsCheckBox.UseVisualStyleBackColor = true;
            // 
            // videoGamesCheckBox
            // 
            this.videoGamesCheckBox.AutoSize = true;
            this.videoGamesCheckBox.Location = new System.Drawing.Point(6, 49);
            this.videoGamesCheckBox.Name = "videoGamesCheckBox";
            this.videoGamesCheckBox.Size = new System.Drawing.Size(115, 21);
            this.videoGamesCheckBox.TabIndex = 1;
            this.videoGamesCheckBox.Text = "Video Games";
            this.videoGamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // photographyCheckBox
            // 
            this.photographyCheckBox.AutoSize = true;
            this.photographyCheckBox.Location = new System.Drawing.Point(6, 77);
            this.photographyCheckBox.Name = "photographyCheckBox";
            this.photographyCheckBox.Size = new System.Drawing.Size(111, 21);
            this.photographyCheckBox.TabIndex = 2;
            this.photographyCheckBox.Text = "Photography";
            this.photographyCheckBox.UseVisualStyleBackColor = true;
            // 
            // readingCheckBox
            // 
            this.readingCheckBox.AutoSize = true;
            this.readingCheckBox.Location = new System.Drawing.Point(6, 105);
            this.readingCheckBox.Name = "readingCheckBox";
            this.readingCheckBox.Size = new System.Drawing.Size(83, 21);
            this.readingCheckBox.TabIndex = 3;
            this.readingCheckBox.Text = "Reading";
            this.readingCheckBox.UseVisualStyleBackColor = true;
            // 
            // writingCheckBox
            // 
            this.writingCheckBox.AutoSize = true;
            this.writingCheckBox.Location = new System.Drawing.Point(6, 132);
            this.writingCheckBox.Name = "writingCheckBox";
            this.writingCheckBox.Size = new System.Drawing.Size(74, 21);
            this.writingCheckBox.TabIndex = 4;
            this.writingCheckBox.Text = "Writing";
            this.writingCheckBox.UseVisualStyleBackColor = true;
            // 
            // animeCheckBox
            // 
            this.animeCheckBox.AutoSize = true;
            this.animeCheckBox.Location = new System.Drawing.Point(6, 160);
            this.animeCheckBox.Name = "animeCheckBox";
            this.animeCheckBox.Size = new System.Drawing.Size(69, 21);
            this.animeCheckBox.TabIndex = 5;
            this.animeCheckBox.Text = "Anime";
            this.animeCheckBox.UseVisualStyleBackColor = true;
            // 
            // collectingCheckBox
            // 
            this.collectingCheckBox.AutoSize = true;
            this.collectingCheckBox.Location = new System.Drawing.Point(6, 188);
            this.collectingCheckBox.Name = "collectingCheckBox";
            this.collectingCheckBox.Size = new System.Drawing.Size(91, 21);
            this.collectingCheckBox.TabIndex = 6;
            this.collectingCheckBox.Text = "Collecting";
            this.collectingCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 401);
            this.Controls.Add(this.hobbiesGroupBox);
            this.Controls.Add(this.programLabel);
            this.Controls.Add(this.ageOutputLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.hobbiesOutputLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.yearsLeftInProgramTextBox);
            this.Controls.Add(this.yearsLeftInProgramLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.programListBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.hobbiesGroupBox.ResumeLayout(false);
            this.hobbiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.ListBox programListBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label yearsLeftInProgramLabel;
        private System.Windows.Forms.TextBox yearsLeftInProgramTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label hobbiesOutputLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label ageOutputLabel;
        private System.Windows.Forms.Label programLabel;
        private System.Windows.Forms.GroupBox hobbiesGroupBox;
        private System.Windows.Forms.CheckBox collectingCheckBox;
        private System.Windows.Forms.CheckBox animeCheckBox;
        private System.Windows.Forms.CheckBox writingCheckBox;
        private System.Windows.Forms.CheckBox readingCheckBox;
        private System.Windows.Forms.CheckBox photographyCheckBox;
        private System.Windows.Forms.CheckBox videoGamesCheckBox;
        private System.Windows.Forms.CheckBox sportsCheckBox;
    }
}

