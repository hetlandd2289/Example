namespace Exam1_DrakeHetland
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
            this.jackOfClubs = new System.Windows.Forms.PictureBox();
            this.tenOfDiamonds = new System.Windows.Forms.PictureBox();
            this.nineOfClubs = new System.Windows.Forms.PictureBox();
            this.sevenOfClubs = new System.Windows.Forms.PictureBox();
            this.aceOfSpades = new System.Windows.Forms.PictureBox();
            this.cardDisplay = new System.Windows.Forms.TextBox();
            this.clickPrompt = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jackOfClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenOfDiamonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineOfClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevenOfClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfSpades)).BeginInit();
            this.SuspendLayout();
            // 
            // jackOfClubs
            // 
            this.jackOfClubs.Image = ((System.Drawing.Image)(resources.GetObject("jackOfClubs.Image")));
            this.jackOfClubs.Location = new System.Drawing.Point(218, 127);
            this.jackOfClubs.Name = "jackOfClubs";
            this.jackOfClubs.Size = new System.Drawing.Size(96, 128);
            this.jackOfClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jackOfClubs.TabIndex = 0;
            this.jackOfClubs.TabStop = false;
            this.jackOfClubs.Click += new System.EventHandler(this.jackOfClubs_Click);
            // 
            // tenOfDiamonds
            // 
            this.tenOfDiamonds.Image = ((System.Drawing.Image)(resources.GetObject("tenOfDiamonds.Image")));
            this.tenOfDiamonds.Location = new System.Drawing.Point(336, 127);
            this.tenOfDiamonds.Name = "tenOfDiamonds";
            this.tenOfDiamonds.Size = new System.Drawing.Size(96, 128);
            this.tenOfDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenOfDiamonds.TabIndex = 1;
            this.tenOfDiamonds.TabStop = false;
            this.tenOfDiamonds.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // nineOfClubs
            // 
            this.nineOfClubs.Image = ((System.Drawing.Image)(resources.GetObject("nineOfClubs.Image")));
            this.nineOfClubs.Location = new System.Drawing.Point(460, 127);
            this.nineOfClubs.Name = "nineOfClubs";
            this.nineOfClubs.Size = new System.Drawing.Size(96, 128);
            this.nineOfClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nineOfClubs.TabIndex = 2;
            this.nineOfClubs.TabStop = false;
            this.nineOfClubs.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // sevenOfClubs
            // 
            this.sevenOfClubs.Image = ((System.Drawing.Image)(resources.GetObject("sevenOfClubs.Image")));
            this.sevenOfClubs.Location = new System.Drawing.Point(594, 127);
            this.sevenOfClubs.Name = "sevenOfClubs";
            this.sevenOfClubs.Size = new System.Drawing.Size(96, 128);
            this.sevenOfClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sevenOfClubs.TabIndex = 3;
            this.sevenOfClubs.TabStop = false;
            this.sevenOfClubs.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // aceOfSpades
            // 
            this.aceOfSpades.Image = ((System.Drawing.Image)(resources.GetObject("aceOfSpades.Image")));
            this.aceOfSpades.Location = new System.Drawing.Point(98, 127);
            this.aceOfSpades.Name = "aceOfSpades";
            this.aceOfSpades.Size = new System.Drawing.Size(96, 128);
            this.aceOfSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceOfSpades.TabIndex = 4;
            this.aceOfSpades.TabStop = false;
            this.aceOfSpades.Click += new System.EventHandler(this.aceOfSpades_Click);
            // 
            // cardDisplay
            // 
            this.cardDisplay.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardDisplay.Location = new System.Drawing.Point(98, 289);
            this.cardDisplay.Multiline = true;
            this.cardDisplay.Name = "cardDisplay";
            this.cardDisplay.ReadOnly = true;
            this.cardDisplay.Size = new System.Drawing.Size(592, 62);
            this.cardDisplay.TabIndex = 5;
            this.cardDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cardDisplay.TextChanged += new System.EventHandler(this.cardDisplay_TextChanged);
            // 
            // clickPrompt
            // 
            this.clickPrompt.BackColor = System.Drawing.SystemColors.Control;
            this.clickPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clickPrompt.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickPrompt.Location = new System.Drawing.Point(218, 67);
            this.clickPrompt.Multiline = true;
            this.clickPrompt.Name = "clickPrompt";
            this.clickPrompt.ReadOnly = true;
            this.clickPrompt.Size = new System.Drawing.Size(338, 32);
            this.clickPrompt.TabIndex = 6;
            this.clickPrompt.Text = "Click a Card to See Its Name";
            this.clickPrompt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clickPrompt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(336, 377);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clickPrompt);
            this.Controls.Add(this.cardDisplay);
            this.Controls.Add(this.aceOfSpades);
            this.Controls.Add(this.sevenOfClubs);
            this.Controls.Add(this.nineOfClubs);
            this.Controls.Add(this.tenOfDiamonds);
            this.Controls.Add(this.jackOfClubs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.jackOfClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenOfDiamonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nineOfClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevenOfClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfSpades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox jackOfClubs;
        private System.Windows.Forms.PictureBox tenOfDiamonds;
        private System.Windows.Forms.PictureBox nineOfClubs;
        private System.Windows.Forms.PictureBox sevenOfClubs;
        private System.Windows.Forms.PictureBox aceOfSpades;
        private System.Windows.Forms.TextBox cardDisplay;
        private System.Windows.Forms.TextBox clickPrompt;
        private System.Windows.Forms.Button exitButton;
    }
}

