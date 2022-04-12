
namespace PhotoViewer
{
    partial class pictureForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.photoListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(312, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(476, 341);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // photoListBox
            // 
            this.photoListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.photoListBox.FormattingEnabled = true;
            this.photoListBox.ItemHeight = 16;
            this.photoListBox.Location = new System.Drawing.Point(12, 12);
            this.photoListBox.Name = "photoListBox";
            this.photoListBox.Size = new System.Drawing.Size(276, 100);
            this.photoListBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addButton.Location = new System.Drawing.Point(12, 150);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(276, 38);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Photo";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.viewButton.Location = new System.Drawing.Point(12, 205);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(276, 38);
            this.viewButton.TabIndex = 3;
            this.viewButton.Text = "View Photo";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitButton.Location = new System.Drawing.Point(12, 315);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(276, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.refreshButton.Location = new System.Drawing.Point(12, 260);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(276, 38);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // pictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.photoListBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "pictureForm";
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.pictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox photoListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button refreshButton;
    }
}

