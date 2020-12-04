namespace chapter6Assignment
{
    partial class hospitalCharges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hospitalCharges));
            this.daysLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.medicationLabel = new System.Windows.Forms.Label();
            this.medicationTextBox = new System.Windows.Forms.TextBox();
            this.labFeesLabel = new System.Windows.Forms.Label();
            this.labFeesTextBox = new System.Windows.Forms.TextBox();
            this.rehabLabel = new System.Windows.Forms.Label();
            this.rehabTextBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.kilroy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kilroy)).BeginInit();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(54, 98);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(155, 17);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "Days Spent in Hospital:";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(216, 95);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 22);
            this.daysTextBox.TabIndex = 1;
            // 
            // medicationLabel
            // 
            this.medicationLabel.AutoSize = true;
            this.medicationLabel.Location = new System.Drawing.Point(72, 136);
            this.medicationLabel.Name = "medicationLabel";
            this.medicationLabel.Size = new System.Drawing.Size(137, 17);
            this.medicationLabel.TabIndex = 2;
            this.medicationLabel.Text = "Medication Charges:";
            // 
            // medicationTextBox
            // 
            this.medicationTextBox.Location = new System.Drawing.Point(216, 133);
            this.medicationTextBox.Name = "medicationTextBox";
            this.medicationTextBox.Size = new System.Drawing.Size(100, 22);
            this.medicationTextBox.TabIndex = 2;
            // 
            // labFeesLabel
            // 
            this.labFeesLabel.AutoSize = true;
            this.labFeesLabel.Location = new System.Drawing.Point(138, 174);
            this.labFeesLabel.Name = "labFeesLabel";
            this.labFeesLabel.Size = new System.Drawing.Size(71, 17);
            this.labFeesLabel.TabIndex = 4;
            this.labFeesLabel.Text = "Lab Fees:";
            // 
            // labFeesTextBox
            // 
            this.labFeesTextBox.Location = new System.Drawing.Point(216, 171);
            this.labFeesTextBox.Name = "labFeesTextBox";
            this.labFeesTextBox.Size = new System.Drawing.Size(100, 22);
            this.labFeesTextBox.TabIndex = 3;
            // 
            // rehabLabel
            // 
            this.rehabLabel.AutoSize = true;
            this.rehabLabel.Location = new System.Drawing.Point(42, 209);
            this.rehabLabel.Name = "rehabLabel";
            this.rehabLabel.Size = new System.Drawing.Size(167, 17);
            this.rehabLabel.TabIndex = 6;
            this.rehabLabel.Text = "Physical Rehab Charges:";
            // 
            // rehabTextBox
            // 
            this.rehabTextBox.Location = new System.Drawing.Point(216, 206);
            this.rehabTextBox.Name = "rehabTextBox";
            this.rehabTextBox.Size = new System.Drawing.Size(100, 22);
            this.rehabTextBox.TabIndex = 4;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(42, 27);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(281, 65);
            this.instructionsLabel.TabIndex = 8;
            this.instructionsLabel.Text = "Enter the values into the appropriate text box below and the application will cal" +
    "culate the total cost of your hospital stay.";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(248, 297);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(150, 297);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(79, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(45, 297);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(79, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(133, 244);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(76, 17);
            this.totalCostLabel.TabIndex = 12;
            this.totalCostLabel.Text = "Total Cost:";
            this.totalCostLabel.Visible = false;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(216, 241);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalTextBox.TabIndex = 5;
            this.totalTextBox.Visible = false;
            // 
            // kilroy
            // 
            this.kilroy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kilroy.Image = ((System.Drawing.Image)(resources.GetObject("kilroy.Image")));
            this.kilroy.Location = new System.Drawing.Point(240, -12);
            this.kilroy.Name = "kilroy";
            this.kilroy.Size = new System.Drawing.Size(103, 72);
            this.kilroy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kilroy.TabIndex = 13;
            this.kilroy.TabStop = false;
            this.kilroy.Visible = false;
            // 
            // hospitalCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 351);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.rehabTextBox);
            this.Controls.Add(this.rehabLabel);
            this.Controls.Add(this.labFeesTextBox);
            this.Controls.Add(this.labFeesLabel);
            this.Controls.Add(this.medicationTextBox);
            this.Controls.Add(this.medicationLabel);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.kilroy);
            this.Name = "hospitalCharges";
            this.Text = "Hospital Charges";
            ((System.ComponentModel.ISupportInitialize)(this.kilroy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Label medicationLabel;
        private System.Windows.Forms.TextBox medicationTextBox;
        private System.Windows.Forms.Label labFeesLabel;
        private System.Windows.Forms.TextBox labFeesTextBox;
        private System.Windows.Forms.Label rehabLabel;
        private System.Windows.Forms.TextBox rehabTextBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.PictureBox kilroy;
    }
}

