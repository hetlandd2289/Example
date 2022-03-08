
namespace ACS_Example_InClass_2022
{
    partial class Bruhtha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bruhtha));
            this.bruhBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.ticTacToeBtn = new System.Windows.Forms.Button();
            this.blindManBluffBtn = new System.Windows.Forms.Button();
            this.rpsBtn = new System.Windows.Forms.Button();
            this.brableDataSet = new ACS_Example_InClass_2022.BrableDataSet();
            this.brableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brableTableAdapter = new ACS_Example_InClass_2022.BrableDataSetTableAdapters.BrableTableAdapter();
            this.tableAdapterManager = new ACS_Example_InClass_2022.BrableDataSetTableAdapters.TableAdapterManager();
            this.brableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.brableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.brableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.brableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brableBindingNavigator)).BeginInit();
            this.brableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bruhBtn
            // 
            this.bruhBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bruhBtn.Location = new System.Drawing.Point(12, 283);
            this.bruhBtn.Name = "bruhBtn";
            this.bruhBtn.Size = new System.Drawing.Size(75, 31);
            this.bruhBtn.TabIndex = 0;
            this.bruhBtn.Text = "Bruh";
            this.bruhBtn.UseVisualStyleBackColor = true;
            this.bruhBtn.Click += new System.EventHandler(this.bruhBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(93, 283);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(116, 31);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Close, My Dude";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ticTacToeBtn
            // 
            this.ticTacToeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticTacToeBtn.Location = new System.Drawing.Point(12, 254);
            this.ticTacToeBtn.Name = "ticTacToeBtn";
            this.ticTacToeBtn.Size = new System.Drawing.Size(126, 23);
            this.ticTacToeBtn.TabIndex = 2;
            this.ticTacToeBtn.Text = "Tic Tac Toe, Bro";
            this.ticTacToeBtn.UseVisualStyleBackColor = true;
            this.ticTacToeBtn.Click += new System.EventHandler(this.ticTacToeBtn_Click);
            // 
            // blindManBluffBtn
            // 
            this.blindManBluffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blindManBluffBtn.Location = new System.Drawing.Point(153, 254);
            this.blindManBluffBtn.Name = "blindManBluffBtn";
            this.blindManBluffBtn.Size = new System.Drawing.Size(126, 23);
            this.blindManBluffBtn.TabIndex = 3;
            this.blindManBluffBtn.Text = "Blind, Bro";
            this.blindManBluffBtn.UseVisualStyleBackColor = true;
            this.blindManBluffBtn.Click += new System.EventHandler(this.blindManBluffBtn_Click);
            // 
            // rpsBtn
            // 
            this.rpsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpsBtn.Location = new System.Drawing.Point(285, 254);
            this.rpsBtn.Name = "rpsBtn";
            this.rpsBtn.Size = new System.Drawing.Size(126, 23);
            this.rpsBtn.TabIndex = 4;
            this.rpsBtn.Text = "RPS, Bro";
            this.rpsBtn.UseVisualStyleBackColor = true;
            this.rpsBtn.Click += new System.EventHandler(this.rpsBtn_Click);
            // 
            // brableDataSet
            // 
            this.brableDataSet.DataSetName = "BrableDataSet";
            this.brableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brableBindingSource
            // 
            this.brableBindingSource.DataMember = "Brable";
            this.brableBindingSource.DataSource = this.brableDataSet;
            // 
            // brableTableAdapter
            // 
            this.brableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrableTableAdapter = this.brableTableAdapter;
            this.tableAdapterManager.UpdateOrder = ACS_Example_InClass_2022.BrableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // brableBindingNavigator
            // 
            this.brableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.brableBindingNavigator.BindingSource = this.brableBindingSource;
            this.brableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.brableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.brableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.brableBindingNavigatorSaveItem});
            this.brableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.brableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.brableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.brableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.brableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.brableBindingNavigator.Name = "brableBindingNavigator";
            this.brableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.brableBindingNavigator.Size = new System.Drawing.Size(643, 25);
            this.brableBindingNavigator.TabIndex = 5;
            this.brableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // brableBindingNavigatorSaveItem
            // 
            this.brableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("brableBindingNavigatorSaveItem.Image")));
            this.brableBindingNavigatorSaveItem.Name = "brableBindingNavigatorSaveItem";
            this.brableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.brableBindingNavigatorSaveItem.Text = "Save Data";
            this.brableBindingNavigatorSaveItem.Click += new System.EventHandler(this.brableBindingNavigatorSaveItem_Click);
            // 
            // brableDataGridView
            // 
            this.brableDataGridView.AutoGenerateColumns = false;
            this.brableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.brableDataGridView.DataSource = this.brableBindingSource;
            this.brableDataGridView.Location = new System.Drawing.Point(0, 28);
            this.brableDataGridView.Name = "brableDataGridView";
            this.brableDataGridView.Size = new System.Drawing.Size(643, 220);
            this.brableDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Brunk";
            this.dataGridViewTextBoxColumn1.HeaderText = "Brunk";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Bruh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Bruh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mutha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mutha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fatha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fatha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Suga";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Suga";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Homebois";
            this.dataGridViewTextBoxColumn5.HeaderText = "Homebois";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Bruhtha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 322);
            this.Controls.Add(this.brableDataGridView);
            this.Controls.Add(this.brableBindingNavigator);
            this.Controls.Add(this.rpsBtn);
            this.Controls.Add(this.blindManBluffBtn);
            this.Controls.Add(this.ticTacToeBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.bruhBtn);
            this.Name = "Bruhtha";
            this.Text = "Bruhtha";
            this.Load += new System.EventHandler(this.Bruhtha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brableBindingNavigator)).EndInit();
            this.brableBindingNavigator.ResumeLayout(false);
            this.brableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bruhBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button ticTacToeBtn;
        private System.Windows.Forms.Button blindManBluffBtn;
        private System.Windows.Forms.Button rpsBtn;
        private BrableDataSet brableDataSet;
        private System.Windows.Forms.BindingSource brableBindingSource;
        private BrableDataSetTableAdapters.BrableTableAdapter brableTableAdapter;
        private BrableDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator brableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton brableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView brableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}