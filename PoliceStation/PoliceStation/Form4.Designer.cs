namespace PoliceStation
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
            System.Windows.Forms.TextBox policeInventory;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policeInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryTableTableAdapter = new PoliceStation.PoliceStationDataSetTableAdapters.InventoryTableTableAdapter();
            this.removeFilterInventory = new System.Windows.Forms.Button();
            this.printInventory = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            policeInventory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // policeInventory
            // 
            policeInventory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryTableBindingSource, "Police Inventory", true));
            policeInventory.Location = new System.Drawing.Point(23, 123);
            policeInventory.Name = "policeInventory";
            policeInventory.Size = new System.Drawing.Size(164, 26);
            policeInventory.TabIndex = 44;
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
            this.filterInventory.Location = new System.Drawing.Point(26, 811);
            this.filterInventory.Name = "filterInventory";
            this.filterInventory.Size = new System.Drawing.Size(75, 30);
            this.filterInventory.TabIndex = 54;
            this.filterInventory.Text = "Filter";
            this.filterInventory.UseVisualStyleBackColor = true;
            // 
            // sNoFilter
            // 
            this.sNoFilter.Location = new System.Drawing.Point(37, 675);
            this.sNoFilter.Name = "sNoFilter";
            this.sNoFilter.Size = new System.Drawing.Size(164, 26);
            this.sNoFilter.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 638);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Filter by S No";
            // 
            // inventoryTypeFilter
            // 
            this.inventoryTypeFilter.FormattingEnabled = true;
            this.inventoryTypeFilter.Items.AddRange(new object[] {
            "Patrol Division",
            "Investigations Division",
            "Special Operations",
            "Highway Patrol",
            "Community Services",
            "Crime Scene Units",
            "Administrative Division",
            "Internal Affairs"});
            this.inventoryTypeFilter.Location = new System.Drawing.Point(34, 760);
            this.inventoryTypeFilter.Name = "inventoryTypeFilter";
            this.inventoryTypeFilter.Size = new System.Drawing.Size(164, 28);
            this.inventoryTypeFilter.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 727);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Filter by Inventory Type";
            // 
            // saveInventory
            // 
            this.saveInventory.AutoSize = true;
            this.saveInventory.Location = new System.Drawing.Point(124, 447);
            this.saveInventory.Name = "saveInventory";
            this.saveInventory.Size = new System.Drawing.Size(75, 30);
            this.saveInventory.TabIndex = 49;
            this.saveInventory.Text = "Save";
            this.saveInventory.UseVisualStyleBackColor = true;
            this.saveInventory.Click += new System.EventHandler(this.saveInventory_Click);
            // 
            // addInventory
            // 
            this.addInventory.AutoSize = true;
            this.addInventory.Location = new System.Drawing.Point(22, 447);
            this.addInventory.Name = "addInventory";
            this.addInventory.Size = new System.Drawing.Size(75, 30);
            this.addInventory.TabIndex = 48;
            this.addInventory.Text = "Add";
            this.addInventory.UseVisualStyleBackColor = true;
            this.addInventory.Click += new System.EventHandler(this.addInventory_Click);
            // 
            // sNoAdd
            // 
            this.sNoAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryTableBindingSource, "S No", true));
            this.sNoAdd.Location = new System.Drawing.Point(29, 212);
            this.sNoAdd.Name = "sNoAdd";
            this.sNoAdd.Size = new System.Drawing.Size(164, 26);
            this.sNoAdd.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "S No";
            // 
            // quantityAdd
            // 
            this.quantityAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryTableBindingSource, "Quantity", true));
            this.quantityAdd.Location = new System.Drawing.Point(23, 394);
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
            this.departmentAdd.Location = new System.Drawing.Point(26, 297);
            this.departmentAdd.Name = "departmentAdd";
            this.departmentAdd.Size = new System.Drawing.Size(164, 28);
            this.departmentAdd.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Inventory Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Police Inventory";
            // 
            // deleteInventory
            // 
            this.deleteInventory.AutoSize = true;
            this.deleteInventory.Location = new System.Drawing.Point(67, 500);
            this.deleteInventory.Name = "deleteInventory";
            this.deleteInventory.Size = new System.Drawing.Size(75, 30);
            this.deleteInventory.TabIndex = 55;
            this.deleteInventory.Text = "Delete";
            this.deleteInventory.UseVisualStyleBackColor = true;
            this.deleteInventory.Click += new System.EventHandler(this.deleteInventory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNoDataGridViewTextBoxColumn,
            this.policeInventoryDataGridViewTextBoxColumn,
            this.inventoryTypeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(249, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(851, 674);
            this.dataGridView1.TabIndex = 56;
            // 
            // sNoDataGridViewTextBoxColumn
            // 
            this.sNoDataGridViewTextBoxColumn.DataPropertyName = "S No";
            this.sNoDataGridViewTextBoxColumn.HeaderText = "S No";
            this.sNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sNoDataGridViewTextBoxColumn.Name = "sNoDataGridViewTextBoxColumn";
            // 
            // policeInventoryDataGridViewTextBoxColumn
            // 
            this.policeInventoryDataGridViewTextBoxColumn.DataPropertyName = "Police Inventory";
            this.policeInventoryDataGridViewTextBoxColumn.HeaderText = "Police Inventory";
            this.policeInventoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.policeInventoryDataGridViewTextBoxColumn.Name = "policeInventoryDataGridViewTextBoxColumn";
            // 
            // inventoryTypeDataGridViewTextBoxColumn
            // 
            this.inventoryTypeDataGridViewTextBoxColumn.DataPropertyName = "Inventory Type";
            this.inventoryTypeDataGridViewTextBoxColumn.HeaderText = "Inventory Type";
            this.inventoryTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.inventoryTypeDataGridViewTextBoxColumn.Name = "inventoryTypeDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // inventoryTableTableAdapter
            // 
            this.inventoryTableTableAdapter.ClearBeforeFill = true;
            // 
            // removeFilterInventory
            // 
            this.removeFilterInventory.AutoSize = true;
            this.removeFilterInventory.Location = new System.Drawing.Point(107, 811);
            this.removeFilterInventory.Name = "removeFilterInventory";
            this.removeFilterInventory.Size = new System.Drawing.Size(117, 30);
            this.removeFilterInventory.TabIndex = 57;
            this.removeFilterInventory.Text = "Remove Filter";
            this.removeFilterInventory.UseVisualStyleBackColor = true;
            // 
            // printInventory
            // 
            this.printInventory.AutoSize = true;
            this.printInventory.Location = new System.Drawing.Point(1025, 821);
            this.printInventory.Name = "printInventory";
            this.printInventory.Size = new System.Drawing.Size(75, 30);
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
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.shiftsToolStripMenuItem,
            this.casesToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 33);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // shiftsToolStripMenuItem
            // 
            this.shiftsToolStripMenuItem.Name = "shiftsToolStripMenuItem";
            this.shiftsToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.shiftsToolStripMenuItem.Text = "Shifts";
            this.shiftsToolStripMenuItem.Click += new System.EventHandler(this.shiftsToolStripMenuItem_Click);
            // 
            // casesToolStripMenuItem
            // 
            this.casesToolStripMenuItem.Name = "casesToolStripMenuItem";
            this.casesToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.casesToolStripMenuItem.Text = "Cases";
            this.casesToolStripMenuItem.Click += new System.EventHandler(this.casesToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 875);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.printInventory);
            this.Controls.Add(this.removeFilterInventory);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(policeInventory);
            this.Controls.Add(this.departmentAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private PoliceStationDataSet policeStationDataSet;
        private System.Windows.Forms.BindingSource inventoryTableBindingSource;
        private PoliceStationDataSetTableAdapters.InventoryTableTableAdapter inventoryTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policeInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button removeFilterInventory;
        private System.Windows.Forms.Button printInventory;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
    }
}