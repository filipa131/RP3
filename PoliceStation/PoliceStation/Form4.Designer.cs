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
            System.Windows.Forms.TextBox policeInventory;
            this.filterInventory = new System.Windows.Forms.Button();
            this.sNoFilter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inventoryTypeFilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.editInventory = new System.Windows.Forms.Button();
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
            policeInventory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filterInventory
            // 
            this.filterInventory.AutoSize = true;
            this.filterInventory.Location = new System.Drawing.Point(78, 811);
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
            // editInventory
            // 
            this.editInventory.AutoSize = true;
            this.editInventory.Location = new System.Drawing.Point(124, 447);
            this.editInventory.Name = "editInventory";
            this.editInventory.Size = new System.Drawing.Size(75, 30);
            this.editInventory.TabIndex = 49;
            this.editInventory.Text = "Edit";
            this.editInventory.UseVisualStyleBackColor = true;
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
            // 
            // sNoAdd
            // 
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
            this.quantityAdd.Location = new System.Drawing.Point(23, 394);
            this.quantityAdd.Name = "quantityAdd";
            this.quantityAdd.Size = new System.Drawing.Size(164, 26);
            this.quantityAdd.TabIndex = 45;
            // 
            // policeInventory
            // 
            policeInventory.Location = new System.Drawing.Point(23, 123);
            policeInventory.Name = "policeInventory";
            policeInventory.Size = new System.Drawing.Size(164, 26);
            policeInventory.TabIndex = 44;
            // 
            // departmentAdd
            // 
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(851, 665);
            this.dataGridView1.TabIndex = 56;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 875);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteInventory);
            this.Controls.Add(this.filterInventory);
            this.Controls.Add(this.sNoFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inventoryTypeFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.editInventory);
            this.Controls.Add(this.addInventory);
            this.Controls.Add(this.sNoAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantityAdd);
            this.Controls.Add(policeInventory);
            this.Controls.Add(this.departmentAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inventory";
            this.Text = "Inventory";
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
        private System.Windows.Forms.Button editInventory;
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
    }
}