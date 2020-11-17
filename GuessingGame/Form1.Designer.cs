namespace GuessingGame
{
    partial class blindMansBluff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blindMansBluff));
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.bidLabel = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.bidTextBox = new System.Windows.Forms.TextBox();
            this.totalBidLabel = new System.Windows.Forms.Label();
            this.die2PictureBox = new System.Windows.Forms.PictureBox();
            this.diceFaces = new System.Windows.Forms.ImageList(this.components);
            this.die1PictureBox = new System.Windows.Forms.PictureBox();
            this.totalRollLabel = new System.Windows.Forms.Label();
            this.playerGroupBox = new System.Windows.Forms.GroupBox();
            this.computerGroupBox = new System.Windows.Forms.GroupBox();
            this.aiDice4 = new System.Windows.Forms.PictureBox();
            this.aiRollTotal = new System.Windows.Forms.Label();
            this.aiDie3 = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.bidButton = new System.Windows.Forms.Button();
            this.totalBidsTextBox = new System.Windows.Forms.TextBox();
            this.oppMoneyLabel = new System.Windows.Forms.Label();
            this.opponentMoneyTextBox = new System.Windows.Forms.TextBox();
            this.playerRollTotalTextBox = new System.Windows.Forms.TextBox();
            this.opponentRollTotalTextBox = new System.Windows.Forms.TextBox();
            this.callButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.die2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1PictureBox)).BeginInit();
            this.playerGroupBox.SuspendLayout();
            this.computerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aiDice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiDie3)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(531, 378);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(41, 59);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(374, 13);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Enter a value to bid, if you believe your role to be higher than your opponent\'s." +
    "";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(44, 100);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(42, 13);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "Money:";
            // 
            // bidLabel
            // 
            this.bidLabel.AutoSize = true;
            this.bidLabel.Location = new System.Drawing.Point(23, 126);
            this.bidLabel.Name = "bidLabel";
            this.bidLabel.Size = new System.Drawing.Size(63, 13);
            this.bidLabel.TabIndex = 3;
            this.bidLabel.Text = "Bid amount:";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(92, 97);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.ReadOnly = true;
            this.moneyTextBox.Size = new System.Drawing.Size(100, 20);
            this.moneyTextBox.TabIndex = 4;
            this.moneyTextBox.Text = "25";
            // 
            // bidTextBox
            // 
            this.bidTextBox.Location = new System.Drawing.Point(92, 123);
            this.bidTextBox.Name = "bidTextBox";
            this.bidTextBox.Size = new System.Drawing.Size(100, 20);
            this.bidTextBox.TabIndex = 5;
            this.bidTextBox.Text = "1";
            // 
            // totalBidLabel
            // 
            this.totalBidLabel.AutoSize = true;
            this.totalBidLabel.Location = new System.Drawing.Point(360, 126);
            this.totalBidLabel.Name = "totalBidLabel";
            this.totalBidLabel.Size = new System.Drawing.Size(57, 13);
            this.totalBidLabel.TabIndex = 6;
            this.totalBidLabel.Text = "Total Bids:";
            // 
            // die2PictureBox
            // 
            this.die2PictureBox.Location = new System.Drawing.Point(7, 33);
            this.die2PictureBox.Name = "die2PictureBox";
            this.die2PictureBox.Size = new System.Drawing.Size(119, 113);
            this.die2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.die2PictureBox.TabIndex = 8;
            this.die2PictureBox.TabStop = false;
            // 
            // diceFaces
            // 
            this.diceFaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("diceFaces.ImageStream")));
            this.diceFaces.TransparentColor = System.Drawing.Color.Transparent;
            this.diceFaces.Images.SetKeyName(0, "dice6.png");
            this.diceFaces.Images.SetKeyName(1, "dice5.png");
            this.diceFaces.Images.SetKeyName(2, "dice4.png");
            this.diceFaces.Images.SetKeyName(3, "dice3.png");
            this.diceFaces.Images.SetKeyName(4, "dice2.png");
            this.diceFaces.Images.SetKeyName(5, "dice1.png");
            // 
            // die1PictureBox
            // 
            this.die1PictureBox.Location = new System.Drawing.Point(162, 33);
            this.die1PictureBox.Name = "die1PictureBox";
            this.die1PictureBox.Size = new System.Drawing.Size(119, 113);
            this.die1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.die1PictureBox.TabIndex = 9;
            this.die1PictureBox.TabStop = false;
            // 
            // totalRollLabel
            // 
            this.totalRollLabel.AutoSize = true;
            this.totalRollLabel.Location = new System.Drawing.Point(17, 155);
            this.totalRollLabel.Name = "totalRollLabel";
            this.totalRollLabel.Size = new System.Drawing.Size(58, 13);
            this.totalRollLabel.TabIndex = 10;
            this.totalRollLabel.Text = "Roll Total :";
            // 
            // playerGroupBox
            // 
            this.playerGroupBox.Controls.Add(this.playerRollTotalTextBox);
            this.playerGroupBox.Controls.Add(this.die1PictureBox);
            this.playerGroupBox.Controls.Add(this.totalRollLabel);
            this.playerGroupBox.Controls.Add(this.die2PictureBox);
            this.playerGroupBox.Location = new System.Drawing.Point(6, 181);
            this.playerGroupBox.Name = "playerGroupBox";
            this.playerGroupBox.Size = new System.Drawing.Size(289, 175);
            this.playerGroupBox.TabIndex = 12;
            this.playerGroupBox.TabStop = false;
            this.playerGroupBox.Text = "You";
            // 
            // computerGroupBox
            // 
            this.computerGroupBox.Controls.Add(this.opponentRollTotalTextBox);
            this.computerGroupBox.Controls.Add(this.aiDice4);
            this.computerGroupBox.Controls.Add(this.aiRollTotal);
            this.computerGroupBox.Controls.Add(this.aiDie3);
            this.computerGroupBox.Location = new System.Drawing.Point(317, 181);
            this.computerGroupBox.Name = "computerGroupBox";
            this.computerGroupBox.Size = new System.Drawing.Size(289, 175);
            this.computerGroupBox.TabIndex = 13;
            this.computerGroupBox.TabStop = false;
            this.computerGroupBox.Text = "Opponent";
            // 
            // aiDice4
            // 
            this.aiDice4.Location = new System.Drawing.Point(162, 33);
            this.aiDice4.Name = "aiDice4";
            this.aiDice4.Size = new System.Drawing.Size(119, 113);
            this.aiDice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aiDice4.TabIndex = 9;
            this.aiDice4.TabStop = false;
            // 
            // aiRollTotal
            // 
            this.aiRollTotal.AutoSize = true;
            this.aiRollTotal.Location = new System.Drawing.Point(4, 155);
            this.aiRollTotal.Name = "aiRollTotal";
            this.aiRollTotal.Size = new System.Drawing.Size(58, 13);
            this.aiRollTotal.TabIndex = 10;
            this.aiRollTotal.Text = "Roll Total :";
            // 
            // aiDie3
            // 
            this.aiDie3.Location = new System.Drawing.Point(7, 33);
            this.aiDie3.Name = "aiDie3";
            this.aiDie3.Size = new System.Drawing.Size(115, 113);
            this.aiDie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aiDie3.TabIndex = 8;
            this.aiDie3.TabStop = false;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(13, 378);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 14;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // bidButton
            // 
            this.bidButton.Location = new System.Drawing.Point(212, 121);
            this.bidButton.Name = "bidButton";
            this.bidButton.Size = new System.Drawing.Size(75, 23);
            this.bidButton.TabIndex = 15;
            this.bidButton.Text = "Place Bid";
            this.bidButton.UseVisualStyleBackColor = true;
            this.bidButton.Click += new System.EventHandler(this.bidButton_Click);
            // 
            // totalBidsTextBox
            // 
            this.totalBidsTextBox.Location = new System.Drawing.Point(423, 123);
            this.totalBidsTextBox.Name = "totalBidsTextBox";
            this.totalBidsTextBox.ReadOnly = true;
            this.totalBidsTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalBidsTextBox.TabIndex = 16;
            this.totalBidsTextBox.Text = "0";
            // 
            // oppMoneyLabel
            // 
            this.oppMoneyLabel.AutoSize = true;
            this.oppMoneyLabel.Location = new System.Drawing.Point(325, 100);
            this.oppMoneyLabel.Name = "oppMoneyLabel";
            this.oppMoneyLabel.Size = new System.Drawing.Size(92, 13);
            this.oppMoneyLabel.TabIndex = 17;
            this.oppMoneyLabel.Text = "Opponent Money:";
            // 
            // opponentMoneyTextBox
            // 
            this.opponentMoneyTextBox.Location = new System.Drawing.Point(423, 97);
            this.opponentMoneyTextBox.Name = "opponentMoneyTextBox";
            this.opponentMoneyTextBox.ReadOnly = true;
            this.opponentMoneyTextBox.Size = new System.Drawing.Size(100, 20);
            this.opponentMoneyTextBox.TabIndex = 18;
            this.opponentMoneyTextBox.Text = "25";
            // 
            // playerRollTotalTextBox
            // 
            this.playerRollTotalTextBox.Location = new System.Drawing.Point(86, 152);
            this.playerRollTotalTextBox.Name = "playerRollTotalTextBox";
            this.playerRollTotalTextBox.ReadOnly = true;
            this.playerRollTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerRollTotalTextBox.TabIndex = 11;
            // 
            // opponentRollTotalTextBox
            // 
            this.opponentRollTotalTextBox.Location = new System.Drawing.Point(68, 152);
            this.opponentRollTotalTextBox.Name = "opponentRollTotalTextBox";
            this.opponentRollTotalTextBox.ReadOnly = true;
            this.opponentRollTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.opponentRollTotalTextBox.TabIndex = 11;
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(259, 378);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(75, 23);
            this.callButton.TabIndex = 19;
            this.callButton.Text = "Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // blindMansBluff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.opponentMoneyTextBox);
            this.Controls.Add(this.oppMoneyLabel);
            this.Controls.Add(this.totalBidsTextBox);
            this.Controls.Add(this.bidButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.computerGroupBox);
            this.Controls.Add(this.playerGroupBox);
            this.Controls.Add(this.totalBidLabel);
            this.Controls.Add(this.bidTextBox);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.bidLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "blindMansBluff";
            this.Text = "Blind Man\'s Bluff";
            this.Load += new System.EventHandler(this.blindMansBluff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.die2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1PictureBox)).EndInit();
            this.playerGroupBox.ResumeLayout(false);
            this.playerGroupBox.PerformLayout();
            this.computerGroupBox.ResumeLayout(false);
            this.computerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aiDice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiDie3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label bidLabel;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.TextBox bidTextBox;
        private System.Windows.Forms.Label totalBidLabel;
        private System.Windows.Forms.PictureBox die2PictureBox;
        private System.Windows.Forms.ImageList diceFaces;
        private System.Windows.Forms.PictureBox die1PictureBox;
        private System.Windows.Forms.Label totalRollLabel;
        private System.Windows.Forms.GroupBox playerGroupBox;
        private System.Windows.Forms.GroupBox computerGroupBox;
        private System.Windows.Forms.PictureBox aiDice4;
        private System.Windows.Forms.Label aiRollTotal;
        private System.Windows.Forms.PictureBox aiDie3;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button bidButton;
        private System.Windows.Forms.TextBox totalBidsTextBox;
        private System.Windows.Forms.Label oppMoneyLabel;
        private System.Windows.Forms.TextBox opponentMoneyTextBox;
        private System.Windows.Forms.TextBox playerRollTotalTextBox;
        private System.Windows.Forms.TextBox opponentRollTotalTextBox;
        private System.Windows.Forms.Button callButton;
    }
}

