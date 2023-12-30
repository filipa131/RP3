using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeStationDataSet.EmployeesTable' table. You can move, or remove it, as needed.
            this.employeesTableTableAdapter.Fill(this.policeStationDataSet.EmployeesTable);

        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            employeesTableBindingSource.AddNew();
        }

        private void saveEmployee_Click(object sender, EventArgs e)
        {
            employeesTableBindingSource.EndEdit();
            employeesTableTableAdapter.Update(policeStationDataSet.EmployeesTable);
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            employeesTableBindingSource.RemoveCurrent();
            employeesTableTableAdapter.Update(policeStationDataSet.EmployeesTable);
        }

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

        private void filterEmployee_Click(object sender, EventArgs e)
        {
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                //String.Format("ID like '%" + idFilter + "%'");
        }
    }
}
