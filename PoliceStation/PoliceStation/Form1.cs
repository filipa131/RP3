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
        private Form currentContentForm;
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

        private void ChangeContent(Form newForm)
        {
            if (currentContentForm == newForm)
            {
                currentContentForm.BringToFront();
                return;
            }

            if (currentContentForm != null)
            {
                Controls.Remove(currentContentForm); 
                currentContentForm.Dispose(); 
            }

            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            Controls.Add(newForm); 
            newForm.Show();

            currentContentForm = newForm;
        }


        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ChangeContent(new Form1());
        }

        private void shiftsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //ChangeContent(new Form2());
        }

        private void casesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //ChangeContent(new Form3());
        }

        private void inventoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //ChangeContent(new Form4());
        }

        private void sortEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.EmployeesTable.DefaultView;
            dv.Sort = sortEmployees.SelectedItem.ToString();
            dataGridView1.DataSource = dv.ToTable();
        }
    }
}
