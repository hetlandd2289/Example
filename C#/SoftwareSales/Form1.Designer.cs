namespace SoftwareSales
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
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultPannel = new System.Windows.Forms.Panel();
            this.enterButton = new System.Windows.Forms.Button();
            this.resultPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(140, 193);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Location = new System.Drawing.Point(32, 27);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(158, 18);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Emter the quantity to purchase";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(35, 66);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(185, 20);
            this.quantityTextBox.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(3, 11);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 3;
            // 
            // resultPannel
            // 
            this.resultPannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultPannel.Controls.Add(this.resultLabel);
            this.resultPannel.Location = new System.Drawing.Point(35, 92);
            this.resultPannel.Name = "resultPannel";
            this.resultPannel.Size = new System.Drawing.Size(185, 94);
            this.resultPannel.TabIndex = 4;
            this.resultPannel.Visible = false;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(35, 193);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(86, 23);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Calculate";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 235);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.resultPannel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.resultPannel.ResumeLayout(false);
            this.resultPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Panel resultPannel;
        private System.Windows.Forms.Button enterButton;
    }
}

