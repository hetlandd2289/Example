namespace examScoresJaggedArray
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
            this.section1ListBox = new System.Windows.Forms.ListBox();
            this.section3ListBox = new System.Windows.Forms.ListBox();
            this.section2ListBox = new System.Windows.Forms.ListBox();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.section1AveragaeLabel = new System.Windows.Forms.Label();
            this.section1AverageTextBox = new System.Windows.Forms.TextBox();
            this.section2AverageLabel = new System.Windows.Forms.Label();
            this.section2AverageTextBox = new System.Windows.Forms.TextBox();
            this.section3AverageTextBox = new System.Windows.Forms.TextBox();
            this.section3AverageLabel = new System.Windows.Forms.Label();
            this.generalAverageTextBox = new System.Windows.Forms.TextBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.highestGroupBox = new System.Windows.Forms.GroupBox();
            this.highSectionTextBox = new System.Windows.Forms.TextBox();
            this.highScoreTextBox = new System.Windows.Forms.TextBox();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.highSection = new System.Windows.Forms.Label();
            this.lowestGroupBox = new System.Windows.Forms.GroupBox();
            this.lowSectionLabel = new System.Windows.Forms.Label();
            this.lowSectionTextBox = new System.Windows.Forms.TextBox();
            this.lowScoreTextBox = new System.Windows.Forms.TextBox();
            this.lowScoreLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultsGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.highestGroupBox.SuspendLayout();
            this.lowestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // section1ListBox
            // 
            this.section1ListBox.FormattingEnabled = true;
            this.section1ListBox.ItemHeight = 16;
            this.section1ListBox.Location = new System.Drawing.Point(3, 3);
            this.section1ListBox.Name = "section1ListBox";
            this.section1ListBox.Size = new System.Drawing.Size(102, 244);
            this.section1ListBox.TabIndex = 0;
            // 
            // section3ListBox
            // 
            this.section3ListBox.FormattingEnabled = true;
            this.section3ListBox.ItemHeight = 16;
            this.section3ListBox.Location = new System.Drawing.Point(219, 3);
            this.section3ListBox.Name = "section3ListBox";
            this.section3ListBox.Size = new System.Drawing.Size(102, 244);
            this.section3ListBox.TabIndex = 1;
            // 
            // section2ListBox
            // 
            this.section2ListBox.FormattingEnabled = true;
            this.section2ListBox.ItemHeight = 16;
            this.section2ListBox.Location = new System.Drawing.Point(111, 3);
            this.section2ListBox.Name = "section2ListBox";
            this.section2ListBox.Size = new System.Drawing.Size(102, 244);
            this.section2ListBox.TabIndex = 2;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.lowestGroupBox);
            this.resultsGroupBox.Controls.Add(this.highestGroupBox);
            this.resultsGroupBox.Controls.Add(this.generalAverageTextBox);
            this.resultsGroupBox.Controls.Add(this.averageLabel);
            this.resultsGroupBox.Controls.Add(this.section3AverageTextBox);
            this.resultsGroupBox.Controls.Add(this.section3AverageLabel);
            this.resultsGroupBox.Controls.Add(this.section2AverageTextBox);
            this.resultsGroupBox.Controls.Add(this.section2AverageLabel);
            this.resultsGroupBox.Controls.Add(this.section1AverageTextBox);
            this.resultsGroupBox.Controls.Add(this.section1AveragaeLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(21, 279);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(557, 201);
            this.resultsGroupBox.TabIndex = 3;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.section3ListBox);
            this.panel1.Controls.Add(this.section1ListBox);
            this.panel1.Controls.Add(this.section2ListBox);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 250);
            this.panel1.TabIndex = 4;
            // 
            // section1AveragaeLabel
            // 
            this.section1AveragaeLabel.AutoSize = true;
            this.section1AveragaeLabel.Location = new System.Drawing.Point(11, 35);
            this.section1AveragaeLabel.Name = "section1AveragaeLabel";
            this.section1AveragaeLabel.Size = new System.Drawing.Size(128, 17);
            this.section1AveragaeLabel.TabIndex = 0;
            this.section1AveragaeLabel.Text = "Section 1 Average:";
            // 
            // section1AverageTextBox
            // 
            this.section1AverageTextBox.Location = new System.Drawing.Point(148, 32);
            this.section1AverageTextBox.Name = "section1AverageTextBox";
            this.section1AverageTextBox.ReadOnly = true;
            this.section1AverageTextBox.Size = new System.Drawing.Size(100, 22);
            this.section1AverageTextBox.TabIndex = 1;
            // 
            // section2AverageLabel
            // 
            this.section2AverageLabel.AutoSize = true;
            this.section2AverageLabel.Location = new System.Drawing.Point(11, 67);
            this.section2AverageLabel.Name = "section2AverageLabel";
            this.section2AverageLabel.Size = new System.Drawing.Size(128, 17);
            this.section2AverageLabel.TabIndex = 2;
            this.section2AverageLabel.Text = "Section 2 Average:";
            // 
            // section2AverageTextBox
            // 
            this.section2AverageTextBox.Location = new System.Drawing.Point(148, 64);
            this.section2AverageTextBox.Name = "section2AverageTextBox";
            this.section2AverageTextBox.ReadOnly = true;
            this.section2AverageTextBox.Size = new System.Drawing.Size(100, 22);
            this.section2AverageTextBox.TabIndex = 3;
            // 
            // section3AverageTextBox
            // 
            this.section3AverageTextBox.Location = new System.Drawing.Point(148, 92);
            this.section3AverageTextBox.Name = "section3AverageTextBox";
            this.section3AverageTextBox.ReadOnly = true;
            this.section3AverageTextBox.Size = new System.Drawing.Size(100, 22);
            this.section3AverageTextBox.TabIndex = 5;
            // 
            // section3AverageLabel
            // 
            this.section3AverageLabel.AutoSize = true;
            this.section3AverageLabel.Location = new System.Drawing.Point(11, 95);
            this.section3AverageLabel.Name = "section3AverageLabel";
            this.section3AverageLabel.Size = new System.Drawing.Size(128, 17);
            this.section3AverageLabel.TabIndex = 4;
            this.section3AverageLabel.Text = "Section 3 Average:";
            // 
            // generalAverageTextBox
            // 
            this.generalAverageTextBox.Location = new System.Drawing.Point(148, 121);
            this.generalAverageTextBox.Name = "generalAverageTextBox";
            this.generalAverageTextBox.ReadOnly = true;
            this.generalAverageTextBox.Size = new System.Drawing.Size(100, 22);
            this.generalAverageTextBox.TabIndex = 7;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(19, 124);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(120, 17);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.Text = "General Average:";
            // 
            // highestGroupBox
            // 
            this.highestGroupBox.Controls.Add(this.highSection);
            this.highestGroupBox.Controls.Add(this.highSectionTextBox);
            this.highestGroupBox.Controls.Add(this.highScoreTextBox);
            this.highestGroupBox.Controls.Add(this.highScoreLabel);
            this.highestGroupBox.Location = new System.Drawing.Point(292, 14);
            this.highestGroupBox.Name = "highestGroupBox";
            this.highestGroupBox.Size = new System.Drawing.Size(253, 84);
            this.highestGroupBox.TabIndex = 5;
            this.highestGroupBox.TabStop = false;
            this.highestGroupBox.Text = "High Score";
            // 
            // highSectionTextBox
            // 
            this.highSectionTextBox.Location = new System.Drawing.Point(71, 54);
            this.highSectionTextBox.Name = "highSectionTextBox";
            this.highSectionTextBox.ReadOnly = true;
            this.highSectionTextBox.Size = new System.Drawing.Size(100, 22);
            this.highSectionTextBox.TabIndex = 9;
            // 
            // highScoreTextBox
            // 
            this.highScoreTextBox.Location = new System.Drawing.Point(71, 18);
            this.highScoreTextBox.Name = "highScoreTextBox";
            this.highScoreTextBox.ReadOnly = true;
            this.highScoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.highScoreTextBox.TabIndex = 7;
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Location = new System.Drawing.Point(16, 23);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(49, 17);
            this.highScoreLabel.TabIndex = 6;
            this.highScoreLabel.Text = "Score:";
            // 
            // highSection
            // 
            this.highSection.AutoSize = true;
            this.highSection.Location = new System.Drawing.Point(6, 57);
            this.highSection.Name = "highSection";
            this.highSection.Size = new System.Drawing.Size(59, 17);
            this.highSection.TabIndex = 10;
            this.highSection.Text = "Section:";
            // 
            // lowestGroupBox
            // 
            this.lowestGroupBox.Controls.Add(this.lowSectionLabel);
            this.lowestGroupBox.Controls.Add(this.lowSectionTextBox);
            this.lowestGroupBox.Controls.Add(this.lowScoreTextBox);
            this.lowestGroupBox.Controls.Add(this.lowScoreLabel);
            this.lowestGroupBox.Location = new System.Drawing.Point(292, 104);
            this.lowestGroupBox.Name = "lowestGroupBox";
            this.lowestGroupBox.Size = new System.Drawing.Size(253, 84);
            this.lowestGroupBox.TabIndex = 11;
            this.lowestGroupBox.TabStop = false;
            this.lowestGroupBox.Text = "High Score";
            // 
            // lowSectionLabel
            // 
            this.lowSectionLabel.AutoSize = true;
            this.lowSectionLabel.Location = new System.Drawing.Point(6, 57);
            this.lowSectionLabel.Name = "lowSectionLabel";
            this.lowSectionLabel.Size = new System.Drawing.Size(59, 17);
            this.lowSectionLabel.TabIndex = 10;
            this.lowSectionLabel.Text = "Section:";
            // 
            // lowSectionTextBox
            // 
            this.lowSectionTextBox.Location = new System.Drawing.Point(71, 54);
            this.lowSectionTextBox.Name = "lowSectionTextBox";
            this.lowSectionTextBox.ReadOnly = true;
            this.lowSectionTextBox.Size = new System.Drawing.Size(100, 22);
            this.lowSectionTextBox.TabIndex = 9;
            // 
            // lowScoreTextBox
            // 
            this.lowScoreTextBox.Location = new System.Drawing.Point(71, 18);
            this.lowScoreTextBox.Name = "lowScoreTextBox";
            this.lowScoreTextBox.ReadOnly = true;
            this.lowScoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.lowScoreTextBox.TabIndex = 7;
            // 
            // lowScoreLabel
            // 
            this.lowScoreLabel.AutoSize = true;
            this.lowScoreLabel.Location = new System.Drawing.Point(16, 23);
            this.lowScoreLabel.Name = "lowScoreLabel";
            this.lowScoreLabel.Size = new System.Drawing.Size(49, 17);
            this.lowScoreLabel.TabIndex = 6;
            this.lowScoreLabel.Text = "Score:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(503, 496);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(21, 487);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 534);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.highestGroupBox.ResumeLayout(false);
            this.highestGroupBox.PerformLayout();
            this.lowestGroupBox.ResumeLayout(false);
            this.lowestGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox section1ListBox;
        private System.Windows.Forms.ListBox section3ListBox;
        private System.Windows.Forms.ListBox section2ListBox;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.GroupBox lowestGroupBox;
        private System.Windows.Forms.Label lowSectionLabel;
        private System.Windows.Forms.TextBox lowSectionTextBox;
        private System.Windows.Forms.TextBox lowScoreTextBox;
        private System.Windows.Forms.Label lowScoreLabel;
        private System.Windows.Forms.GroupBox highestGroupBox;
        private System.Windows.Forms.Label highSection;
        private System.Windows.Forms.TextBox highSectionTextBox;
        private System.Windows.Forms.TextBox highScoreTextBox;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.TextBox generalAverageTextBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.TextBox section3AverageTextBox;
        private System.Windows.Forms.Label section3AverageLabel;
        private System.Windows.Forms.TextBox section2AverageTextBox;
        private System.Windows.Forms.Label section2AverageLabel;
        private System.Windows.Forms.TextBox section1AverageTextBox;
        private System.Windows.Forms.Label section1AveragaeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
    }
}

