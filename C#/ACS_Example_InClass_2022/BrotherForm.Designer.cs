namespace ACS_Example_InClass_2022
{
    partial class BrotherForm
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
            this.bruhBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bruhBtn
            // 
            this.bruhBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bruhBtn.Location = new System.Drawing.Point(12, 12);
            this.bruhBtn.Name = "bruhBtn";
            this.bruhBtn.Size = new System.Drawing.Size(75, 23);
            this.bruhBtn.TabIndex = 0;
            this.bruhBtn.Text = "Bruh";
            this.bruhBtn.UseVisualStyleBackColor = true;
            this.bruhBtn.Click += new System.EventHandler(this.bruhBtn_Click);
            // 
            // BrotherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bruhBtn);
            this.Name = "BrotherForm";
            this.Text = "Brother";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bruhBtn;
    }
}