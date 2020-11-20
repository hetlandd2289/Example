namespace joesAutomotive
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
            this.oilLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.partsLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.partsLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.partsSummaryLabel = new System.Windows.Forms.Label();
            this.taxPartsLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.serviceTextBox = new System.Windows.Forms.TextBox();
            this.partsSummaryTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilLubeGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsLaborGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilLubeGroupBox
            // 
            this.oilLubeGroupBox.Controls.Add(this.lubeJobCheckBox);
            this.oilLubeGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilLubeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.oilLubeGroupBox.Name = "oilLubeGroupBox";
            this.oilLubeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.oilLubeGroupBox.TabIndex = 0;
            this.oilLubeGroupBox.TabStop = false;
            this.oilLubeGroupBox.Text = "Oil and Lube";
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.Controls.Add(this.transmissionFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiatorFlushCheckBox);
            this.flushesGroupBox.Location = new System.Drawing.Point(218, 12);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.flushesGroupBox.TabIndex = 1;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "Flushes";
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.replaceMufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(12, 118);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(200, 100);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // partsLaborGroupBox
            // 
            this.partsLaborGroupBox.Controls.Add(this.laborTextBox);
            this.partsLaborGroupBox.Controls.Add(this.partsTextBox);
            this.partsLaborGroupBox.Controls.Add(this.laborLabel);
            this.partsLaborGroupBox.Controls.Add(this.partsLabel);
            this.partsLaborGroupBox.Location = new System.Drawing.Point(218, 118);
            this.partsLaborGroupBox.Name = "partsLaborGroupBox";
            this.partsLaborGroupBox.Size = new System.Drawing.Size(200, 100);
            this.partsLaborGroupBox.TabIndex = 3;
            this.partsLaborGroupBox.TabStop = false;
            this.partsLaborGroupBox.Text = "Parts and Labor";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalTextBox);
            this.summaryGroupBox.Controls.Add(this.taxTextBox);
            this.summaryGroupBox.Controls.Add(this.partsSummaryTextBox);
            this.summaryGroupBox.Controls.Add(this.serviceTextBox);
            this.summaryGroupBox.Controls.Add(this.totalLabel);
            this.summaryGroupBox.Controls.Add(this.taxPartsLabel);
            this.summaryGroupBox.Controls.Add(this.partsSummaryLabel);
            this.summaryGroupBox.Controls.Add(this.serviceLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(12, 224);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(406, 130);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(7, 20);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(117, 17);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "Oil Change($26.00)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(7, 43);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(109, 17);
            this.lubeJobCheckBox.TabIndex = 1;
            this.lubeJobCheckBox.Text = "Lube Job($18.00)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(6, 19);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(133, 17);
            this.radiatorFlushCheckBox.TabIndex = 1;
            this.radiatorFlushCheckBox.Text = "Radiator Flush($30.00)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(6, 43);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(154, 17);
            this.transmissionFlushCheckBox.TabIndex = 2;
            this.transmissionFlushCheckBox.Text = "Transmission Flush($80.00)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(7, 19);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(114, 17);
            this.inspectionCheckBox.TabIndex = 1;
            this.inspectionCheckBox.Text = "Inspection($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(7, 42);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(146, 17);
            this.replaceMufflerCheckBox.TabIndex = 2;
            this.replaceMufflerCheckBox.Text = "Replace Muffler($100.00)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(7, 65);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(126, 17);
            this.tireRotationCheckBox.TabIndex = 3;
            this.tireRotationCheckBox.Text = "Tire Rotation($20.00)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(7, 20);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(31, 13);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts";
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(7, 48);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(49, 13);
            this.laborLabel.TabIndex = 1;
            this.laborLabel.Text = "Labor ($)";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Location = new System.Drawing.Point(6, 34);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(94, 13);
            this.serviceLabel.TabIndex = 1;
            this.serviceLabel.Text = "Service and Labor";
            // 
            // partsSummaryLabel
            // 
            this.partsSummaryLabel.AutoSize = true;
            this.partsSummaryLabel.Location = new System.Drawing.Point(69, 57);
            this.partsSummaryLabel.Name = "partsSummaryLabel";
            this.partsSummaryLabel.Size = new System.Drawing.Size(31, 13);
            this.partsSummaryLabel.TabIndex = 2;
            this.partsSummaryLabel.Text = "Parts";
            // 
            // taxPartsLabel
            // 
            this.taxPartsLabel.AutoSize = true;
            this.taxPartsLabel.Location = new System.Drawing.Point(25, 79);
            this.taxPartsLabel.Name = "taxPartsLabel";
            this.taxPartsLabel.Size = new System.Drawing.Size(75, 13);
            this.taxPartsLabel.TabIndex = 3;
            this.taxPartsLabel.Text = "Tax (On Parts)";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(43, 102);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(57, 13);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total Fees";
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(85, 19);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsTextBox.TabIndex = 2;
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(85, 45);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(100, 20);
            this.laborTextBox.TabIndex = 3;
            // 
            // serviceTextBox
            // 
            this.serviceTextBox.Location = new System.Drawing.Point(120, 31);
            this.serviceTextBox.Name = "serviceTextBox";
            this.serviceTextBox.ReadOnly = true;
            this.serviceTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceTextBox.TabIndex = 5;
            // 
            // partsSummaryTextBox
            // 
            this.partsSummaryTextBox.Location = new System.Drawing.Point(120, 54);
            this.partsSummaryTextBox.Name = "partsSummaryTextBox";
            this.partsSummaryTextBox.ReadOnly = true;
            this.partsSummaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsSummaryTextBox.TabIndex = 6;
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(120, 76);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.ReadOnly = true;
            this.taxTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxTextBox.TabIndex = 7;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(120, 99);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 360);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(172, 360);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(343, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 391);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.partsLaborGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.oilLubeGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.oilLubeGroupBox.ResumeLayout(false);
            this.oilLubeGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsLaborGroupBox.ResumeLayout(false);
            this.partsLaborGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilLubeGroupBox;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox partsLaborGroupBox;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox partsSummaryTextBox;
        private System.Windows.Forms.TextBox serviceTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxPartsLabel;
        private System.Windows.Forms.Label partsSummaryLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

