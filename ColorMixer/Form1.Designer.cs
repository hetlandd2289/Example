namespace ColorMixer
{
    partial class colorMixer
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
            this.quitButton = new System.Windows.Forms.Button();
            this.mixButton = new System.Windows.Forms.Button();
            this.redRadioButton1 = new System.Windows.Forms.RadioButton();
            this.blueRadioButton1 = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton1 = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton2 = new System.Windows.Forms.RadioButton();
            this.blueRadioButton2 = new System.Windows.Forms.RadioButton();
            this.redRadioButton2 = new System.Windows.Forms.RadioButton();
            this.color1GroupBox = new System.Windows.Forms.GroupBox();
            this.color2GroupBox = new System.Windows.Forms.GroupBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.colorGroupBox3 = new System.Windows.Forms.GroupBox();
            this.redCheckBox1 = new System.Windows.Forms.CheckBox();
            this.blueCheckBox1 = new System.Windows.Forms.CheckBox();
            this.yellowCheckBox1 = new System.Windows.Forms.CheckBox();
            this.colorGroupBox4 = new System.Windows.Forms.GroupBox();
            this.yellowCheckBox2 = new System.Windows.Forms.CheckBox();
            this.blueCheckBox2 = new System.Windows.Forms.CheckBox();
            this.redCheckBox2 = new System.Windows.Forms.CheckBox();
            this.mixCheckedButton = new System.Windows.Forms.Button();
            this.color1GroupBox.SuspendLayout();
            this.color2GroupBox.SuspendLayout();
            this.colorGroupBox3.SuspendLayout();
            this.colorGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(288, 192);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(76, 23);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(12, 192);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(75, 23);
            this.mixButton.TabIndex = 4;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // redRadioButton1
            // 
            this.redRadioButton1.AutoSize = true;
            this.redRadioButton1.Checked = true;
            this.redRadioButton1.Location = new System.Drawing.Point(6, 24);
            this.redRadioButton1.Name = "redRadioButton1";
            this.redRadioButton1.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton1.TabIndex = 0;
            this.redRadioButton1.TabStop = true;
            this.redRadioButton1.Text = "Red";
            this.redRadioButton1.UseVisualStyleBackColor = true;
            this.redRadioButton1.CheckedChanged += new System.EventHandler(this.redRadioButton1_CheckedChanged);
            // 
            // blueRadioButton1
            // 
            this.blueRadioButton1.AutoSize = true;
            this.blueRadioButton1.Location = new System.Drawing.Point(6, 47);
            this.blueRadioButton1.Name = "blueRadioButton1";
            this.blueRadioButton1.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton1.TabIndex = 1;
            this.blueRadioButton1.TabStop = true;
            this.blueRadioButton1.Text = "Blue";
            this.blueRadioButton1.UseVisualStyleBackColor = true;
            // 
            // yellowRadioButton1
            // 
            this.yellowRadioButton1.AutoSize = true;
            this.yellowRadioButton1.Location = new System.Drawing.Point(6, 70);
            this.yellowRadioButton1.Name = "yellowRadioButton1";
            this.yellowRadioButton1.Size = new System.Drawing.Size(56, 17);
            this.yellowRadioButton1.TabIndex = 2;
            this.yellowRadioButton1.TabStop = true;
            this.yellowRadioButton1.Text = "Yellow";
            this.yellowRadioButton1.UseVisualStyleBackColor = true;
            // 
            // yellowRadioButton2
            // 
            this.yellowRadioButton2.AutoSize = true;
            this.yellowRadioButton2.Location = new System.Drawing.Point(6, 68);
            this.yellowRadioButton2.Name = "yellowRadioButton2";
            this.yellowRadioButton2.Size = new System.Drawing.Size(56, 17);
            this.yellowRadioButton2.TabIndex = 2;
            this.yellowRadioButton2.TabStop = true;
            this.yellowRadioButton2.Text = "Yellow";
            this.yellowRadioButton2.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton2
            // 
            this.blueRadioButton2.AutoSize = true;
            this.blueRadioButton2.Location = new System.Drawing.Point(6, 45);
            this.blueRadioButton2.Name = "blueRadioButton2";
            this.blueRadioButton2.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton2.TabIndex = 1;
            this.blueRadioButton2.TabStop = true;
            this.blueRadioButton2.Text = "Blue";
            this.blueRadioButton2.UseVisualStyleBackColor = true;
            // 
            // redRadioButton2
            // 
            this.redRadioButton2.AutoSize = true;
            this.redRadioButton2.Checked = true;
            this.redRadioButton2.Location = new System.Drawing.Point(6, 22);
            this.redRadioButton2.Name = "redRadioButton2";
            this.redRadioButton2.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton2.TabIndex = 0;
            this.redRadioButton2.TabStop = true;
            this.redRadioButton2.Text = "Red";
            this.redRadioButton2.UseVisualStyleBackColor = true;
            // 
            // color1GroupBox
            // 
            this.color1GroupBox.Controls.Add(this.blueRadioButton1);
            this.color1GroupBox.Controls.Add(this.redRadioButton1);
            this.color1GroupBox.Controls.Add(this.yellowRadioButton1);
            this.color1GroupBox.Location = new System.Drawing.Point(12, 86);
            this.color1GroupBox.Name = "color1GroupBox";
            this.color1GroupBox.Size = new System.Drawing.Size(75, 100);
            this.color1GroupBox.TabIndex = 0;
            this.color1GroupBox.TabStop = false;
            this.color1GroupBox.Text = "Color1";
            // 
            // color2GroupBox
            // 
            this.color2GroupBox.Controls.Add(this.yellowRadioButton2);
            this.color2GroupBox.Controls.Add(this.redRadioButton2);
            this.color2GroupBox.Controls.Add(this.blueRadioButton2);
            this.color2GroupBox.Location = new System.Drawing.Point(93, 86);
            this.color2GroupBox.Name = "color2GroupBox";
            this.color2GroupBox.Size = new System.Drawing.Size(75, 100);
            this.color2GroupBox.TabIndex = 1;
            this.color2GroupBox.TabStop = false;
            this.color2GroupBox.Text = "Color 2";
            // 
            // instructionLabel
            // 
            this.instructionLabel.Location = new System.Drawing.Point(9, 48);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(159, 35);
            this.instructionLabel.TabIndex = 10;
            this.instructionLabel.Text = "Select a color from both groups to combine into a new color!";
            // 
            // colorGroupBox3
            // 
            this.colorGroupBox3.Controls.Add(this.yellowCheckBox1);
            this.colorGroupBox3.Controls.Add(this.blueCheckBox1);
            this.colorGroupBox3.Controls.Add(this.redCheckBox1);
            this.colorGroupBox3.Location = new System.Drawing.Point(206, 86);
            this.colorGroupBox3.Name = "colorGroupBox3";
            this.colorGroupBox3.Size = new System.Drawing.Size(76, 100);
            this.colorGroupBox3.TabIndex = 2;
            this.colorGroupBox3.TabStop = false;
            this.colorGroupBox3.Text = "Color 1";
            // 
            // redCheckBox1
            // 
            this.redCheckBox1.AutoSize = true;
            this.redCheckBox1.Location = new System.Drawing.Point(7, 20);
            this.redCheckBox1.Name = "redCheckBox1";
            this.redCheckBox1.Size = new System.Drawing.Size(46, 17);
            this.redCheckBox1.TabIndex = 0;
            this.redCheckBox1.Text = "Red";
            this.redCheckBox1.UseVisualStyleBackColor = true;
            this.redCheckBox1.CheckedChanged += new System.EventHandler(this.redCheckBox1_CheckedChanged);
            // 
            // blueCheckBox1
            // 
            this.blueCheckBox1.AutoSize = true;
            this.blueCheckBox1.Location = new System.Drawing.Point(7, 43);
            this.blueCheckBox1.Name = "blueCheckBox1";
            this.blueCheckBox1.Size = new System.Drawing.Size(47, 17);
            this.blueCheckBox1.TabIndex = 1;
            this.blueCheckBox1.Text = "Blue";
            this.blueCheckBox1.UseVisualStyleBackColor = true;
            // 
            // yellowCheckBox1
            // 
            this.yellowCheckBox1.AutoSize = true;
            this.yellowCheckBox1.Location = new System.Drawing.Point(7, 66);
            this.yellowCheckBox1.Name = "yellowCheckBox1";
            this.yellowCheckBox1.Size = new System.Drawing.Size(57, 17);
            this.yellowCheckBox1.TabIndex = 2;
            this.yellowCheckBox1.Text = "Yellow";
            this.yellowCheckBox1.UseVisualStyleBackColor = true;
            // 
            // colorGroupBox4
            // 
            this.colorGroupBox4.Controls.Add(this.yellowCheckBox2);
            this.colorGroupBox4.Controls.Add(this.blueCheckBox2);
            this.colorGroupBox4.Controls.Add(this.redCheckBox2);
            this.colorGroupBox4.Location = new System.Drawing.Point(288, 86);
            this.colorGroupBox4.Name = "colorGroupBox4";
            this.colorGroupBox4.Size = new System.Drawing.Size(76, 100);
            this.colorGroupBox4.TabIndex = 3;
            this.colorGroupBox4.TabStop = false;
            this.colorGroupBox4.Text = "Color 2";
            // 
            // yellowCheckBox2
            // 
            this.yellowCheckBox2.AutoSize = true;
            this.yellowCheckBox2.Location = new System.Drawing.Point(7, 66);
            this.yellowCheckBox2.Name = "yellowCheckBox2";
            this.yellowCheckBox2.Size = new System.Drawing.Size(57, 17);
            this.yellowCheckBox2.TabIndex = 2;
            this.yellowCheckBox2.Text = "Yellow";
            this.yellowCheckBox2.UseVisualStyleBackColor = true;
            // 
            // blueCheckBox2
            // 
            this.blueCheckBox2.AutoSize = true;
            this.blueCheckBox2.Location = new System.Drawing.Point(7, 43);
            this.blueCheckBox2.Name = "blueCheckBox2";
            this.blueCheckBox2.Size = new System.Drawing.Size(47, 17);
            this.blueCheckBox2.TabIndex = 1;
            this.blueCheckBox2.Text = "Blue";
            this.blueCheckBox2.UseVisualStyleBackColor = true;
            // 
            // redCheckBox2
            // 
            this.redCheckBox2.AutoSize = true;
            this.redCheckBox2.Location = new System.Drawing.Point(7, 20);
            this.redCheckBox2.Name = "redCheckBox2";
            this.redCheckBox2.Size = new System.Drawing.Size(46, 17);
            this.redCheckBox2.TabIndex = 0;
            this.redCheckBox2.Text = "Red";
            this.redCheckBox2.UseVisualStyleBackColor = true;
            // 
            // mixCheckedButton
            // 
            this.mixCheckedButton.Location = new System.Drawing.Point(206, 192);
            this.mixCheckedButton.Name = "mixCheckedButton";
            this.mixCheckedButton.Size = new System.Drawing.Size(76, 23);
            this.mixCheckedButton.TabIndex = 5;
            this.mixCheckedButton.Text = "Mixer";
            this.mixCheckedButton.UseVisualStyleBackColor = true;
            this.mixCheckedButton.Click += new System.EventHandler(this.mixCheckedButton_Click);
            // 
            // colorMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 264);
            this.Controls.Add(this.mixCheckedButton);
            this.Controls.Add(this.colorGroupBox4);
            this.Controls.Add(this.colorGroupBox3);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.color2GroupBox);
            this.Controls.Add(this.color1GroupBox);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.quitButton);
            this.Name = "colorMixer";
            this.Text = "Color Mixer";
            this.Load += new System.EventHandler(this.colorMixer_Load);
            this.color1GroupBox.ResumeLayout(false);
            this.color1GroupBox.PerformLayout();
            this.color2GroupBox.ResumeLayout(false);
            this.color2GroupBox.PerformLayout();
            this.colorGroupBox3.ResumeLayout(false);
            this.colorGroupBox3.PerformLayout();
            this.colorGroupBox4.ResumeLayout(false);
            this.colorGroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.RadioButton redRadioButton1;
        private System.Windows.Forms.RadioButton blueRadioButton1;
        private System.Windows.Forms.RadioButton yellowRadioButton1;
        private System.Windows.Forms.RadioButton yellowRadioButton2;
        private System.Windows.Forms.RadioButton blueRadioButton2;
        private System.Windows.Forms.RadioButton redRadioButton2;
        private System.Windows.Forms.GroupBox color1GroupBox;
        private System.Windows.Forms.GroupBox color2GroupBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.GroupBox colorGroupBox3;
        private System.Windows.Forms.CheckBox yellowCheckBox1;
        private System.Windows.Forms.CheckBox blueCheckBox1;
        private System.Windows.Forms.CheckBox redCheckBox1;
        private System.Windows.Forms.GroupBox colorGroupBox4;
        private System.Windows.Forms.CheckBox yellowCheckBox2;
        private System.Windows.Forms.CheckBox blueCheckBox2;
        private System.Windows.Forms.CheckBox redCheckBox2;
        private System.Windows.Forms.Button mixCheckedButton;
    }
}

