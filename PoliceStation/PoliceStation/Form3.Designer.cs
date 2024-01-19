namespace PoliceStation
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.No = new System.Windows.Forms.TextBox();
            this.casesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeStationDataSet = new PoliceStation.PoliceStationDataSet();
            this.description = new System.Windows.Forms.TextBox();
            this.dateShift = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteShift = new System.Windows.Forms.Button();
            this.saveShift = new System.Windows.Forms.Button();
            this.addShift = new System.Windows.Forms.Button();
            this.typeOfCase = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.typeOfCaseFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.printCases = new System.Windows.Forms.Button();
            this.removeFilterCases = new System.Windows.Forms.Button();
            this.filterCases = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.sortCases = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.noFilter = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfModificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casesTableTableAdapter = new PoliceStation.PoliceStationDataSetTableAdapters.CasesTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.casesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // No
            // 
            this.No.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casesTableBindingSource, "No", true));
            this.No.Location = new System.Drawing.Point(29, 180);
            this.No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(164, 26);
            this.No.TabIndex = 72;
            // 
            // casesTableBindingSource
            // 
            this.casesTableBindingSource.DataMember = "CasesTable";
            this.casesTableBindingSource.DataSource = this.policeStationDataSet;
            // 
            // policeStationDataSet
            // 
            this.policeStationDataSet.DataSetName = "PoliceStationDataSet";
            this.policeStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // description
            // 
            this.description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casesTableBindingSource, "Description", true));
            this.description.Location = new System.Drawing.Point(35, 442);
            this.description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(164, 26);
            this.description.TabIndex = 81;
            // 
            // dateShift
            // 
            this.dateShift.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casesTableBindingSource, "Date of Modification", true));
            this.dateShift.Location = new System.Drawing.Point(38, 541);
            this.dateShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateShift.Name = "dateShift";
            this.dateShift.Size = new System.Drawing.Size(200, 26);
            this.dateShift.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(34, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 76;
            this.label3.Text = "Date of Modification";
            // 
            // deleteShift
            // 
            this.deleteShift.AutoSize = true;
            this.deleteShift.Location = new System.Drawing.Point(83, 664);
            this.deleteShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteShift.Name = "deleteShift";
            this.deleteShift.Size = new System.Drawing.Size(75, 32);
            this.deleteShift.TabIndex = 75;
            this.deleteShift.Text = "Delete";
            this.deleteShift.UseVisualStyleBackColor = true;
            this.deleteShift.Click += new System.EventHandler(this.deleteShift_Click);
            // 
            // saveShift
            // 
            this.saveShift.AutoSize = true;
            this.saveShift.Location = new System.Drawing.Point(140, 612);
            this.saveShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveShift.Name = "saveShift";
            this.saveShift.Size = new System.Drawing.Size(75, 32);
            this.saveShift.TabIndex = 74;
            this.saveShift.Text = "Save";
            this.saveShift.UseVisualStyleBackColor = true;
            this.saveShift.Click += new System.EventHandler(this.saveShift_Click);
            // 
            // addShift
            // 
            this.addShift.AutoSize = true;
            this.addShift.Location = new System.Drawing.Point(38, 612);
            this.addShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addShift.Name = "addShift";
            this.addShift.Size = new System.Drawing.Size(75, 32);
            this.addShift.TabIndex = 73;
            this.addShift.Text = "Add";
            this.addShift.UseVisualStyleBackColor = true;
            this.addShift.Click += new System.EventHandler(this.addShift_Click);
            // 
            // typeOfCase
            // 
            this.typeOfCase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casesTableBindingSource, "Type of Case", true));
            this.typeOfCase.FormattingEnabled = true;
            this.typeOfCase.Items.AddRange(new object[] {
            "Violent Crimes",
            "Property Crimes",
            "Drug-Related Offenses",
            "Domestic Violence",
            "Sexual Crimes",
            "Traffic Violations",
            "Cyber Crimes",
            "Missing Persons",
            "Public Order Offenses"});
            this.typeOfCase.Location = new System.Drawing.Point(32, 263);
            this.typeOfCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfCase.Name = "typeOfCase";
            this.typeOfCase.Size = new System.Drawing.Size(164, 28);
            this.typeOfCase.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(28, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 70;
            this.label2.Text = "Type of Case";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(28, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "No";
            // 
            // status
            // 
            this.status.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casesTableBindingSource, "Status", true));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Reopened",
            "Pending",
            "Cleared",
            "Administrative Closure",
            "Pending Prosecution",
            "Awaiting Trial",
            "Solved"});
            this.status.Location = new System.Drawing.Point(35, 348);
            this.status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(164, 28);
            this.status.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(31, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 78;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(34, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 80;
            this.label5.Text = "Description";
            // 
            // statusFilter
            // 
            this.statusFilter.FormattingEnabled = true;
            this.statusFilter.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Reopened",
            "Pending",
            "Cleared",
            "Administrative Closure",
            "Pending Prosecution",
            "Awaiting Trial",
            "Solved"});
            this.statusFilter.Location = new System.Drawing.Point(32, 928);
            this.statusFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusFilter.Name = "statusFilter";
            this.statusFilter.Size = new System.Drawing.Size(164, 28);
            this.statusFilter.TabIndex = 87;
            this.statusFilter.SelectedIndexChanged += new System.EventHandler(this.statusFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(28, 891);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 86;
            this.label6.Text = "Filter by Status";
            // 
            // typeOfCaseFilter
            // 
            this.typeOfCaseFilter.FormattingEnabled = true;
            this.typeOfCaseFilter.Items.AddRange(new object[] {
            "Violent Crimes",
            "Property Crimes",
            "Drug-Related Offenses",
            "Domestic Violence",
            "Sexual Crimes",
            "Traffic Violations",
            "Cyber Crimes",
            "Missing Persons",
            "Public Order Offenses"});
            this.typeOfCaseFilter.Location = new System.Drawing.Point(35, 848);
            this.typeOfCaseFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfCaseFilter.Name = "typeOfCaseFilter";
            this.typeOfCaseFilter.Size = new System.Drawing.Size(164, 28);
            this.typeOfCaseFilter.TabIndex = 84;
            this.typeOfCaseFilter.SelectedIndexChanged += new System.EventHandler(this.typeOfCaseFilter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(25, 807);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 22);
            this.label7.TabIndex = 83;
            this.label7.Text = "Filter by Type of Case";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(25, 719);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 22);
            this.label8.TabIndex = 82;
            this.label8.Text = "Filter by No";
            // 
            // printCases
            // 
            this.printCases.AutoSize = true;
            this.printCases.Location = new System.Drawing.Point(1189, 993);
            this.printCases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printCases.Name = "printCases";
            this.printCases.Size = new System.Drawing.Size(75, 32);
            this.printCases.TabIndex = 88;
            this.printCases.Text = "Print";
            this.printCases.UseVisualStyleBackColor = true;
            this.printCases.Click += new System.EventHandler(this.printCases_Click);
            // 
            // removeFilterCases
            // 
            this.removeFilterCases.AutoSize = true;
            this.removeFilterCases.Location = new System.Drawing.Point(111, 993);
            this.removeFilterCases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeFilterCases.Name = "removeFilterCases";
            this.removeFilterCases.Size = new System.Drawing.Size(117, 32);
            this.removeFilterCases.TabIndex = 91;
            this.removeFilterCases.Text = "Remove Filter";
            this.removeFilterCases.UseVisualStyleBackColor = true;
            this.removeFilterCases.Click += new System.EventHandler(this.removeFilterCases_Click);
            // 
            // filterCases
            // 
            this.filterCases.AutoSize = true;
            this.filterCases.Location = new System.Drawing.Point(29, 993);
            this.filterCases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterCases.Name = "filterCases";
            this.filterCases.Size = new System.Drawing.Size(75, 32);
            this.filterCases.TabIndex = 90;
            this.filterCases.Text = "Filter";
            this.filterCases.UseVisualStyleBackColor = true;
            this.filterCases.Click += new System.EventHandler(this.filterCases_Click);
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
            // sortCases
            // 
            this.sortCases.FormattingEnabled = true;
            this.sortCases.Items.AddRange(new object[] {
            "No",
            "Type of Case",
            "Status",
            "Date of Modification"});
            this.sortCases.Location = new System.Drawing.Point(331, 239);
            this.sortCases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortCases.Name = "sortCases";
            this.sortCases.Size = new System.Drawing.Size(121, 28);
            this.sortCases.TabIndex = 95;
            this.sortCases.SelectedIndexChanged += new System.EventHandler(this.sortCases_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(276, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 22);
            this.label9.TabIndex = 94;
            this.label9.Text = "Sort";
            // 
            // noFilter
            // 
            this.noFilter.Location = new System.Drawing.Point(35, 761);
            this.noFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noFilter.Name = "noFilter";
            this.noFilter.Size = new System.Drawing.Size(164, 26);
            this.noFilter.TabIndex = 96;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.typeOfCaseDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateOfModificationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.casesTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(280, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(985, 700);
            this.dataGridView1.TabIndex = 97;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // typeOfCaseDataGridViewTextBoxColumn
            // 
            this.typeOfCaseDataGridViewTextBoxColumn.DataPropertyName = "Type of Case";
            this.typeOfCaseDataGridViewTextBoxColumn.HeaderText = "Type of Case";
            this.typeOfCaseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeOfCaseDataGridViewTextBoxColumn.Name = "typeOfCaseDataGridViewTextBoxColumn";
            this.typeOfCaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeOfCaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateOfModificationDataGridViewTextBoxColumn
            // 
            this.dateOfModificationDataGridViewTextBoxColumn.DataPropertyName = "Date of Modification";
            this.dateOfModificationDataGridViewTextBoxColumn.HeaderText = "Date of Modification";
            this.dateOfModificationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfModificationDataGridViewTextBoxColumn.Name = "dateOfModificationDataGridViewTextBoxColumn";
            this.dateOfModificationDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfModificationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // casesTableTableAdapter
            // 
            this.casesTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1278, 1044);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.noFilter);
            this.Controls.Add(this.sortCases);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.removeFilterCases);
            this.Controls.Add(this.filterCases);
            this.Controls.Add(this.printCases);
            this.Controls.Add(this.statusFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typeOfCaseFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteShift);
            this.Controls.Add(this.saveShift);
            this.Controls.Add(this.addShift);
            this.Controls.Add(this.No);
            this.Controls.Add(this.typeOfCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Cases";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteShift;
        private System.Windows.Forms.Button saveShift;
        private System.Windows.Forms.Button addShift;
        private System.Windows.Forms.ComboBox typeOfCase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statusFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox typeOfCaseFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button printCases;
        private System.Windows.Forms.Button removeFilterCases;
        private System.Windows.Forms.Button filterCases;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox sortCases;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox noFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PoliceStationDataSet policeStationDataSet;
        private System.Windows.Forms.BindingSource casesTableBindingSource;
        private PoliceStationDataSetTableAdapters.CasesTableTableAdapter casesTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfModificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox No;
        private System.Windows.Forms.TextBox description;
    }
}