namespace PoliceStation
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.shiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.shiftsToolStripMenuItem,
            this.casesToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(850, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.CheckOnClick = true;
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.employeesToolStripMenuItem.Enabled = false;
            this.employeesToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // shiftsToolStripMenuItem
            // 
            this.shiftsToolStripMenuItem.CheckOnClick = true;
            this.shiftsToolStripMenuItem.Enabled = false;
            this.shiftsToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.shiftsToolStripMenuItem.Name = "shiftsToolStripMenuItem";
            this.shiftsToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.shiftsToolStripMenuItem.Text = "Shifts";
            this.shiftsToolStripMenuItem.Click += new System.EventHandler(this.shiftsToolStripMenuItem_Click);
            // 
            // casesToolStripMenuItem
            // 
            this.casesToolStripMenuItem.CheckOnClick = true;
            this.casesToolStripMenuItem.Enabled = false;
            this.casesToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.casesToolStripMenuItem.Name = "casesToolStripMenuItem";
            this.casesToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.casesToolStripMenuItem.Text = "Cases";
            this.casesToolStripMenuItem.Click += new System.EventHandler(this.casesToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.CheckOnClick = true;
            this.inventoryToolStripMenuItem.Enabled = false;
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.CheckOnClick = true;
            this.logOutToolStripMenuItem.Enabled = false;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Yellow;
            this.labelID.Location = new System.Drawing.Point(187, 45);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 14);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(218, 43);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(111, 20);
            this.textBoxID.TabIndex = 25;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(436, 43);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(175, 20);
            this.textBoxPassword.TabIndex = 27;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Yellow;
            this.labelPassword.Location = new System.Drawing.Point(357, 45);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(74, 14);
            this.labelPassword.TabIndex = 26;
            this.labelPassword.Text = "Password:";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.Yellow;
            this.buttonLogIn.Location = new System.Drawing.Point(646, 41);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(75, 23);
            this.buttonLogIn.TabIndex = 28;
            this.buttonLogIn.Text = "Log in";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMsg.ForeColor = System.Drawing.Color.Yellow;
            this.labelMsg.Location = new System.Drawing.Point(229, 87);
            this.labelMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(361, 18);
            this.labelMsg.TabIndex = 29;
            this.labelMsg.Text = "Enter employee ID and password to log in.";
            this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(850, 636);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Police Station";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelMsg;
    }
}