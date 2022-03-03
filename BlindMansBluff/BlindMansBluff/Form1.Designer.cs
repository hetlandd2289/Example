namespace GuessingGame
{
    partial class BlindMansBluff
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlindMansBluff));
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.bidLabel = new System.Windows.Forms.Label();
            this.moneyAmount = new System.Windows.Forms.TextBox();
            this.bidTextBox = new System.Windows.Forms.TextBox();
            this.totalBidLabel = new System.Windows.Forms.Label();
            this.die2PictureBox = new System.Windows.Forms.PictureBox();
            this.dieFaces = new System.Windows.Forms.ImageList(this.components);
            this.die1PictureBox = new System.Windows.Forms.PictureBox();
            this.totalRollLabel = new System.Windows.Forms.Label();
            this.playerGroupBox = new System.Windows.Forms.GroupBox();
            this.playerRollTotalTextBox = new System.Windows.Forms.TextBox();
            this.aiGroupBox = new System.Windows.Forms.GroupBox();
            this.aiBidTextBox = new System.Windows.Forms.TextBox();
            this.aiBidLabel = new System.Windows.Forms.Label();
            this.aiRollTotalTextBox = new System.Windows.Forms.TextBox();
            this.aiMoneyTextBox = new System.Windows.Forms.TextBox();
            this.die3PictureBox = new System.Windows.Forms.PictureBox();
            this.aiMoneyLabel = new System.Windows.Forms.Label();
            this.aiRollTotalLabel = new System.Windows.Forms.Label();
            this.die4PictureBox = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.bidButton = new System.Windows.Forms.Button();
            this.totalBidsTextBox = new System.Windows.Forms.TextBox();
            this.callButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.die2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1PictureBox)).BeginInit();
            this.playerGroupBox.SuspendLayout();
            this.aiGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.die3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die4PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(530, 267);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(367, 13);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Enter a value to bid if you believe your roll to be higher than your opponent\'s.";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(83, 141);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(42, 13);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "Money:";
            // 
            // bidLabel
            // 
            this.bidLabel.AutoSize = true;
            this.bidLabel.Location = new System.Drawing.Point(62, 193);
            this.bidLabel.Name = "bidLabel";
            this.bidLabel.Size = new System.Drawing.Size(63, 13);
            this.bidLabel.TabIndex = 3;
            this.bidLabel.Text = "Bid amount:";
            // 
            // moneyAmount
            // 
            this.moneyAmount.Location = new System.Drawing.Point(157, 138);
            this.moneyAmount.Name = "moneyAmount";
            this.moneyAmount.ReadOnly = true;
            this.moneyAmount.Size = new System.Drawing.Size(100, 20);
            this.moneyAmount.TabIndex = 4;
            this.moneyAmount.Text = "25";
            // 
            // bidTextBox
            // 
            this.bidTextBox.Location = new System.Drawing.Point(157, 190);
            this.bidTextBox.Name = "bidTextBox";
            this.bidTextBox.Size = new System.Drawing.Size(100, 20);
            this.bidTextBox.TabIndex = 5;
            this.bidTextBox.Text = "1";
            // 
            // totalBidLabel
            // 
            this.totalBidLabel.AutoSize = true;
            this.totalBidLabel.Location = new System.Drawing.Point(323, 272);
            this.totalBidLabel.Name = "totalBidLabel";
            this.totalBidLabel.Size = new System.Drawing.Size(60, 13);
            this.totalBidLabel.TabIndex = 6;
            this.totalBidLabel.Text = "Total Bids: ";
            // 
            // die2PictureBox
            // 
            this.die2PictureBox.Location = new System.Drawing.Point(157, 19);
            this.die2PictureBox.Name = "die2PictureBox";
            this.die2PictureBox.Size = new System.Drawing.Size(119, 113);
            this.die2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die2PictureBox.TabIndex = 7;
            this.die2PictureBox.TabStop = false;
            // 
            // dieFaces
            // 
            this.dieFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dieFaces.ImageStream")));
            this.dieFaces.TransparentColor = System.Drawing.Color.Transparent;
            this.dieFaces.Images.SetKeyName(0, "1.png");
            this.dieFaces.Images.SetKeyName(1, "2.png");
            this.dieFaces.Images.SetKeyName(2, "3.png");
            this.dieFaces.Images.SetKeyName(3, "4.png");
            this.dieFaces.Images.SetKeyName(4, "5.png");
            this.dieFaces.Images.SetKeyName(5, "6.png");
            // 
            // die1PictureBox
            // 
            this.die1PictureBox.Location = new System.Drawing.Point(6, 19);
            this.die1PictureBox.Name = "die1PictureBox";
            this.die1PictureBox.Size = new System.Drawing.Size(119, 113);
            this.die1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die1PictureBox.TabIndex = 8;
            this.die1PictureBox.TabStop = false;
            // 
            // totalRollLabel
            // 
            this.totalRollLabel.AutoSize = true;
            this.totalRollLabel.Location = new System.Drawing.Point(70, 167);
            this.totalRollLabel.Name = "totalRollLabel";
            this.totalRollLabel.Size = new System.Drawing.Size(55, 13);
            this.totalRollLabel.TabIndex = 9;
            this.totalRollLabel.Text = "Roll Total:";
            // 
            // playerGroupBox
            // 
            this.playerGroupBox.Controls.Add(this.playerRollTotalTextBox);
            this.playerGroupBox.Controls.Add(this.die1PictureBox);
            this.playerGroupBox.Controls.Add(this.totalRollLabel);
            this.playerGroupBox.Controls.Add(this.die2PictureBox);
            this.playerGroupBox.Controls.Add(this.moneyLabel);
            this.playerGroupBox.Controls.Add(this.moneyAmount);
            this.playerGroupBox.Controls.Add(this.bidTextBox);
            this.playerGroupBox.Controls.Add(this.bidLabel);
            this.playerGroupBox.Location = new System.Drawing.Point(12, 37);
            this.playerGroupBox.Name = "playerGroupBox";
            this.playerGroupBox.Size = new System.Drawing.Size(282, 224);
            this.playerGroupBox.TabIndex = 10;
            this.playerGroupBox.TabStop = false;
            this.playerGroupBox.Text = "You";
            // 
            // playerRollTotalTextBox
            // 
            this.playerRollTotalTextBox.Location = new System.Drawing.Point(157, 164);
            this.playerRollTotalTextBox.Name = "playerRollTotalTextBox";
            this.playerRollTotalTextBox.ReadOnly = true;
            this.playerRollTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerRollTotalTextBox.TabIndex = 10;
            this.playerRollTotalTextBox.Text = "0";
            // 
            // aiGroupBox
            // 
            this.aiGroupBox.Controls.Add(this.aiBidTextBox);
            this.aiGroupBox.Controls.Add(this.aiBidLabel);
            this.aiGroupBox.Controls.Add(this.aiRollTotalTextBox);
            this.aiGroupBox.Controls.Add(this.aiMoneyTextBox);
            this.aiGroupBox.Controls.Add(this.die3PictureBox);
            this.aiGroupBox.Controls.Add(this.aiMoneyLabel);
            this.aiGroupBox.Controls.Add(this.aiRollTotalLabel);
            this.aiGroupBox.Controls.Add(this.die4PictureBox);
            this.aiGroupBox.Location = new System.Drawing.Point(323, 37);
            this.aiGroupBox.Name = "aiGroupBox";
            this.aiGroupBox.Size = new System.Drawing.Size(282, 224);
            this.aiGroupBox.TabIndex = 11;
            this.aiGroupBox.TabStop = false;
            this.aiGroupBox.Text = "Opponent";
            // 
            // aiBidTextBox
            // 
            this.aiBidTextBox.Location = new System.Drawing.Point(157, 190);
            this.aiBidTextBox.Name = "aiBidTextBox";
            this.aiBidTextBox.ReadOnly = true;
            this.aiBidTextBox.Size = new System.Drawing.Size(100, 20);
            this.aiBidTextBox.TabIndex = 19;
            this.aiBidTextBox.Text = "0";
            // 
            // aiBidLabel
            // 
            this.aiBidLabel.AutoSize = true;
            this.aiBidLabel.Location = new System.Drawing.Point(63, 193);
            this.aiBidLabel.Name = "aiBidLabel";
            this.aiBidLabel.Size = new System.Drawing.Size(63, 13);
            this.aiBidLabel.TabIndex = 18;
            this.aiBidLabel.Text = "Bid amount:";
            // 
            // aiRollTotalTextBox
            // 
            this.aiRollTotalTextBox.Location = new System.Drawing.Point(157, 164);
            this.aiRollTotalTextBox.Name = "aiRollTotalTextBox";
            this.aiRollTotalTextBox.ReadOnly = true;
            this.aiRollTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.aiRollTotalTextBox.TabIndex = 17;
            this.aiRollTotalTextBox.Text = "0";
            // 
            // aiMoneyTextBox
            // 
            this.aiMoneyTextBox.Location = new System.Drawing.Point(157, 138);
            this.aiMoneyTextBox.Name = "aiMoneyTextBox";
            this.aiMoneyTextBox.ReadOnly = true;
            this.aiMoneyTextBox.Size = new System.Drawing.Size(100, 20);
            this.aiMoneyTextBox.TabIndex = 16;
            this.aiMoneyTextBox.Text = "25";
            // 
            // die3PictureBox
            // 
            this.die3PictureBox.Location = new System.Drawing.Point(6, 19);
            this.die3PictureBox.Name = "die3PictureBox";
            this.die3PictureBox.Size = new System.Drawing.Size(119, 113);
            this.die3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die3PictureBox.TabIndex = 8;
            this.die3PictureBox.TabStop = false;
            // 
            // aiMoneyLabel
            // 
            this.aiMoneyLabel.AutoSize = true;
            this.aiMoneyLabel.Location = new System.Drawing.Point(34, 141);
            this.aiMoneyLabel.Name = "aiMoneyLabel";
            this.aiMoneyLabel.Size = new System.Drawing.Size(92, 13);
            this.aiMoneyLabel.TabIndex = 15;
            this.aiMoneyLabel.Text = "Opponent Money:";
            // 
            // aiRollTotalLabel
            // 
            this.aiRollTotalLabel.AutoSize = true;
            this.aiRollTotalLabel.Location = new System.Drawing.Point(71, 167);
            this.aiRollTotalLabel.Name = "aiRollTotalLabel";
            this.aiRollTotalLabel.Size = new System.Drawing.Size(55, 13);
            this.aiRollTotalLabel.TabIndex = 9;
            this.aiRollTotalLabel.Text = "Roll Total:";
            // 
            // die4PictureBox
            // 
            this.die4PictureBox.Location = new System.Drawing.Point(157, 19);
            this.die4PictureBox.Name = "die4PictureBox";
            this.die4PictureBox.Size = new System.Drawing.Size(119, 113);
            this.die4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die4PictureBox.TabIndex = 7;
            this.die4PictureBox.TabStop = false;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(12, 267);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 12;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // bidButton
            // 
            this.bidButton.Location = new System.Drawing.Point(116, 267);
            this.bidButton.Name = "bidButton";
            this.bidButton.Size = new System.Drawing.Size(75, 23);
            this.bidButton.TabIndex = 13;
            this.bidButton.Text = "Place Bid";
            this.bidButton.UseVisualStyleBackColor = true;
            this.bidButton.Click += new System.EventHandler(this.bidButton_Click);
            // 
            // totalBidsTextBox
            // 
            this.totalBidsTextBox.Location = new System.Drawing.Point(389, 269);
            this.totalBidsTextBox.Name = "totalBidsTextBox";
            this.totalBidsTextBox.ReadOnly = true;
            this.totalBidsTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalBidsTextBox.TabIndex = 14;
            this.totalBidsTextBox.Text = "0";
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(219, 267);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(75, 23);
            this.callButton.TabIndex = 17;
            this.callButton.Text = "Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // BlindMansBluff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 303);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.totalBidsTextBox);
            this.Controls.Add(this.bidButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.aiGroupBox);
            this.Controls.Add(this.playerGroupBox);
            this.Controls.Add(this.totalBidLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "BlindMansBluff";
            this.Text = "Blind Man\'s Bluff";
            this.Load += new System.EventHandler(this.BlindMansBluff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.die2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1PictureBox)).EndInit();
            this.playerGroupBox.ResumeLayout(false);
            this.playerGroupBox.PerformLayout();
            this.aiGroupBox.ResumeLayout(false);
            this.aiGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.die3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die4PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label bidLabel;
        private System.Windows.Forms.TextBox moneyAmount;
        private System.Windows.Forms.TextBox bidTextBox;
        private System.Windows.Forms.Label totalBidLabel;
        private System.Windows.Forms.PictureBox die2PictureBox;
        private System.Windows.Forms.ImageList dieFaces;
        private System.Windows.Forms.PictureBox die1PictureBox;
        private System.Windows.Forms.Label totalRollLabel;
        private System.Windows.Forms.GroupBox playerGroupBox;
        private System.Windows.Forms.GroupBox aiGroupBox;
        private System.Windows.Forms.PictureBox die3PictureBox;
        private System.Windows.Forms.Label aiRollTotalLabel;
        private System.Windows.Forms.PictureBox die4PictureBox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button bidButton;
        private System.Windows.Forms.TextBox totalBidsTextBox;
        private System.Windows.Forms.Label aiMoneyLabel;
        private System.Windows.Forms.TextBox aiMoneyTextBox;
        private System.Windows.Forms.TextBox playerRollTotalTextBox;
        private System.Windows.Forms.TextBox aiRollTotalTextBox;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.TextBox aiBidTextBox;
        private System.Windows.Forms.Label aiBidLabel;
    }
}

