namespace RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.rockPictureBox = new System.Windows.Forms.PictureBox();
            this.scissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.paperPictureBox = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.playerHandGroupBox = new System.Windows.Forms.GroupBox();
            this.computerHandGroupBox = new System.Windows.Forms.GroupBox();
            this.oppScissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.oppRockPictureBox = new System.Windows.Forms.PictureBox();
            this.oppPaperPictureBox = new System.Windows.Forms.PictureBox();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.winsLabel = new System.Windows.Forms.Label();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.drawLabel = new System.Windows.Forms.Label();
            this.winsTextBox = new System.Windows.Forms.TextBox();
            this.lossesTextBox = new System.Windows.Forms.TextBox();
            this.drawsTextBox = new System.Windows.Forms.TextBox();
            this.nextRoundButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).BeginInit();
            this.playerHandGroupBox.SuspendLayout();
            this.computerHandGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oppScissorsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppRockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppPaperPictureBox)).BeginInit();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(505, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.Color.Red;
            this.resetButton.Location = new System.Drawing.Point(424, 415);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // rockPictureBox
            // 
            this.rockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rockPictureBox.Image")));
            this.rockPictureBox.Location = new System.Drawing.Point(10, 19);
            this.rockPictureBox.Name = "rockPictureBox";
            this.rockPictureBox.Size = new System.Drawing.Size(166, 130);
            this.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rockPictureBox.TabIndex = 2;
            this.rockPictureBox.TabStop = false;
            this.rockPictureBox.Click += new System.EventHandler(this.rockPictureBox_Click);
            // 
            // scissorsPictureBox
            // 
            this.scissorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("scissorsPictureBox.Image")));
            this.scissorsPictureBox.Location = new System.Drawing.Point(377, 19);
            this.scissorsPictureBox.Name = "scissorsPictureBox";
            this.scissorsPictureBox.Size = new System.Drawing.Size(166, 130);
            this.scissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissorsPictureBox.TabIndex = 3;
            this.scissorsPictureBox.TabStop = false;
            this.scissorsPictureBox.Click += new System.EventHandler(this.scissorsPictureBox_Click);
            // 
            // paperPictureBox
            // 
            this.paperPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("paperPictureBox.Image")));
            this.paperPictureBox.Location = new System.Drawing.Point(193, 19);
            this.paperPictureBox.Name = "paperPictureBox";
            this.paperPictureBox.Size = new System.Drawing.Size(166, 130);
            this.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paperPictureBox.TabIndex = 4;
            this.paperPictureBox.TabStop = false;
            this.paperPictureBox.Click += new System.EventHandler(this.paperPictureBox_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(28, 20);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(168, 13);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.Text = "Select the option you want to use.";
            // 
            // playerHandGroupBox
            // 
            this.playerHandGroupBox.Controls.Add(this.scissorsPictureBox);
            this.playerHandGroupBox.Controls.Add(this.rockPictureBox);
            this.playerHandGroupBox.Controls.Add(this.paperPictureBox);
            this.playerHandGroupBox.Location = new System.Drawing.Point(31, 56);
            this.playerHandGroupBox.Name = "playerHandGroupBox";
            this.playerHandGroupBox.Size = new System.Drawing.Size(549, 174);
            this.playerHandGroupBox.TabIndex = 6;
            this.playerHandGroupBox.TabStop = false;
            this.playerHandGroupBox.Text = "Your Hand";
            // 
            // computerHandGroupBox
            // 
            this.computerHandGroupBox.Controls.Add(this.oppScissorsPictureBox);
            this.computerHandGroupBox.Controls.Add(this.oppRockPictureBox);
            this.computerHandGroupBox.Controls.Add(this.oppPaperPictureBox);
            this.computerHandGroupBox.Location = new System.Drawing.Point(31, 235);
            this.computerHandGroupBox.Name = "computerHandGroupBox";
            this.computerHandGroupBox.Size = new System.Drawing.Size(549, 174);
            this.computerHandGroupBox.TabIndex = 7;
            this.computerHandGroupBox.TabStop = false;
            this.computerHandGroupBox.Text = "Computer Hand";
            // 
            // oppScissorsPictureBox
            // 
            this.oppScissorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("oppScissorsPictureBox.Image")));
            this.oppScissorsPictureBox.Location = new System.Drawing.Point(377, 19);
            this.oppScissorsPictureBox.Name = "oppScissorsPictureBox";
            this.oppScissorsPictureBox.Size = new System.Drawing.Size(166, 130);
            this.oppScissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oppScissorsPictureBox.TabIndex = 3;
            this.oppScissorsPictureBox.TabStop = false;
            this.oppScissorsPictureBox.Visible = false;
            // 
            // oppRockPictureBox
            // 
            this.oppRockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("oppRockPictureBox.Image")));
            this.oppRockPictureBox.Location = new System.Drawing.Point(10, 19);
            this.oppRockPictureBox.Name = "oppRockPictureBox";
            this.oppRockPictureBox.Size = new System.Drawing.Size(166, 130);
            this.oppRockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oppRockPictureBox.TabIndex = 2;
            this.oppRockPictureBox.TabStop = false;
            this.oppRockPictureBox.Visible = false;
            // 
            // oppPaperPictureBox
            // 
            this.oppPaperPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("oppPaperPictureBox.Image")));
            this.oppPaperPictureBox.Location = new System.Drawing.Point(193, 19);
            this.oppPaperPictureBox.Name = "oppPaperPictureBox";
            this.oppPaperPictureBox.Size = new System.Drawing.Size(166, 130);
            this.oppPaperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oppPaperPictureBox.TabIndex = 4;
            this.oppPaperPictureBox.TabStop = false;
            this.oppPaperPictureBox.Visible = false;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.drawsTextBox);
            this.resultsGroupBox.Controls.Add(this.lossesTextBox);
            this.resultsGroupBox.Controls.Add(this.winsTextBox);
            this.resultsGroupBox.Controls.Add(this.drawLabel);
            this.resultsGroupBox.Controls.Add(this.lossesLabel);
            this.resultsGroupBox.Controls.Add(this.winsLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(31, 415);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(200, 106);
            this.resultsGroupBox.TabIndex = 8;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Location = new System.Drawing.Point(18, 27);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(34, 13);
            this.winsLabel.TabIndex = 0;
            this.winsLabel.Text = "Wins:";
            // 
            // lossesLabel
            // 
            this.lossesLabel.AutoSize = true;
            this.lossesLabel.Location = new System.Drawing.Point(9, 52);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(43, 13);
            this.lossesLabel.TabIndex = 1;
            this.lossesLabel.Text = "Losses:";
            // 
            // drawLabel
            // 
            this.drawLabel.AutoSize = true;
            this.drawLabel.Location = new System.Drawing.Point(12, 78);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(40, 13);
            this.drawLabel.TabIndex = 2;
            this.drawLabel.Text = "Draws:";
            // 
            // winsTextBox
            // 
            this.winsTextBox.Location = new System.Drawing.Point(94, 24);
            this.winsTextBox.Name = "winsTextBox";
            this.winsTextBox.ReadOnly = true;
            this.winsTextBox.Size = new System.Drawing.Size(31, 20);
            this.winsTextBox.TabIndex = 3;
            this.winsTextBox.Text = "0";
            // 
            // lossesTextBox
            // 
            this.lossesTextBox.Location = new System.Drawing.Point(94, 49);
            this.lossesTextBox.Name = "lossesTextBox";
            this.lossesTextBox.ReadOnly = true;
            this.lossesTextBox.Size = new System.Drawing.Size(31, 20);
            this.lossesTextBox.TabIndex = 4;
            this.lossesTextBox.Text = "0";
            // 
            // drawsTextBox
            // 
            this.drawsTextBox.Location = new System.Drawing.Point(94, 75);
            this.drawsTextBox.Name = "drawsTextBox";
            this.drawsTextBox.ReadOnly = true;
            this.drawsTextBox.Size = new System.Drawing.Size(31, 20);
            this.drawsTextBox.TabIndex = 5;
            this.drawsTextBox.Text = "0";
            // 
            // nextRoundButton
            // 
            this.nextRoundButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nextRoundButton.Location = new System.Drawing.Point(343, 415);
            this.nextRoundButton.Name = "nextRoundButton";
            this.nextRoundButton.Size = new System.Drawing.Size(75, 23);
            this.nextRoundButton.TabIndex = 9;
            this.nextRoundButton.Text = "Play Again";
            this.nextRoundButton.UseVisualStyleBackColor = true;
            this.nextRoundButton.Click += new System.EventHandler(this.nextRoundButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 541);
            this.Controls.Add(this.nextRoundButton);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.computerHandGroupBox);
            this.Controls.Add(this.playerHandGroupBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Rock-Paper-Scissors Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).EndInit();
            this.playerHandGroupBox.ResumeLayout(false);
            this.computerHandGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oppScissorsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppRockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oppPaperPictureBox)).EndInit();
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox rockPictureBox;
        private System.Windows.Forms.PictureBox scissorsPictureBox;
        private System.Windows.Forms.PictureBox paperPictureBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.GroupBox playerHandGroupBox;
        private System.Windows.Forms.GroupBox computerHandGroupBox;
        private System.Windows.Forms.PictureBox oppScissorsPictureBox;
        private System.Windows.Forms.PictureBox oppRockPictureBox;
        private System.Windows.Forms.PictureBox oppPaperPictureBox;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox drawsTextBox;
        private System.Windows.Forms.TextBox lossesTextBox;
        private System.Windows.Forms.TextBox winsTextBox;
        private System.Windows.Forms.Label drawLabel;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Button nextRoundButton;
    }
}

