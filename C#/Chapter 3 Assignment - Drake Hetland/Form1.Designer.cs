namespace Chapter_3_Assignment___Drake_Hetland
{
    partial class stadiumSeating
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
            this.seatInstructions = new System.Windows.Forms.Label();
            this.classATicketLabel = new System.Windows.Forms.Label();
            this.classBTicketLabel = new System.Windows.Forms.Label();
            this.classCTicketLabel = new System.Windows.Forms.Label();
            this.classATicketText = new System.Windows.Forms.TextBox();
            this.classBTicketText = new System.Windows.Forms.TextBox();
            this.classCTicketText = new System.Windows.Forms.TextBox();
            this.ticketsGroupBox = new System.Windows.Forms.GroupBox();
            this.classARevLabel = new System.Windows.Forms.Label();
            this.classBRevLabel = new System.Windows.Forms.Label();
            this.classCRevLabel = new System.Windows.Forms.Label();
            this.classARevInput = new System.Windows.Forms.TextBox();
            this.classBRevInput = new System.Windows.Forms.TextBox();
            this.classCRevInput = new System.Windows.Forms.TextBox();
            this.revenueGroupBox = new System.Windows.Forms.GroupBox();
            this.totalRevenue = new System.Windows.Forms.TextBox();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // seatInstructions
            // 
            this.seatInstructions.Location = new System.Drawing.Point(25, 33);
            this.seatInstructions.Name = "seatInstructions";
            this.seatInstructions.Size = new System.Drawing.Size(209, 46);
            this.seatInstructions.TabIndex = 0;
            this.seatInstructions.Text = "Input number of tickets sold for each class of seat";
            // 
            // classATicketLabel
            // 
            this.classATicketLabel.AutoSize = true;
            this.classATicketLabel.Location = new System.Drawing.Point(28, 82);
            this.classATicketLabel.Name = "classATicketLabel";
            this.classATicketLabel.Size = new System.Drawing.Size(59, 17);
            this.classATicketLabel.TabIndex = 1;
            this.classATicketLabel.Text = "Class A:";
            // 
            // classBTicketLabel
            // 
            this.classBTicketLabel.AutoSize = true;
            this.classBTicketLabel.Location = new System.Drawing.Point(28, 115);
            this.classBTicketLabel.Name = "classBTicketLabel";
            this.classBTicketLabel.Size = new System.Drawing.Size(59, 17);
            this.classBTicketLabel.TabIndex = 2;
            this.classBTicketLabel.Text = "Class B:";
            // 
            // classCTicketLabel
            // 
            this.classCTicketLabel.AutoSize = true;
            this.classCTicketLabel.Location = new System.Drawing.Point(28, 148);
            this.classCTicketLabel.Name = "classCTicketLabel";
            this.classCTicketLabel.Size = new System.Drawing.Size(59, 17);
            this.classCTicketLabel.TabIndex = 3;
            this.classCTicketLabel.Text = "Class C:";
            // 
            // classATicketText
            // 
            this.classATicketText.Location = new System.Drawing.Point(134, 82);
            this.classATicketText.Name = "classATicketText";
            this.classATicketText.Size = new System.Drawing.Size(100, 22);
            this.classATicketText.TabIndex = 0;
            // 
            // classBTicketText
            // 
            this.classBTicketText.Location = new System.Drawing.Point(134, 115);
            this.classBTicketText.Name = "classBTicketText";
            this.classBTicketText.Size = new System.Drawing.Size(100, 22);
            this.classBTicketText.TabIndex = 1;
            // 
            // classCTicketText
            // 
            this.classCTicketText.Location = new System.Drawing.Point(134, 148);
            this.classCTicketText.Name = "classCTicketText";
            this.classCTicketText.Size = new System.Drawing.Size(100, 22);
            this.classCTicketText.TabIndex = 2;
            // 
            // ticketsGroupBox
            // 
            this.ticketsGroupBox.Controls.Add(this.classBTicketText);
            this.ticketsGroupBox.Controls.Add(this.classCTicketText);
            this.ticketsGroupBox.Controls.Add(this.seatInstructions);
            this.ticketsGroupBox.Controls.Add(this.classATicketLabel);
            this.ticketsGroupBox.Controls.Add(this.classATicketText);
            this.ticketsGroupBox.Controls.Add(this.classBTicketLabel);
            this.ticketsGroupBox.Controls.Add(this.classCTicketLabel);
            this.ticketsGroupBox.Location = new System.Drawing.Point(33, 45);
            this.ticketsGroupBox.Name = "ticketsGroupBox";
            this.ticketsGroupBox.Size = new System.Drawing.Size(240, 176);
            this.ticketsGroupBox.TabIndex = 7;
            this.ticketsGroupBox.TabStop = false;
            this.ticketsGroupBox.Text = "Ticket Sales";
            // 
            // classARevLabel
            // 
            this.classARevLabel.AutoSize = true;
            this.classARevLabel.Location = new System.Drawing.Point(59, 51);
            this.classARevLabel.Name = "classARevLabel";
            this.classARevLabel.Size = new System.Drawing.Size(59, 17);
            this.classARevLabel.TabIndex = 8;
            this.classARevLabel.Text = "Class A:";
            // 
            // classBRevLabel
            // 
            this.classBRevLabel.AutoSize = true;
            this.classBRevLabel.Location = new System.Drawing.Point(59, 83);
            this.classBRevLabel.Name = "classBRevLabel";
            this.classBRevLabel.Size = new System.Drawing.Size(59, 17);
            this.classBRevLabel.TabIndex = 9;
            this.classBRevLabel.Text = "Class B:";
            // 
            // classCRevLabel
            // 
            this.classCRevLabel.AutoSize = true;
            this.classCRevLabel.Location = new System.Drawing.Point(59, 113);
            this.classCRevLabel.Name = "classCRevLabel";
            this.classCRevLabel.Size = new System.Drawing.Size(59, 17);
            this.classCRevLabel.TabIndex = 10;
            this.classCRevLabel.Text = "Class C:";
            // 
            // classARevInput
            // 
            this.classARevInput.Location = new System.Drawing.Point(158, 51);
            this.classARevInput.Name = "classARevInput";
            this.classARevInput.ReadOnly = true;
            this.classARevInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.classARevInput.Size = new System.Drawing.Size(100, 22);
            this.classARevInput.TabIndex = 6;
            // 
            // classBRevInput
            // 
            this.classBRevInput.Location = new System.Drawing.Point(158, 83);
            this.classBRevInput.Name = "classBRevInput";
            this.classBRevInput.ReadOnly = true;
            this.classBRevInput.Size = new System.Drawing.Size(100, 22);
            this.classBRevInput.TabIndex = 7;
            // 
            // classCRevInput
            // 
            this.classCRevInput.Location = new System.Drawing.Point(158, 112);
            this.classCRevInput.Name = "classCRevInput";
            this.classCRevInput.ReadOnly = true;
            this.classCRevInput.Size = new System.Drawing.Size(100, 22);
            this.classCRevInput.TabIndex = 8;
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.Controls.Add(this.totalRevenue);
            this.revenueGroupBox.Controls.Add(this.classCRevInput);
            this.revenueGroupBox.Controls.Add(this.totalRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.classARevLabel);
            this.revenueGroupBox.Controls.Add(this.classBRevLabel);
            this.revenueGroupBox.Controls.Add(this.classCRevLabel);
            this.revenueGroupBox.Controls.Add(this.classBRevInput);
            this.revenueGroupBox.Controls.Add(this.classARevInput);
            this.revenueGroupBox.Location = new System.Drawing.Point(326, 45);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Size = new System.Drawing.Size(264, 177);
            this.revenueGroupBox.TabIndex = 14;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Revenue Generated";
            // 
            // totalRevenue
            // 
            this.totalRevenue.Location = new System.Drawing.Point(158, 143);
            this.totalRevenue.Name = "totalRevenue";
            this.totalRevenue.ReadOnly = true;
            this.totalRevenue.Size = new System.Drawing.Size(100, 22);
            this.totalRevenue.TabIndex = 9;
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.AutoSize = true;
            this.totalRevenueLabel.Location = new System.Drawing.Point(21, 143);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(97, 17);
            this.totalRevenueLabel.TabIndex = 15;
            this.totalRevenueLabel.Text = "Total Reveue:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(103, 265);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(146, 43);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(267, 265);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 43);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(388, 265);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 43);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stadiumSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.ticketsGroupBox);
            this.Name = "stadiumSeating";
            this.Text = "Stadium Seating";
            this.ticketsGroupBox.ResumeLayout(false);
            this.ticketsGroupBox.PerformLayout();
            this.revenueGroupBox.ResumeLayout(false);
            this.revenueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label seatInstructions;
        private System.Windows.Forms.Label classATicketLabel;
        private System.Windows.Forms.Label classBTicketLabel;
        private System.Windows.Forms.Label classCTicketLabel;
        private System.Windows.Forms.TextBox classATicketText;
        private System.Windows.Forms.TextBox classBTicketText;
        private System.Windows.Forms.TextBox classCTicketText;
        private System.Windows.Forms.GroupBox ticketsGroupBox;
        private System.Windows.Forms.Label classARevLabel;
        private System.Windows.Forms.Label classBRevLabel;
        private System.Windows.Forms.Label classCRevLabel;
        private System.Windows.Forms.TextBox classARevInput;
        private System.Windows.Forms.TextBox classBRevInput;
        private System.Windows.Forms.TextBox classCRevInput;
        private System.Windows.Forms.GroupBox revenueGroupBox;
        private System.Windows.Forms.TextBox totalRevenue;
        private System.Windows.Forms.Label totalRevenueLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

