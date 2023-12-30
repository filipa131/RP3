﻿namespace PoliceStation
{
    partial class Form2
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
            System.Windows.Forms.TextBox idShifts;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.shiftsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeStationDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeStationDataSet1 = new PoliceStation.PoliceStationDataSet1();
            this.deleteShift = new System.Windows.Forms.Button();
            this.saveShift = new System.Windows.Forms.Button();
            this.addShift = new System.Windows.Forms.Button();
            this.shift = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateShift = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.removeFilterShifts = new System.Windows.Forms.Button();
            this.filterShifts = new System.Windows.Forms.Button();
            this.shiftFilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printShifts = new System.Windows.Forms.Button();
            this.shiftsTableTableAdapter = new PoliceStation.PoliceStationDataSet1TableAdapters.ShiftsTableTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            idShifts = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idShifts
            // 
            idShifts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsTableBindingSource, "ID", true));
            idShifts.Location = new System.Drawing.Point(13, 88);
            idShifts.Name = "idShifts";
            idShifts.Size = new System.Drawing.Size(164, 26);
            idShifts.TabIndex = 60;
            // 
            // shiftsTableBindingSource
            // 
            this.shiftsTableBindingSource.DataMember = "ShiftsTable";
            this.shiftsTableBindingSource.DataSource = this.policeStationDataSet1BindingSource;
            // 
            // policeStationDataSet1BindingSource
            // 
            this.policeStationDataSet1BindingSource.DataSource = this.policeStationDataSet1;
            this.policeStationDataSet1BindingSource.Position = 0;
            // 
            // policeStationDataSet1
            // 
            this.policeStationDataSet1.DataSetName = "PoliceStationDataSet1";
            this.policeStationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteShift
            // 
            this.deleteShift.AutoSize = true;
            this.deleteShift.Location = new System.Drawing.Point(61, 411);
            this.deleteShift.Name = "deleteShift";
            this.deleteShift.Size = new System.Drawing.Size(75, 30);
            this.deleteShift.TabIndex = 66;
            this.deleteShift.Text = "Delete";
            this.deleteShift.UseVisualStyleBackColor = true;
            this.deleteShift.Click += new System.EventHandler(this.deleteShift_Click);
            // 
            // saveShift
            // 
            this.saveShift.AutoSize = true;
            this.saveShift.Location = new System.Drawing.Point(118, 358);
            this.saveShift.Name = "saveShift";
            this.saveShift.Size = new System.Drawing.Size(75, 30);
            this.saveShift.TabIndex = 65;
            this.saveShift.Text = "Save";
            this.saveShift.UseVisualStyleBackColor = true;
            this.saveShift.Click += new System.EventHandler(this.saveShift_Click);
            // 
            // addShift
            // 
            this.addShift.AutoSize = true;
            this.addShift.Location = new System.Drawing.Point(16, 358);
            this.addShift.Name = "addShift";
            this.addShift.Size = new System.Drawing.Size(75, 30);
            this.addShift.TabIndex = 64;
            this.addShift.Text = "Add";
            this.addShift.UseVisualStyleBackColor = true;
            this.addShift.Click += new System.EventHandler(this.addShift_Click);
            // 
            // shift
            // 
            this.shift.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsTableBindingSource, "Shift", true));
            this.shift.FormattingEnabled = true;
            this.shift.Items.AddRange(new object[] {
            "Night Shift ",
            "Morning Shift ",
            "Daytime Shift ",
            "Evening Shift"});
            this.shift.Location = new System.Drawing.Point(16, 181);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(164, 28);
            this.shift.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID";
            // 
            // dateShift
            // 
            this.dateShift.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsTableBindingSource, "Date", true));
            this.dateShift.Location = new System.Drawing.Point(16, 283);
            this.dateShift.Name = "dateShift";
            this.dateShift.Size = new System.Drawing.Size(200, 26);
            this.dateShift.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Date";
            // 
            // removeFilterShifts
            // 
            this.removeFilterShifts.AutoSize = true;
            this.removeFilterShifts.Location = new System.Drawing.Point(93, 686);
            this.removeFilterShifts.Name = "removeFilterShifts";
            this.removeFilterShifts.Size = new System.Drawing.Size(117, 30);
            this.removeFilterShifts.TabIndex = 72;
            this.removeFilterShifts.Text = "Remove Filter";
            this.removeFilterShifts.UseVisualStyleBackColor = true;
            // 
            // filterShifts
            // 
            this.filterShifts.AutoSize = true;
            this.filterShifts.Location = new System.Drawing.Point(12, 686);
            this.filterShifts.Name = "filterShifts";
            this.filterShifts.Size = new System.Drawing.Size(75, 30);
            this.filterShifts.TabIndex = 71;
            this.filterShifts.Text = "Filter";
            this.filterShifts.UseVisualStyleBackColor = true;
            // 
            // shiftFilter
            // 
            this.shiftFilter.FormattingEnabled = true;
            this.shiftFilter.Items.AddRange(new object[] {
            "Patrol Division",
            "Investigations Division",
            "Special Operations",
            "Highway Patrol",
            "Community Services",
            "Crime Scene Units",
            "Administrative Division",
            "Internal Affairs"});
            this.shiftFilter.Location = new System.Drawing.Point(16, 543);
            this.shiftFilter.Name = "shiftFilter";
            this.shiftFilter.Size = new System.Drawing.Size(164, 28);
            this.shiftFilter.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "Filter by Shift";
            // 
            // dateFilter
            // 
            this.dateFilter.FormattingEnabled = true;
            this.dateFilter.Items.AddRange(new object[] {
            "Patrol Division",
            "Investigations Division",
            "Special Operations",
            "Highway Patrol",
            "Community Services",
            "Crime Scene Units",
            "Administrative Division",
            "Internal Affairs"});
            this.dateFilter.Location = new System.Drawing.Point(16, 629);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(164, 28);
            this.dateFilter.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Filter by Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shiftsTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(250, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(807, 628);
            this.dataGridView1.TabIndex = 75;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // printShifts
            // 
            this.printShifts.AutoSize = true;
            this.printShifts.Location = new System.Drawing.Point(982, 746);
            this.printShifts.Name = "printShifts";
            this.printShifts.Size = new System.Drawing.Size(75, 30);
            this.printShifts.TabIndex = 76;
            this.printShifts.Text = "Print";
            this.printShifts.UseVisualStyleBackColor = true;
            this.printShifts.Click += new System.EventHandler(this.printShifts_Click);
            // 
            // shiftsTableTableAdapter
            // 
            this.shiftsTableTableAdapter.ClearBeforeFill = true;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 804);
            this.Controls.Add(this.printShifts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeFilterShifts);
            this.Controls.Add(this.filterShifts);
            this.Controls.Add(this.shiftFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteShift);
            this.Controls.Add(this.saveShift);
            this.Controls.Add(this.addShift);
            this.Controls.Add(idShifts);
            this.Controls.Add(this.shift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Shifts";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shiftsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteShift;
        private System.Windows.Forms.Button saveShift;
        private System.Windows.Forms.Button addShift;
        private System.Windows.Forms.ComboBox shift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeFilterShifts;
        private System.Windows.Forms.Button filterShifts;
        private System.Windows.Forms.ComboBox shiftFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dateFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button printShifts;
        private System.Windows.Forms.BindingSource policeStationDataSet1BindingSource;
        private PoliceStationDataSet1 policeStationDataSet1;
        private System.Windows.Forms.BindingSource shiftsTableBindingSource;
        private PoliceStationDataSet1TableAdapters.ShiftsTableTableAdapter shiftsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}