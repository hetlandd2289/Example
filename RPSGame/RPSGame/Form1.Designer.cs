namespace RPSGame
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
            this.rockPictureBox = new System.Windows.Forms.PictureBox();
            this.paperPictureBox = new System.Windows.Forms.PictureBox();
            this.scissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.playerHandGroupBox = new System.Windows.Forms.GroupBox();
            this.aiHandGroupBox = new System.Windows.Forms.GroupBox();
            this.aiRockPictureBox = new System.Windows.Forms.PictureBox();
            this.aiPaperPictureBox = new System.Windows.Forms.PictureBox();
            this.aiScissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.winsLabel = new System.Windows.Forms.Label();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.drawLabel = new System.Windows.Forms.Label();
            this.winsTextBox = new System.Windows.Forms.TextBox();
            this.drawsTextBox = new System.Windows.Forms.TextBox();
            this.lossesTextBox = new System.Windows.Forms.TextBox();
            this.playAgainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).BeginInit();
            this.playerHandGroupBox.SuspendLayout();
            this.aiHandGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aiRockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiPaperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiScissorsPictureBox)).BeginInit();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(410, 480);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rockPictureBox
            // 
            this.rockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rockPictureBox.Image")));
            this.rockPictureBox.Location = new System.Drawing.Point(6, 19);
            this.rockPictureBox.Name = "rockPictureBox";
            this.rockPictureBox.Size = new System.Drawing.Size(148, 143);
            this.rockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rockPictureBox.TabIndex = 2;
            this.rockPictureBox.TabStop = false;
            this.rockPictureBox.Click += new System.EventHandler(this.rockPictureBox_Click);
            // 
            // paperPictureBox
            // 
            this.paperPictureBox.BackColor = System.Drawing.Color.White;
            this.paperPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("paperPictureBox.Image")));
            this.paperPictureBox.Location = new System.Drawing.Point(160, 19);
            this.paperPictureBox.Name = "paperPictureBox";
            this.paperPictureBox.Size = new System.Drawing.Size(148, 143);
            this.paperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paperPictureBox.TabIndex = 3;
            this.paperPictureBox.TabStop = false;
            this.paperPictureBox.Click += new System.EventHandler(this.paperPictureBox_Click);
            // 
            // scissorsPictureBox
            // 
            this.scissorsPictureBox.BackColor = System.Drawing.Color.White;
            this.scissorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("scissorsPictureBox.Image")));
            this.scissorsPictureBox.Location = new System.Drawing.Point(314, 19);
            this.scissorsPictureBox.Name = "scissorsPictureBox";
            this.scissorsPictureBox.Size = new System.Drawing.Size(148, 143);
            this.scissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissorsPictureBox.TabIndex = 4;
            this.scissorsPictureBox.TabStop = false;
            this.scissorsPictureBox.Click += new System.EventHandler(this.scissorsPictureBox_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(9, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(168, 13);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.Text = "Select the option you want to use.";
            // 
            // playerHandGroupBox
            // 
            this.playerHandGroupBox.Controls.Add(this.rockPictureBox);
            this.playerHandGroupBox.Controls.Add(this.paperPictureBox);
            this.playerHandGroupBox.Controls.Add(this.scissorsPictureBox);
            this.playerHandGroupBox.Location = new System.Drawing.Point(12, 37);
            this.playerHandGroupBox.Name = "playerHandGroupBox";
            this.playerHandGroupBox.Size = new System.Drawing.Size(473, 183);
            this.playerHandGroupBox.TabIndex = 0;
            this.playerHandGroupBox.TabStop = false;
            this.playerHandGroupBox.Text = "Your Hand";
            // 
            // aiHandGroupBox
            // 
            this.aiHandGroupBox.Controls.Add(this.aiRockPictureBox);
            this.aiHandGroupBox.Controls.Add(this.aiPaperPictureBox);
            this.aiHandGroupBox.Controls.Add(this.aiScissorsPictureBox);
            this.aiHandGroupBox.Location = new System.Drawing.Point(12, 226);
            this.aiHandGroupBox.Name = "aiHandGroupBox";
            this.aiHandGroupBox.Size = new System.Drawing.Size(473, 183);
            this.aiHandGroupBox.TabIndex = 7;
            this.aiHandGroupBox.TabStop = false;
            this.aiHandGroupBox.Text = "Opponent Hand";
            // 
            // aiRockPictureBox
            // 
            this.aiRockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("aiRockPictureBox.Image")));
            this.aiRockPictureBox.Location = new System.Drawing.Point(6, 19);
            this.aiRockPictureBox.Name = "aiRockPictureBox";
            this.aiRockPictureBox.Size = new System.Drawing.Size(148, 143);
            this.aiRockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aiRockPictureBox.TabIndex = 2;
            this.aiRockPictureBox.TabStop = false;
            // 
            // aiPaperPictureBox
            // 
            this.aiPaperPictureBox.BackColor = System.Drawing.Color.White;
            this.aiPaperPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("aiPaperPictureBox.Image")));
            this.aiPaperPictureBox.Location = new System.Drawing.Point(160, 19);
            this.aiPaperPictureBox.Name = "aiPaperPictureBox";
            this.aiPaperPictureBox.Size = new System.Drawing.Size(148, 143);
            this.aiPaperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aiPaperPictureBox.TabIndex = 3;
            this.aiPaperPictureBox.TabStop = false;
            // 
            // aiScissorsPictureBox
            // 
            this.aiScissorsPictureBox.BackColor = System.Drawing.Color.White;
            this.aiScissorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("aiScissorsPictureBox.Image")));
            this.aiScissorsPictureBox.Location = new System.Drawing.Point(314, 19);
            this.aiScissorsPictureBox.Name = "aiScissorsPictureBox";
            this.aiScissorsPictureBox.Size = new System.Drawing.Size(148, 143);
            this.aiScissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aiScissorsPictureBox.TabIndex = 4;
            this.aiScissorsPictureBox.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.Color.Red;
            this.resetButton.Location = new System.Drawing.Point(410, 451);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.lossesTextBox);
            this.resultsGroupBox.Controls.Add(this.drawsTextBox);
            this.resultsGroupBox.Controls.Add(this.winsTextBox);
            this.resultsGroupBox.Controls.Add(this.drawLabel);
            this.resultsGroupBox.Controls.Add(this.lossesLabel);
            this.resultsGroupBox.Controls.Add(this.winsLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(12, 415);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(200, 106);
            this.resultsGroupBox.TabIndex = 9;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Location = new System.Drawing.Point(15, 21);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(37, 13);
            this.winsLabel.TabIndex = 0;
            this.winsLabel.Text = "Wins :";
            // 
            // lossesLabel
            // 
            this.lossesLabel.AutoSize = true;
            this.lossesLabel.Location = new System.Drawing.Point(6, 47);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(46, 13);
            this.lossesLabel.TabIndex = 1;
            this.lossesLabel.Text = "Losses :";
            // 
            // drawLabel
            // 
            this.drawLabel.AutoSize = true;
            this.drawLabel.Location = new System.Drawing.Point(14, 75);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(38, 13);
            this.drawLabel.TabIndex = 2;
            this.drawLabel.Text = "Draw :";
            // 
            // winsTextBox
            // 
            this.winsTextBox.Location = new System.Drawing.Point(88, 18);
            this.winsTextBox.Name = "winsTextBox";
            this.winsTextBox.ReadOnly = true;
            this.winsTextBox.Size = new System.Drawing.Size(39, 20);
            this.winsTextBox.TabIndex = 3;
            this.winsTextBox.Text = "0";
            // 
            // drawsTextBox
            // 
            this.drawsTextBox.Location = new System.Drawing.Point(88, 72);
            this.drawsTextBox.Name = "drawsTextBox";
            this.drawsTextBox.ReadOnly = true;
            this.drawsTextBox.Size = new System.Drawing.Size(39, 20);
            this.drawsTextBox.TabIndex = 4;
            this.drawsTextBox.Text = "0";
            // 
            // lossesTextBox
            // 
            this.lossesTextBox.Location = new System.Drawing.Point(88, 44);
            this.lossesTextBox.Name = "lossesTextBox";
            this.lossesTextBox.ReadOnly = true;
            this.lossesTextBox.Size = new System.Drawing.Size(39, 20);
            this.lossesTextBox.TabIndex = 5;
            this.lossesTextBox.Text = "0";
            // 
            // playAgainButton
            // 
            this.playAgainButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.playAgainButton.Location = new System.Drawing.Point(253, 451);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(113, 52);
            this.playAgainButton.TabIndex = 1;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 535);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.aiHandGroupBox);
            this.Controls.Add(this.playerHandGroupBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Rock-Paper-Scissors Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).EndInit();
            this.playerHandGroupBox.ResumeLayout(false);
            this.aiHandGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aiRockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiPaperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiScissorsPictureBox)).EndInit();
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox rockPictureBox;
        private System.Windows.Forms.PictureBox paperPictureBox;
        private System.Windows.Forms.PictureBox scissorsPictureBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.GroupBox playerHandGroupBox;
        private System.Windows.Forms.GroupBox aiHandGroupBox;
        private System.Windows.Forms.PictureBox aiRockPictureBox;
        private System.Windows.Forms.PictureBox aiPaperPictureBox;
        private System.Windows.Forms.PictureBox aiScissorsPictureBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox lossesTextBox;
        private System.Windows.Forms.TextBox drawsTextBox;
        private System.Windows.Forms.TextBox winsTextBox;
        private System.Windows.Forms.Label drawLabel;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Button playAgainButton;
    }
}

