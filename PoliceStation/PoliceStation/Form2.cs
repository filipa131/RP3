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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeStationDataSet1.ShiftsTable' table. You can move, or remove it, as needed.
            this.shiftsTableTableAdapter.Fill(this.policeStationDataSet1.ShiftsTable);

        }

        // ADD, SAVE, DELETE:
        private void addShift_Click(object sender, EventArgs e)
        {
            shiftsTableBindingSource.AddNew();
        }

        private void saveShift_Click(object sender, EventArgs e)
        {
            shiftsTableBindingSource.EndEdit();
            shiftsTableTableAdapter.Update(policeStationDataSet1.ShiftsTable);
        }

        private void deleteShift_Click(object sender, EventArgs e)
        {
            shiftsTableBindingSource.RemoveCurrent();
            shiftsTableTableAdapter.Update(policeStationDataSet1.ShiftsTable);
        }

        // PRINT:
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void printShifts_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        // STRIP MENU - TO DO:
        private void employeesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void shiftsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void casesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void inventoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        // SORT:
        private void sortShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet1.ShiftsTable.DefaultView;
            dv.Sort = sortShifts.SelectedItem.ToString();
            dataGridView1.DataSource = dv.ToTable();
        }

        // FILTER - TO DO date filter:
        private void shiftFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet1.ShiftsTable.DefaultView;
            string selectedValue = shiftFilter.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedValue))
            {
                dv.RowFilter = $"Shift = '{selectedValue}'";
            }
            else
            {
                dv.RowFilter = string.Empty;
            }

            dataGridView1.DataSource = dv.ToTable();
        }

        private void filterShifts_Click(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet1.ShiftsTable.DefaultView;
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

        private void removeFilterShifts_Click(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet1.ShiftsTable.DefaultView;
            dv.RowFilter = string.Empty;

            dataGridView1.DataSource = dv.ToTable();
        }

        private void dateFilter_ValueChanged(object sender, EventArgs e)
        {
            /*DataView dv = policeStationDataSet1.ShiftsTable.DefaultView;
            DateTime selectedDate = dateFilter.Value.Date;

            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            dv.RowFilter = $"Convert(Date, 'System.String') = '{formattedDate}'";

            dataGridView1.DataSource = dv.ToTable();*/
        }
    }
}
