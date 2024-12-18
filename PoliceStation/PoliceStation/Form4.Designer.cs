﻿namespace PoliceStation
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.policeInventory = new System.Windows.Forms.TextBox();
            this.inventoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeStationDataSet = new PoliceStation.PoliceStationDataSet();
            this.filterInventory = new System.Windows.Forms.Button();
            this.sNoFilter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inventoryTypeFilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveInventory = new System.Windows.Forms.Button();
            this.addInventory = new System.Windows.Forms.Button();
            this.sNoAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityAdd = new System.Windows.Forms.TextBox();
            this.departmentAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteInventory = new System.Windows.Forms.Button();
            this.removeFilterInventory = new System.Windows.Forms.Button();
            this.printInventory = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.sortInventory = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policeInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryTableTableAdapter = new PoliceStation.PoliceStationDataSetTableAdapters.InventoryTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // policeInventory
            // 
            this.policeInventory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryTableBindingSource, "Police Inventory", true));
            this.policeInventory.Location = new System.Drawing.Point(34, 344);
            this.policeInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.policeInventory.Name = "policeInventory";
            this.policeInventory.Size = new System.Drawing.Size(164, 26);
            this.policeInventory.TabIndex = 44;
            // 
            // inventoryTableBindingSource
            // 
            this.inventoryTableBindingSource.DataMember = "InventoryTable";
            this.inventoryTableBindingSource.DataSource = this.policeStationDataSet;
            // 
            // policeStationDataSet
            // 
            this.policeStationDataSet.DataSetName = "PoliceStationDataSet";
            this.policeStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filterInventory
            // 
            this.filterInventory.AutoSize = true;
            this.filterInventory.Location = new System.Drawing.Point(29, 993);
            this.filterInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterInventory.Name = "filterInventory";
            this.filterInventory.Size = new System.Drawing.Size(75, 32);
            this.filterInventory.TabIndex = 54;
            this.filterInventory.Text = "Filter";
            this.filterInventory.UseVisualStyleBackColor = true;
            this.filterInventory.Click += new System.EventHandler(this.filterInventory_Click);
            // 
            // sNoFilter
            // 
            this.sNoFilter.Location = new System.Drawing.Point(37, 843);
            this.sNoFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sNoFilter.Name = "sNoFilter";
            this.sNoFilter.Size = new System.Drawing.Size(164, 26);
            this.sNoFilter.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(34, 806);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 52;
            this.label7.Text = "Filter by S No";
            // 
            // inventoryTypeFilter
            // 
            this.inventoryTypeFilter.FormattingEnabled = true;
            this.inventoryTypeFilter.Items.AddRange(new object[] {
            "Weapons and Ammunition",
            "Communication Devices",
            "Protective Gear",
            "Vehicles",
            "Technology and Tools",
            "Office Supplies",
            "Training Equipment",
            "Medical Supplies",
            "Miscellaneous"});
            this.inventoryTypeFilter.Location = new System.Drawing.Point(34, 928);
            this.inventoryTypeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryTypeFilter.Name = "inventoryTypeFilter";
            this.inventoryTypeFilter.Size = new System.Drawing.Size(164, 28);
            this.inventoryTypeFilter.TabIndex = 51;
            this.inventoryTypeFilter.SelectedIndexChanged += new System.EventHandler(this.inventoryTypeFilter_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(30, 896);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 22);
            this.label8.TabIndex = 50;
            this.label8.Text = "Filter by Inventory Type";
            // 
            // saveInventory
            // 
            this.saveInventory.AutoSize = true;
            this.saveInventory.Location = new System.Drawing.Point(136, 670);
            this.saveInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveInventory.Name = "saveInventory";
            this.saveInventory.Size = new System.Drawing.Size(75, 32);
            this.saveInventory.TabIndex = 49;
            this.saveInventory.Text = "Save";
            this.saveInventory.UseVisualStyleBackColor = true;
            this.saveInventory.Click += new System.EventHandler(this.saveInventory_Click);
            // 
            // addInventory
            // 
            this.addInventory.AutoSize = true;
            this.addInventory.Location = new System.Drawing.Point(34, 670);
            this.addInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addInventory.Name = "addInventory";
            this.addInventory.Size = new System.Drawing.Size(75, 32);
            this.addInventory.TabIndex = 48;
            this.addInventory.Text = "Add";
            this.addInventory.UseVisualStyleBackColor = true;
            this.addInventory.Click += new System.EventHandler(this.addInventory_Click);
            // 
            // sNoAdd
            // 
            this.sNoAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryTableBindingSource, "S No", true));
            this.sNoAdd.Location = new System.Drawing.Point(41, 434);
            this.sNoAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sNoAdd.Name = "sNoAdd";
            this.sNoAdd.Size = new System.Drawing.Size(164, 26);
            this.sNoAdd.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(38, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "S No";
            // 
            // quantityAdd
            // 
            this.quantityAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryTableBindingSource, "Quantity", true));
            this.quantityAdd.Location = new System.Drawing.Point(34, 616);
            this.quantityAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityAdd.Name = "quantityAdd";
            this.quantityAdd.Size = new System.Drawing.Size(164, 26);
            this.quantityAdd.TabIndex = 45;
            // 
            // departmentAdd
            // 
            this.departmentAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryTableBindingSource, "Inventory Type", true));
            this.departmentAdd.FormattingEnabled = true;
            this.departmentAdd.Items.AddRange(new object[] {
            "Weapons and Ammunition",
            "Communication Devices",
            "Protective Gear",
            "Vehicles",
            "Technology and Tools",
            "Office Supplies",
            "Training Equipment",
            "Medical Supplies",
            "Miscellaneous"});
            this.departmentAdd.Location = new System.Drawing.Point(38, 520);
            this.departmentAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentAdd.Name = "departmentAdd";
            this.departmentAdd.Size = new System.Drawing.Size(164, 28);
            this.departmentAdd.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(34, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(34, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Inventory Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(34, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Police Inventory";
            // 
            // deleteInventory
            // 
            this.deleteInventory.AutoSize = true;
            this.deleteInventory.Location = new System.Drawing.Point(80, 722);
            this.deleteInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteInventory.Name = "deleteInventory";
            this.deleteInventory.Size = new System.Drawing.Size(75, 32);
            this.deleteInventory.TabIndex = 55;
            this.deleteInventory.Text = "Delete";
            this.deleteInventory.UseVisualStyleBackColor = true;
            this.deleteInventory.Click += new System.EventHandler(this.deleteInventory_Click);
            // 
            // removeFilterInventory
            // 
            this.removeFilterInventory.AutoSize = true;
            this.removeFilterInventory.Location = new System.Drawing.Point(111, 993);
            this.removeFilterInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeFilterInventory.Name = "removeFilterInventory";
            this.removeFilterInventory.Size = new System.Drawing.Size(117, 32);
            this.removeFilterInventory.TabIndex = 57;
            this.removeFilterInventory.Text = "Remove Filter";
            this.removeFilterInventory.UseVisualStyleBackColor = true;
            this.removeFilterInventory.Click += new System.EventHandler(this.removeFilterInventory_Click);
            // 
            // printInventory
            // 
            this.printInventory.AutoSize = true;
            this.printInventory.Location = new System.Drawing.Point(1189, 993);
            this.printInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printInventory.Name = "printInventory";
            this.printInventory.Size = new System.Drawing.Size(75, 32);
            this.printInventory.TabIndex = 58;
            this.printInventory.Text = "Print";
            this.printInventory.UseVisualStyleBackColor = true;
            this.printInventory.Click += new System.EventHandler(this.printInventory_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(276, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 64;
            this.label6.Text = "Sort";
            // 
            // sortInventory
            // 
            this.sortInventory.FormattingEnabled = true;
            this.sortInventory.Items.AddRange(new object[] {
            "Police Inventory",
            "S No",
            "Inventory Type",
            "Quantity"});
            this.sortInventory.Location = new System.Drawing.Point(331, 239);
            this.sortInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortInventory.Name = "sortInventory";
            this.sortInventory.Size = new System.Drawing.Size(121, 28);
            this.sortInventory.TabIndex = 63;
            this.sortInventory.SelectedIndexChanged += new System.EventHandler(this.sortInventory_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNoDataGridViewTextBoxColumn,
            this.policeInventoryDataGridViewTextBoxColumn,
            this.inventoryTypeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(280, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(985, 700);
            this.dataGridView1.TabIndex = 65;
            // 
            // sNoDataGridViewTextBoxColumn
            // 
            this.sNoDataGridViewTextBoxColumn.DataPropertyName = "S No";
            this.sNoDataGridViewTextBoxColumn.HeaderText = "S No";
            this.sNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sNoDataGridViewTextBoxColumn.Name = "sNoDataGridViewTextBoxColumn";
            this.sNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // policeInventoryDataGridViewTextBoxColumn
            // 
            this.policeInventoryDataGridViewTextBoxColumn.DataPropertyName = "Police Inventory";
            this.policeInventoryDataGridViewTextBoxColumn.HeaderText = "Police Inventory";
            this.policeInventoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.policeInventoryDataGridViewTextBoxColumn.Name = "policeInventoryDataGridViewTextBoxColumn";
            this.policeInventoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.policeInventoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // inventoryTypeDataGridViewTextBoxColumn
            // 
            this.inventoryTypeDataGridViewTextBoxColumn.DataPropertyName = "Inventory Type";
            this.inventoryTypeDataGridViewTextBoxColumn.HeaderText = "Inventory Type";
            this.inventoryTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.inventoryTypeDataGridViewTextBoxColumn.Name = "inventoryTypeDataGridViewTextBoxColumn";
            this.inventoryTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.inventoryTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // inventoryTableTableAdapter
            // 
            this.inventoryTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1278, 1044);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sortInventory);
            this.Controls.Add(this.printInventory);
            this.Controls.Add(this.removeFilterInventory);
            this.Controls.Add(this.deleteInventory);
            this.Controls.Add(this.filterInventory);
            this.Controls.Add(this.sNoFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inventoryTypeFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveInventory);
            this.Controls.Add(this.addInventory);
            this.Controls.Add(this.sNoAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantityAdd);
            this.Controls.Add(this.policeInventory);
            this.Controls.Add(this.departmentAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterInventory;
        private System.Windows.Forms.TextBox sNoFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox inventoryTypeFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveInventory;
        private System.Windows.Forms.Button addInventory;
        private System.Windows.Forms.TextBox sNoAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityAdd;
        private System.Windows.Forms.ComboBox departmentAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteInventory;
        private System.Windows.Forms.Button removeFilterInventory;
        private System.Windows.Forms.Button printInventory;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sortInventory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PoliceStationDataSet policeStationDataSet;
        private System.Windows.Forms.BindingSource inventoryTableBindingSource;
        private PoliceStationDataSetTableAdapters.InventoryTableTableAdapter inventoryTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policeInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox policeInventory;
    }
}