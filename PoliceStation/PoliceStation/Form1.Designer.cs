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
            this.editEmployee = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.idAdd = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // editEmployee
            // 
            this.editEmployee.AutoSize = true;
            this.editEmployee.Location = new System.Drawing.Point(133, 507);
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(75, 30);
            this.editEmployee.TabIndex = 26;
            this.editEmployee.Text = "Edit";
            this.editEmployee.UseVisualStyleBackColor = true;
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
            // 
            // idAdd
            // 
            this.idAdd.Location = new System.Drawing.Point(34, 191);
            this.idAdd.Name = "idAdd";
            this.idAdd.Size = new System.Drawing.Size(164, 26);
            this.idAdd.TabIndex = 24;
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
            this.hourlyRate.Location = new System.Drawing.Point(32, 454);
            this.hourlyRate.Name = "hourlyRate";
            this.hourlyRate.Size = new System.Drawing.Size(164, 26);
            this.hourlyRate.TabIndex = 22;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(30, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(164, 26);
            this.name.TabIndex = 21;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(33, 360);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(200, 26);
            this.dateOfBirth.TabIndex = 20;
            // 
            // departmentAdd
            // 
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
            this.filterEmployee.Location = new System.Drawing.Point(76, 801);
            this.filterEmployee.Name = "filterEmployee";
            this.filterEmployee.Size = new System.Drawing.Size(75, 30);
            this.filterEmployee.TabIndex = 31;
            this.filterEmployee.Text = "Filter";
            this.filterEmployee.UseVisualStyleBackColor = true;
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
            this.departmentFilter.Location = new System.Drawing.Point(32, 750);
            this.departmentFilter.Name = "departmentFilter";
            this.departmentFilter.Size = new System.Drawing.Size(164, 28);
            this.departmentFilter.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 717);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(844, 676);
            this.dataGridView1.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 850);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.filterEmployee);
            this.Controls.Add(this.idFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.departmentFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.editEmployee);
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
            this.Name = "Form1";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editEmployee;
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
    }
}

