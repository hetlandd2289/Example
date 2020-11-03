namespace PennyProject
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
            this.penniesLabel = new System.Windows.Forms.Label();
            this.nickelLabel = new System.Windows.Forms.Label();
            this.dimeLabel = new System.Windows.Forms.Label();
            this.coinGroupBox = new System.Windows.Forms.GroupBox();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.quartersInput = new System.Windows.Forms.TextBox();
            this.dimeInput = new System.Windows.Forms.TextBox();
            this.nickelsInput = new System.Windows.Forms.TextBox();
            this.penniesInput = new System.Windows.Forms.TextBox();
            this.quarterLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.coinGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // penniesLabel
            // 
            this.penniesLabel.AutoSize = true;
            this.penniesLabel.Location = new System.Drawing.Point(4, 32);
            this.penniesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.penniesLabel.Name = "penniesLabel";
            this.penniesLabel.Size = new System.Drawing.Size(48, 13);
            this.penniesLabel.TabIndex = 0;
            this.penniesLabel.Text = "Pennies:";
            // 
            // nickelLabel
            // 
            this.nickelLabel.AutoSize = true;
            this.nickelLabel.Location = new System.Drawing.Point(4, 54);
            this.nickelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nickelLabel.Name = "nickelLabel";
            this.nickelLabel.Size = new System.Drawing.Size(45, 13);
            this.nickelLabel.TabIndex = 1;
            this.nickelLabel.Text = "Nickels:";
            // 
            // dimeLabel
            // 
            this.dimeLabel.AutoSize = true;
            this.dimeLabel.Location = new System.Drawing.Point(4, 78);
            this.dimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dimeLabel.Name = "dimeLabel";
            this.dimeLabel.Size = new System.Drawing.Size(39, 13);
            this.dimeLabel.TabIndex = 2;
            this.dimeLabel.Text = "Dimes:";
            // 
            // coinGroupBox
            // 
            this.coinGroupBox.Controls.Add(this.totalAmountLabel);
            this.coinGroupBox.Controls.Add(this.totalOutput);
            this.coinGroupBox.Controls.Add(this.quartersInput);
            this.coinGroupBox.Controls.Add(this.dimeInput);
            this.coinGroupBox.Controls.Add(this.nickelsInput);
            this.coinGroupBox.Controls.Add(this.penniesInput);
            this.coinGroupBox.Controls.Add(this.quarterLabel);
            this.coinGroupBox.Controls.Add(this.nickelLabel);
            this.coinGroupBox.Controls.Add(this.dimeLabel);
            this.coinGroupBox.Controls.Add(this.penniesLabel);
            this.coinGroupBox.Location = new System.Drawing.Point(48, 89);
            this.coinGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coinGroupBox.Name = "coinGroupBox";
            this.coinGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coinGroupBox.Size = new System.Drawing.Size(212, 154);
            this.coinGroupBox.TabIndex = 3;
            this.coinGroupBox.TabStop = false;
            this.coinGroupBox.Text = "Coins";
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Location = new System.Drawing.Point(4, 124);
            this.totalAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(34, 13);
            this.totalAmountLabel.TabIndex = 9;
            this.totalAmountLabel.Text = "Total:";
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(66, 124);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalOutput.Multiline = true;
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.ReadOnly = true;
            this.totalOutput.Size = new System.Drawing.Size(142, 30);
            this.totalOutput.TabIndex = 8;
            // 
            // quartersInput
            // 
            this.quartersInput.Location = new System.Drawing.Point(66, 101);
            this.quartersInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quartersInput.Name = "quartersInput";
            this.quartersInput.Size = new System.Drawing.Size(76, 20);
            this.quartersInput.TabIndex = 7;
            // 
            // dimeInput
            // 
            this.dimeInput.Location = new System.Drawing.Point(66, 78);
            this.dimeInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dimeInput.Name = "dimeInput";
            this.dimeInput.Size = new System.Drawing.Size(76, 20);
            this.dimeInput.TabIndex = 6;
            // 
            // nickelsInput
            // 
            this.nickelsInput.Location = new System.Drawing.Point(66, 55);
            this.nickelsInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nickelsInput.Name = "nickelsInput";
            this.nickelsInput.Size = new System.Drawing.Size(76, 20);
            this.nickelsInput.TabIndex = 5;
            // 
            // penniesInput
            // 
            this.penniesInput.Location = new System.Drawing.Point(66, 32);
            this.penniesInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penniesInput.Name = "penniesInput";
            this.penniesInput.Size = new System.Drawing.Size(76, 20);
            this.penniesInput.TabIndex = 4;
            // 
            // quarterLabel
            // 
            this.quarterLabel.AutoSize = true;
            this.quarterLabel.Location = new System.Drawing.Point(4, 101);
            this.quarterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quarterLabel.Name = "quarterLabel";
            this.quarterLabel.Size = new System.Drawing.Size(50, 13);
            this.quarterLabel.TabIndex = 3;
            this.quarterLabel.Text = "Quarters:";
            // 
            // instructionLabel
            // 
            this.instructionLabel.Location = new System.Drawing.Point(48, 45);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(176, 42);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Input amount of coins and the application will tell you how much they are worth.";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(50, 249);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(68, 19);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(123, 249);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 19);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(196, 249);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 19);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 369);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.coinGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.coinGroupBox.ResumeLayout(false);
            this.coinGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label penniesLabel;
        private System.Windows.Forms.Label nickelLabel;
        private System.Windows.Forms.Label dimeLabel;
        private System.Windows.Forms.GroupBox coinGroupBox;
        private System.Windows.Forms.Label quarterLabel;
        private System.Windows.Forms.TextBox quartersInput;
        private System.Windows.Forms.TextBox dimeInput;
        private System.Windows.Forms.TextBox nickelsInput;
        private System.Windows.Forms.TextBox penniesInput;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

