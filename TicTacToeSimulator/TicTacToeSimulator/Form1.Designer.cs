
namespace TicTacToeSimulator
{
    partial class TicTacToe
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
            this.space00Label = new System.Windows.Forms.Label();
            this.space01Label = new System.Windows.Forms.Label();
            this.space02Label = new System.Windows.Forms.Label();
            this.space10Label = new System.Windows.Forms.Label();
            this.space11Label = new System.Windows.Forms.Label();
            this.space12Label = new System.Windows.Forms.Label();
            this.space20Label = new System.Windows.Forms.Label();
            this.space21Label = new System.Windows.Forms.Label();
            this.space22Label = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // space00Label
            // 
            this.space00Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space00Label.Location = new System.Drawing.Point(12, 9);
            this.space00Label.Name = "space00Label";
            this.space00Label.Size = new System.Drawing.Size(55, 55);
            this.space00Label.TabIndex = 0;
            this.space00Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space01Label
            // 
            this.space01Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space01Label.Location = new System.Drawing.Point(73, 9);
            this.space01Label.Name = "space01Label";
            this.space01Label.Size = new System.Drawing.Size(55, 55);
            this.space01Label.TabIndex = 1;
            this.space01Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space02Label
            // 
            this.space02Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space02Label.Location = new System.Drawing.Point(134, 9);
            this.space02Label.Name = "space02Label";
            this.space02Label.Size = new System.Drawing.Size(55, 55);
            this.space02Label.TabIndex = 2;
            this.space02Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space10Label
            // 
            this.space10Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space10Label.Location = new System.Drawing.Point(12, 73);
            this.space10Label.Name = "space10Label";
            this.space10Label.Size = new System.Drawing.Size(55, 55);
            this.space10Label.TabIndex = 3;
            this.space10Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space11Label
            // 
            this.space11Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space11Label.Location = new System.Drawing.Point(73, 73);
            this.space11Label.Name = "space11Label";
            this.space11Label.Size = new System.Drawing.Size(55, 55);
            this.space11Label.TabIndex = 4;
            this.space11Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space12Label
            // 
            this.space12Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space12Label.Location = new System.Drawing.Point(134, 73);
            this.space12Label.Name = "space12Label";
            this.space12Label.Size = new System.Drawing.Size(55, 55);
            this.space12Label.TabIndex = 5;
            this.space12Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space20Label
            // 
            this.space20Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space20Label.Location = new System.Drawing.Point(12, 137);
            this.space20Label.Name = "space20Label";
            this.space20Label.Size = new System.Drawing.Size(55, 55);
            this.space20Label.TabIndex = 6;
            this.space20Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space21Label
            // 
            this.space21Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space21Label.Location = new System.Drawing.Point(73, 137);
            this.space21Label.Name = "space21Label";
            this.space21Label.Size = new System.Drawing.Size(55, 55);
            this.space21Label.TabIndex = 7;
            this.space21Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space22Label
            // 
            this.space22Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.space22Label.Location = new System.Drawing.Point(134, 137);
            this.space22Label.Name = "space22Label";
            this.space22Label.Size = new System.Drawing.Size(55, 55);
            this.space22Label.TabIndex = 8;
            this.space22Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(12, 272);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 9;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(114, 272);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(12, 210);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(177, 59);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 304);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.space22Label);
            this.Controls.Add(this.space21Label);
            this.Controls.Add(this.space20Label);
            this.Controls.Add(this.space12Label);
            this.Controls.Add(this.space11Label);
            this.Controls.Add(this.space10Label);
            this.Controls.Add(this.space02Label);
            this.Controls.Add(this.space01Label);
            this.Controls.Add(this.space00Label);
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label space00Label;
        private System.Windows.Forms.Label space01Label;
        private System.Windows.Forms.Label space02Label;
        private System.Windows.Forms.Label space10Label;
        private System.Windows.Forms.Label space11Label;
        private System.Windows.Forms.Label space12Label;
        private System.Windows.Forms.Label space20Label;
        private System.Windows.Forms.Label space21Label;
        private System.Windows.Forms.Label space22Label;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

