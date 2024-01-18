using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PoliceStation
{
    public partial class Form1 : Form
    {
        private Form currentContentForm;
        public Form1(bool writeAccess)
        {
            InitializeComponent();
            name.Enabled = writeAccess;
            idAdd.Enabled = writeAccess;
            departmentAdd.Enabled = writeAccess;
            dateOfBirth.Enabled = writeAccess;
            hourlyRate.Enabled = writeAccess;
            addEmployee.Enabled = writeAccess;
            saveEmployee.Enabled = writeAccess;
            deleteEmployee.Enabled = writeAccess;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeStationDataSet4.ShiftsTable' table. You can move, or remove it, as needed.
            //this.shiftsTableTableAdapter.Fill(this.policeStationDataSet4.ShiftsTable);
            // TODO: This line of code loads data into the 'policeStationDataSet3.EmployeesTable' table. You can move, or remove it, as needed.
            this.employeesTableTableAdapter1.Fill(this.policeStationDataSet3.EmployeesTable);
            // TODO: This line of code loads data into the 'policeStationDataSet.EmployeesTable' table. You can move, or remove it, as needed.
            //this.employeesTableTableAdapter.Fill(this.policeStationDataSet.EmployeesTable);
        }

        // ADD, SAVE, DELETE:
        private void addEmployee_Click(object sender, EventArgs e)
        {
            employeesTableBindingSource1.AddNew();
        }

        private void saveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                employeesTableBindingSource1.EndEdit();
                employeesTableTableAdapter1.Update(policeStationDataSet3.EmployeesTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"This ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                employeesTableBindingSource1.RemoveCurrent();
                employeesTableTableAdapter1.Update(policeStationDataSet3.EmployeesTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // PRINT:
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void printEmployees_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        // SORT:
        private void sortEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.EmployeesTable.DefaultView;
            dv.Sort = sortEmployees.SelectedItem.ToString();
            dataGridView1.DataSource = dv.ToTable();
        }

        // FILTER:
        private void departmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.EmployeesTable.DefaultView;
            string selectedValue = departmentFilter.SelectedItem?.ToString(); 

            if (!string.IsNullOrEmpty(selectedValue))
            {
                dv.RowFilter = $"Department = '{selectedValue}'"; 
            }
            else
            {
                dv.RowFilter = string.Empty;
            }

            dataGridView1.DataSource = dv.ToTable();
        }

        private void filterEmployee_Click(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.EmployeesTable.DefaultView;
            string filterText = idFilter.Text.Trim();

            if (!string.IsNullOrEmpty(filterText))
            {
                dv.RowFilter = $"Convert(ID, 'System.String') = '{filterText}'";
            }
            else
            {
                dv.RowFilter = string.Empty;
            }

            dataGridView1.DataSource = dv.ToTable();
        }

        private void removeFilterEmployees_Click(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.EmployeesTable.DefaultView;
            dv.RowFilter = string.Empty;

            dataGridView1.DataSource = dv.ToTable();
        }
    }
}
