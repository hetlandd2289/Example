
namespace ACS_Example_InClass_2022
{
    partial class ExampleForm
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
            this.checkDigitBtn = new System.Windows.Forms.Button();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.indexTB = new System.Windows.Forms.TextBox();
            this.inputLbl = new System.Windows.Forms.Label();
            this.indexLbl = new System.Windows.Forms.Label();
            this.checkLetterBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.swapFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkDigitBtn
            // 
            this.checkDigitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDigitBtn.Location = new System.Drawing.Point(15, 135);
            this.checkDigitBtn.Name = "checkDigitBtn";
            this.checkDigitBtn.Size = new System.Drawing.Size(101, 26);
            this.checkDigitBtn.TabIndex = 0;
            this.checkDigitBtn.Text = "Digit, Bruh?";
            this.checkDigitBtn.UseVisualStyleBackColor = true;
            this.checkDigitBtn.Click += new System.EventHandler(this.checkDigitBtn_Click);
            // 
            // inputTB
            // 
            this.inputTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTB.Location = new System.Drawing.Point(247, 53);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(100, 22);
            this.inputTB.TabIndex = 1;
            // 
            // indexTB
            // 
            this.indexTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexTB.Location = new System.Drawing.Point(247, 81);
            this.indexTB.Name = "indexTB";
            this.indexTB.Size = new System.Drawing.Size(100, 22);
            this.indexTB.TabIndex = 2;
            // 
            // inputLbl
            // 
            this.inputLbl.AutoSize = true;
            this.inputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLbl.Location = new System.Drawing.Point(12, 56);
            this.inputLbl.Name = "inputLbl";
            this.inputLbl.Size = new System.Drawing.Size(228, 16);
            this.inputLbl.TabIndex = 3;
            this.inputLbl.Text = "Enter the String or Character to check:";
            // 
            // indexLbl
            // 
            this.indexLbl.AutoSize = true;
            this.indexLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexLbl.Location = new System.Drawing.Point(198, 84);
            this.indexLbl.Name = "indexLbl";
            this.indexLbl.Size = new System.Drawing.Size(42, 16);
            this.indexLbl.TabIndex = 4;
            this.indexLbl.Text = "Index:";
            // 
            // checkLetterBtn
            // 
            this.checkLetterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLetterBtn.Location = new System.Drawing.Point(122, 135);
            this.checkLetterBtn.Name = "checkLetterBtn";
            this.checkLetterBtn.Size = new System.Drawing.Size(101, 26);
            this.checkLetterBtn.TabIndex = 5;
            this.checkLetterBtn.Text = "Letter, Bruh?";
            this.checkLetterBtn.UseVisualStyleBackColor = true;
            this.checkLetterBtn.Click += new System.EventHandler(this.checkLetterBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(253, 135);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 26);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit, Bruh?";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // swapFormBtn
            // 
            this.swapFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swapFormBtn.Location = new System.Drawing.Point(15, 12);
            this.swapFormBtn.Name = "swapFormBtn";
            this.swapFormBtn.Size = new System.Drawing.Size(101, 23);
            this.swapFormBtn.TabIndex = 7;
            this.swapFormBtn.Text = "Brother Form";
            this.swapFormBtn.UseVisualStyleBackColor = true;
            this.swapFormBtn.Click += new System.EventHandler(this.swapFormBtn_Click);
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(361, 173);
            this.Controls.Add(this.swapFormBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.checkLetterBtn);
            this.Controls.Add(this.indexLbl);
            this.Controls.Add(this.inputLbl);
            this.Controls.Add(this.indexTB);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.checkDigitBtn);
            this.Name = "ExampleForm";
            this.Text = "Bruh?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkDigitBtn;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.TextBox indexTB;
        private System.Windows.Forms.Label inputLbl;
        private System.Windows.Forms.Label indexLbl;
        private System.Windows.Forms.Button checkLetterBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button swapFormBtn;
    }
}

