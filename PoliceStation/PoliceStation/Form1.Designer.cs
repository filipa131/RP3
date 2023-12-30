namespace PoliceStation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveEmployee = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.idAdd = new System.Windows.Forms.TextBox();
            this.employeesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeStationDataSet = new PoliceStation.PoliceStationDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.hourlyRate = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.departmentAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filterEmployee = new System.Windows.Forms.Button();
            this.idFilter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.departmentFilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesTableTableAdapter = new PoliceStation.PoliceStationDataSetTableAdapters.EmployeesTableTableAdapter();
            this.removeFilterEmployees = new System.Windows.Forms.Button();
            this.printEmployees = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveEmployee
            // 
            this.saveEmployee.AutoSize = true;
            this.saveEmployee.Location = new System.Drawing.Point(133, 507);
            this.saveEmployee.Name = "saveEmployee";
            this.saveEmployee.Size = new System.Drawing.Size(75, 30);
            this.saveEmployee.TabIndex = 26;
            this.saveEmployee.Text = "Save";
            this.saveEmployee.UseVisualStyleBackColor = true;
            this.saveEmployee.Click += new System.EventHandler(this.saveEmployee_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.AutoSize = true;
            this.addEmployee.Location = new System.Drawing.Point(31, 507);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(75, 30);
            this.addEmployee.TabIndex = 25;
            this.addEmployee.Text = "Add";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // idAdd
            // 
            this.idAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "ID", true));
            this.idAdd.Location = new System.Drawing.Point(34, 191);
            this.idAdd.Name = "idAdd";
            this.idAdd.Size = new System.Drawing.Size(164, 26);
            this.idAdd.TabIndex = 24;
            // 
            // employeesTableBindingSource
            // 
            this.employeesTableBindingSource.DataMember = "EmployeesTable";
            this.employeesTableBindingSource.DataSource = this.policeStationDataSet;
            // 
            // policeStationDataSet
            // 
            this.policeStationDataSet.DataSetName = "PoliceStationDataSet";
            this.policeStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "ID";
            // 
            // hourlyRate
            // 
            this.hourlyRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Hourly Rate", true));
            this.hourlyRate.Location = new System.Drawing.Point(32, 454);
            this.hourlyRate.Name = "hourlyRate";
            this.hourlyRate.Size = new System.Drawing.Size(164, 26);
            this.hourlyRate.TabIndex = 22;
            // 
            // name
            // 
            this.name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Name", true));
            this.name.Location = new System.Drawing.Point(30, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(164, 26);
            this.name.TabIndex = 21;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Date of Birth", true));
            this.dateOfBirth.Location = new System.Drawing.Point(33, 360);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(200, 26);
            this.dateOfBirth.TabIndex = 20;
            // 
            // departmentAdd
            // 
            this.departmentAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesTableBindingSource, "Department", true));
            this.departmentAdd.FormattingEnabled = true;
            this.departmentAdd.Items.AddRange(new object[] {
            "Patrol Division",
            "Investigations Division",
            "Special Operations",
            "Highway Patrol",
            "Community Services",
            "Crime Scene Units",
            "Administrative Division",
            "Internal Affairs"});
            this.departmentAdd.Location = new System.Drawing.Point(31, 276);
            this.departmentAdd.Name = "departmentAdd";
            this.departmentAdd.Size = new System.Drawing.Size(164, 28);
            this.departmentAdd.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hourly Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // filterEmployee
            // 
            this.filterEmployee.AutoSize = true;
            this.filterEmployee.Location = new System.Drawing.Point(30, 797);
            this.filterEmployee.Name = "filterEmployee";
            this.filterEmployee.Size = new System.Drawing.Size(75, 30);
            this.filterEmployee.TabIndex = 31;
            this.filterEmployee.Text = "Filter";
            this.filterEmployee.UseVisualStyleBackColor = true;
            this.filterEmployee.Click += new System.EventHandler(this.filterEmployee_Click);
            // 
            // idFilter
            // 
            this.idFilter.Location = new System.Drawing.Point(35, 665);
            this.idFilter.Name = "idFilter";
            this.idFilter.Size = new System.Drawing.Size(164, 26);
            this.idFilter.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Filter by ID";
            // 
            // departmentFilter
            // 
            this.departmentFilter.FormattingEnabled = true;
            this.departmentFilter.Items.AddRange(new object[] {
            "Patrol Division",
            "Investigations Division",
            "Special Operations",
            "Highway Patrol",
            "Community Services",
            "Crime Scene Units",
            "Administrative Division",
            "Internal Affairs"});
            this.departmentFilter.Location = new System.Drawing.Point(35, 746);
            this.departmentFilter.Name = "departmentFilter";
            this.departmentFilter.Size = new System.Drawing.Size(164, 28);
            this.departmentFilter.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 713);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Filter by Department";
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.AutoSize = true;
            this.deleteEmployee.Location = new System.Drawing.Point(76, 558);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(75, 30);
            this.deleteEmployee.TabIndex = 34;
            this.deleteEmployee.Text = "Delete";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.hourlyRateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(289, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(844, 676);
            this.dataGridView1.TabIndex = 35;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // hourlyRateDataGridViewTextBoxColumn
            // 
            this.hourlyRateDataGridViewTextBoxColumn.DataPropertyName = "Hourly Rate";
            this.hourlyRateDataGridViewTextBoxColumn.HeaderText = "Hourly Rate";
            this.hourlyRateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hourlyRateDataGridViewTextBoxColumn.Name = "hourlyRateDataGridViewTextBoxColumn";
            // 
            // employeesTableTableAdapter
            // 
            this.employeesTableTableAdapter.ClearBeforeFill = true;
            // 
            // removeFilterEmployees
            // 
            this.removeFilterEmployees.AutoSize = true;
            this.removeFilterEmployees.Location = new System.Drawing.Point(116, 797);
            this.removeFilterEmployees.Name = "removeFilterEmployees";
            this.removeFilterEmployees.Size = new System.Drawing.Size(117, 30);
            this.removeFilterEmployees.TabIndex = 36;
            this.removeFilterEmployees.Text = "Remove Filter";
            this.removeFilterEmployees.UseVisualStyleBackColor = true;
            // 
            // printEmployees
            // 
            this.printEmployees.AutoSize = true;
            this.printEmployees.Location = new System.Drawing.Point(1058, 797);
            this.printEmployees.Name = "printEmployees";
            this.printEmployees.Size = new System.Drawing.Size(75, 30);
            this.printEmployees.TabIndex = 59;
            this.printEmployees.Text = "Print";
            this.printEmployees.UseVisualStyleBackColor = true;
            this.printEmployees.Click += new System.EventHandler(this.printEmployees_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1160, 33);
            this.menuStrip1.TabIndex = 60;
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
            this.shiftsToolStripMenuItem.Click += new System.EventHandler(this.shiftsToolStripMenuItem_Click_1);
            // 
            // casesToolStripMenuItem
            // 
            this.casesToolStripMenuItem.Name = "casesToolStripMenuItem";
            this.casesToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.casesToolStripMenuItem.Text = "Cases";
            this.casesToolStripMenuItem.Click += new System.EventHandler(this.casesToolStripMenuItem_Click_1);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 850);
            this.Controls.Add(this.printEmployees);
            this.Controls.Add(this.removeFilterEmployees);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.filterEmployee);
            this.Controls.Add(this.idFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.departmentFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveEmployee);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.idAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hourlyRate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.departmentAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveEmployee;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.TextBox idAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hourlyRate;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.ComboBox departmentAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filterEmployee;
        private System.Windows.Forms.TextBox idFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox departmentFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PoliceStationDataSetTableAdapters.EmployeesTableTableAdapter employeesTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeesTableBindingSource;
        private PoliceStationDataSet policeStationDataSet;
        private System.Windows.Forms.Button removeFilterEmployees;
        private System.Windows.Forms.Button printEmployees;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
    }
}

