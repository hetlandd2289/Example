namespace chapter5Example
{
    partial class chapter5Example
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
            this.dynamicListBox = new System.Windows.Forms.ListBox();
            this.newItemTextBox = new System.Windows.Forms.TextBox();
            this.newItemLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.clearItemsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dynamicListBox
            // 
            this.dynamicListBox.FormattingEnabled = true;
            this.dynamicListBox.Location = new System.Drawing.Point(12, 12);
            this.dynamicListBox.Name = "dynamicListBox";
            this.dynamicListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.dynamicListBox.Size = new System.Drawing.Size(120, 95);
            this.dynamicListBox.TabIndex = 0;
            // 
            // newItemTextBox
            // 
            this.newItemTextBox.Location = new System.Drawing.Point(15, 137);
            this.newItemTextBox.Name = "newItemTextBox";
            this.newItemTextBox.Size = new System.Drawing.Size(117, 20);
            this.newItemTextBox.TabIndex = 1;
            // 
            // newItemLabel
            // 
            this.newItemLabel.AutoSize = true;
            this.newItemLabel.Location = new System.Drawing.Point(12, 118);
            this.newItemLabel.Name = "newItemLabel";
            this.newItemLabel.Size = new System.Drawing.Size(89, 13);
            this.newItemLabel.TabIndex = 2;
            this.newItemLabel.Text = "Enter a new item:";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(138, 137);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 3;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(138, 46);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 4;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // clearItemsButton
            // 
            this.clearItemsButton.Location = new System.Drawing.Point(138, 12);
            this.clearItemsButton.Name = "clearItemsButton";
            this.clearItemsButton.Size = new System.Drawing.Size(75, 23);
            this.clearItemsButton.TabIndex = 5;
            this.clearItemsButton.Text = "Clear";
            this.clearItemsButton.UseVisualStyleBackColor = true;
            this.clearItemsButton.Click += new System.EventHandler(this.clearItemsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(138, 84);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateLabel
            // 
            this.calculateLabel.AutoSize = true;
            this.calculateLabel.Location = new System.Drawing.Point(15, 203);
            this.calculateLabel.Name = "calculateLabel";
            this.calculateLabel.Size = new System.Drawing.Size(81, 13);
            this.calculateLabel.TabIndex = 7;
            this.calculateLabel.Text = "Calculate Total:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(138, 203);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // chapter5Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 237);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.calculateLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearItemsButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.newItemLabel);
            this.Controls.Add(this.newItemTextBox);
            this.Controls.Add(this.dynamicListBox);
            this.Name = "chapter5Example";
            this.Text = "Chapter 5 Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dynamicListBox;
        private System.Windows.Forms.TextBox newItemTextBox;
        private System.Windows.Forms.Label newItemLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button clearItemsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label calculateLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

