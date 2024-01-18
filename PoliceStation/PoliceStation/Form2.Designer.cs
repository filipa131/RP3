namespace PoliceStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.idShifts = new System.Windows.Forms.TextBox();
            this.deleteShift = new System.Windows.Forms.Button();
            this.saveShift = new System.Windows.Forms.Button();
            this.addShift = new System.Windows.Forms.Button();
            this.shift = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateShift = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.removeFilterShifts = new System.Windows.Forms.Button();
            this.shiftFilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printShifts = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.sortShifts = new System.Windows.Forms.ComboBox();
            this.filterShifts = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idFilter = new System.Windows.Forms.TextBox();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.policeStationDataSet = new PoliceStation.PoliceStationDataSet();
            this.shiftsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftsTableTableAdapter = new PoliceStation.PoliceStationDataSetTableAdapters.ShiftsTableTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idShifts
            // 
            this.idShifts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsTableBindingSource, "ID", true));
            this.idShifts.Location = new System.Drawing.Point(28, 295);
            this.idShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idShifts.Name = "idShifts";
            this.idShifts.Size = new System.Drawing.Size(164, 26);
            this.idShifts.TabIndex = 60;
            // 
            // deleteShift
            // 
            this.deleteShift.AutoSize = true;
            this.deleteShift.Location = new System.Drawing.Point(76, 618);
            this.deleteShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteShift.Name = "deleteShift";
            this.deleteShift.Size = new System.Drawing.Size(75, 35);
            this.deleteShift.TabIndex = 66;
            this.deleteShift.Text = "Delete";
            this.deleteShift.UseVisualStyleBackColor = true;
            this.deleteShift.Click += new System.EventHandler(this.deleteShift_Click);
            // 
            // saveShift
            // 
            this.saveShift.AutoSize = true;
            this.saveShift.Location = new System.Drawing.Point(134, 565);
            this.saveShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveShift.Name = "saveShift";
            this.saveShift.Size = new System.Drawing.Size(75, 35);
            this.saveShift.TabIndex = 65;
            this.saveShift.Text = "Save";
            this.saveShift.UseVisualStyleBackColor = true;
            this.saveShift.Click += new System.EventHandler(this.saveShift_Click);
            // 
            // addShift
            // 
            this.addShift.AutoSize = true;
            this.addShift.Location = new System.Drawing.Point(32, 565);
            this.addShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addShift.Name = "addShift";
            this.addShift.Size = new System.Drawing.Size(75, 35);
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
            this.shift.Location = new System.Drawing.Point(32, 389);
            this.shift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(164, 28);
            this.shift.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(27, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "Shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(27, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID";
            // 
            // dateShift
            // 
            this.dateShift.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftsTableBindingSource, "Date", true));
            this.dateShift.Location = new System.Drawing.Point(32, 491);
            this.dateShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateShift.Name = "dateShift";
            this.dateShift.Size = new System.Drawing.Size(200, 26);
            this.dateShift.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(27, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "Date";
            // 
            // removeFilterShifts
            // 
            this.removeFilterShifts.AutoSize = true;
            this.removeFilterShifts.Location = new System.Drawing.Point(111, 992);
            this.removeFilterShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeFilterShifts.Name = "removeFilterShifts";
            this.removeFilterShifts.Size = new System.Drawing.Size(123, 35);
            this.removeFilterShifts.TabIndex = 72;
            this.removeFilterShifts.Text = "Remove Filter";
            this.removeFilterShifts.UseVisualStyleBackColor = true;
            this.removeFilterShifts.Click += new System.EventHandler(this.removeFilterShifts_Click);
            // 
            // shiftFilter
            // 
            this.shiftFilter.FormattingEnabled = true;
            this.shiftFilter.Items.AddRange(new object[] {
            "Night Shift ",
            "Morning Shift ",
            "Daytime Shift ",
            "Evening Shift"});
            this.shiftFilter.Location = new System.Drawing.Point(32, 828);
            this.shiftFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shiftFilter.Name = "shiftFilter";
            this.shiftFilter.Size = new System.Drawing.Size(164, 28);
            this.shiftFilter.TabIndex = 70;
            this.shiftFilter.SelectedIndexChanged += new System.EventHandler(this.shiftFilter_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(27, 795);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 22);
            this.label8.TabIndex = 69;
            this.label8.Text = "Filter by Shift";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(27, 882);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 73;
            this.label4.Text = "Filter by Date";
            // 
            // printShifts
            // 
            this.printShifts.AutoSize = true;
            this.printShifts.Location = new System.Drawing.Point(1190, 992);
            this.printShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printShifts.Name = "printShifts";
            this.printShifts.Size = new System.Drawing.Size(75, 35);
            this.printShifts.TabIndex = 76;
            this.printShifts.Text = "Print";
            this.printShifts.UseVisualStyleBackColor = true;
            this.printShifts.Click += new System.EventHandler(this.printShifts_Click);
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
            this.label6.TabIndex = 79;
            this.label6.Text = "Sort";
            // 
            // sortShifts
            // 
            this.sortShifts.FormattingEnabled = true;
            this.sortShifts.Items.AddRange(new object[] {
            "ID",
            "Shift",
            "Date"});
            this.sortShifts.Location = new System.Drawing.Point(332, 238);
            this.sortShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortShifts.Name = "sortShifts";
            this.sortShifts.Size = new System.Drawing.Size(121, 28);
            this.sortShifts.TabIndex = 80;
            this.sortShifts.SelectedIndexChanged += new System.EventHandler(this.sortShifts_SelectedIndexChanged);
            // 
            // filterShifts
            // 
            this.filterShifts.AutoSize = true;
            this.filterShifts.Location = new System.Drawing.Point(28, 992);
            this.filterShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterShifts.Name = "filterShifts";
            this.filterShifts.Size = new System.Drawing.Size(75, 35);
            this.filterShifts.TabIndex = 71;
            this.filterShifts.Text = "Filter";
            this.filterShifts.UseVisualStyleBackColor = true;
            this.filterShifts.Click += new System.EventHandler(this.filterShifts_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(27, 711);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 81;
            this.label5.Text = "Filter by ID";
            // 
            // idFilter
            // 
            this.idFilter.Location = new System.Drawing.Point(32, 749);
            this.idFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idFilter.Name = "idFilter";
            this.idFilter.Size = new System.Drawing.Size(162, 26);
            this.idFilter.TabIndex = 82;
            // 
            // dateFilter
            // 
            this.dateFilter.Location = new System.Drawing.Point(32, 922);
            this.dateFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(200, 26);
            this.dateFilter.TabIndex = 83;
            this.dateFilter.ValueChanged += new System.EventHandler(this.dateFilter_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shiftsTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(280, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(985, 700);
            this.dataGridView1.TabIndex = 84;
            // 
            // policeStationDataSet
            // 
            this.policeStationDataSet.DataSetName = "PoliceStationDataSet";
            this.policeStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftsTableBindingSource
            // 
            this.shiftsTableBindingSource.DataMember = "ShiftsTable";
            this.shiftsTableBindingSource.DataSource = this.policeStationDataSet;
            // 
            // shiftsTableTableAdapter
            // 
            this.shiftsTableTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1278, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.idFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sortShifts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.printShifts);
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
            this.Controls.Add(this.idShifts);
            this.Controls.Add(this.shift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Shifts";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsTableBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox shiftFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button printShifts;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sortShifts;
        private System.Windows.Forms.Button filterShifts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idFilter;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.TextBox idShifts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PoliceStationDataSet policeStationDataSet;
        private System.Windows.Forms.BindingSource shiftsTableBindingSource;
        private PoliceStationDataSetTableAdapters.ShiftsTableTableAdapter shiftsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}