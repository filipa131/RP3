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
            System.Windows.Forms.TextBox No;
            System.Windows.Forms.TextBox description;
            System.Windows.Forms.TextBox noFilter;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
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
            this.policeStationDataSet2 = new PoliceStation.PoliceStationDataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.casesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casesTableTableAdapter = new PoliceStation.PoliceStationDataSet2TableAdapters.CasesTableTableAdapter();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfCaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfModificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            No = new System.Windows.Forms.TextBox();
            description = new System.Windows.Forms.TextBox();
            noFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateShift
            // 
            this.dateShift.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casesTableBindingSource, "Date of Modification", true));
            this.dateShift.Location = new System.Drawing.Point(34, 438);
            this.dateShift.Name = "dateShift";
            this.dateShift.Size = new System.Drawing.Size(200, 26);
            this.dateShift.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Date of Modification";
            // 
            // deleteShift
            // 
            this.deleteShift.AutoSize = true;
            this.deleteShift.Location = new System.Drawing.Point(79, 562);
            this.deleteShift.Name = "deleteShift";
            this.deleteShift.Size = new System.Drawing.Size(75, 30);
            this.deleteShift.TabIndex = 75;
            this.deleteShift.Text = "Delete";
            this.deleteShift.UseVisualStyleBackColor = true;
            this.deleteShift.Click += new System.EventHandler(this.deleteShift_Click);
            // 
            // saveShift
            // 
            this.saveShift.AutoSize = true;
            this.saveShift.Location = new System.Drawing.Point(136, 509);
            this.saveShift.Name = "saveShift";
            this.saveShift.Size = new System.Drawing.Size(75, 30);
            this.saveShift.TabIndex = 74;
            this.saveShift.Text = "Save";
            this.saveShift.UseVisualStyleBackColor = true;
            this.saveShift.Click += new System.EventHandler(this.saveShift_Click);
            // 
            // addShift
            // 
            this.addShift.AutoSize = true;
            this.addShift.Location = new System.Drawing.Point(34, 509);
            this.addShift.Name = "addShift";
            this.addShift.Size = new System.Drawing.Size(75, 30);
            this.addShift.TabIndex = 73;
            this.addShift.Text = "Add";
            this.addShift.UseVisualStyleBackColor = true;
            this.addShift.Click += new System.EventHandler(this.addShift_Click);
            // 
            // No
            // 
            No.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casesTableBindingSource, "No", true));
            No.Location = new System.Drawing.Point(25, 77);
            No.Name = "No";
            No.Size = new System.Drawing.Size(164, 26);
            No.TabIndex = 72;
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
            this.typeOfCase.Location = new System.Drawing.Point(28, 161);
            this.typeOfCase.Name = "typeOfCase";
            this.typeOfCase.Size = new System.Drawing.Size(164, 28);
            this.typeOfCase.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Type of Case";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
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
            this.status.Location = new System.Drawing.Point(31, 246);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(164, 28);
            this.status.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Status";
            // 
            // description
            // 
            description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casesTableBindingSource, "Description", true));
            description.Location = new System.Drawing.Point(31, 340);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new System.Drawing.Size(164, 26);
            description.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
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
            this.statusFilter.Location = new System.Drawing.Point(37, 825);
            this.statusFilter.Name = "statusFilter";
            this.statusFilter.Size = new System.Drawing.Size(164, 28);
            this.statusFilter.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 792);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "Filter by Status";
            // 
            // noFilter
            // 
            noFilter.Location = new System.Drawing.Point(31, 656);
            noFilter.Name = "noFilter";
            noFilter.Size = new System.Drawing.Size(164, 26);
            noFilter.TabIndex = 85;
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
            this.typeOfCaseFilter.Location = new System.Drawing.Point(34, 740);
            this.typeOfCaseFilter.Name = "typeOfCaseFilter";
            this.typeOfCaseFilter.Size = new System.Drawing.Size(164, 28);
            this.typeOfCaseFilter.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 707);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "Filter by Type of Case";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 619);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Filter by No";
            // 
            // printCases
            // 
            this.printCases.AutoSize = true;
            this.printCases.Location = new System.Drawing.Point(1153, 812);
            this.printCases.Name = "printCases";
            this.printCases.Size = new System.Drawing.Size(75, 30);
            this.printCases.TabIndex = 88;
            this.printCases.Text = "Print";
            this.printCases.UseVisualStyleBackColor = true;
            this.printCases.Click += new System.EventHandler(this.printCases_Click);
            // 
            // removeFilterCases
            // 
            this.removeFilterCases.AutoSize = true;
            this.removeFilterCases.Location = new System.Drawing.Point(343, 823);
            this.removeFilterCases.Name = "removeFilterCases";
            this.removeFilterCases.Size = new System.Drawing.Size(117, 30);
            this.removeFilterCases.TabIndex = 91;
            this.removeFilterCases.Text = "Remove Filter";
            this.removeFilterCases.UseVisualStyleBackColor = true;
            // 
            // filterCases
            // 
            this.filterCases.AutoSize = true;
            this.filterCases.Location = new System.Drawing.Point(262, 823);
            this.filterCases.Name = "filterCases";
            this.filterCases.Size = new System.Drawing.Size(75, 30);
            this.filterCases.TabIndex = 90;
            this.filterCases.Text = "Filter";
            this.filterCases.UseVisualStyleBackColor = true;
            // 
            // policeStationDataSet2
            // 
            this.policeStationDataSet2.DataSetName = "PoliceStationDataSet2";
            this.policeStationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(303, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(925, 710);
            this.dataGridView1.TabIndex = 92;
            // 
            // casesTableBindingSource
            // 
            this.casesTableBindingSource.DataMember = "CasesTable";
            this.casesTableBindingSource.DataSource = this.policeStationDataSet2;
            // 
            // casesTableTableAdapter
            // 
            this.casesTableTableAdapter.ClearBeforeFill = true;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // typeOfCaseDataGridViewTextBoxColumn
            // 
            this.typeOfCaseDataGridViewTextBoxColumn.DataPropertyName = "Type of Case";
            this.typeOfCaseDataGridViewTextBoxColumn.HeaderText = "Type of Case";
            this.typeOfCaseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeOfCaseDataGridViewTextBoxColumn.Name = "typeOfCaseDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dateOfModificationDataGridViewTextBoxColumn
            // 
            this.dateOfModificationDataGridViewTextBoxColumn.DataPropertyName = "Date of Modification";
            this.dateOfModificationDataGridViewTextBoxColumn.HeaderText = "Date of Modification";
            this.dateOfModificationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfModificationDataGridViewTextBoxColumn.Name = "dateOfModificationDataGridViewTextBoxColumn";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 865);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeFilterCases);
            this.Controls.Add(this.filterCases);
            this.Controls.Add(this.printCases);
            this.Controls.Add(this.statusFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(noFilter);
            this.Controls.Add(this.typeOfCaseFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteShift);
            this.Controls.Add(this.saveShift);
            this.Controls.Add(this.addShift);
            this.Controls.Add(No);
            this.Controls.Add(this.typeOfCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Cases";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesTableBindingSource)).EndInit();
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
        private PoliceStationDataSet2 policeStationDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource casesTableBindingSource;
        private PoliceStationDataSet2TableAdapters.CasesTableTableAdapter casesTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfCaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfModificationDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}