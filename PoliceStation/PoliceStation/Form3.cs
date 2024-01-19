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
    public partial class Form3 : Form
    {
        public Form3(bool writeAccess)
        {
            InitializeComponent();
            No.Enabled = writeAccess;
            description.Enabled = writeAccess;
            typeOfCase.Enabled = writeAccess;
            status.Enabled = writeAccess;
            dateShift.Enabled = writeAccess;
            addShift.Enabled = writeAccess;
            saveShift.Enabled = writeAccess;
            deleteShift.Enabled = writeAccess;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeStationDataSet.CasesTable' table. You can move, or remove it, as needed.
            this.casesTableTableAdapter.Fill(this.policeStationDataSet.CasesTable);
        }

        // ADD, SAVE, DELETE:
        private void addShift_Click(object sender, EventArgs e)
        {
            casesTableBindingSource.AddNew();
        }

        private void saveShift_Click(object sender, EventArgs e)
        {
            try
            {
                casesTableBindingSource.EndEdit();
                casesTableTableAdapter.Update(policeStationDataSet.CasesTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteShift_Click(object sender, EventArgs e)
        {
            try
            {
                casesTableBindingSource.RemoveCurrent();
                casesTableTableAdapter.Update(policeStationDataSet.CasesTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // PRINT:
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            string title = "Cases";
            e.Graphics.DrawString(title, titleFont, Brushes.Black, new PointF(50, 30));

            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 50, 80);
        }

        private void printCases_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.Text = "Cases";
            printPreviewDialog1.ShowDialog();
        }

        // SORT:
        private void sortCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.CasesTable.DefaultView;
            dv.Sort = sortCases.SelectedItem.ToString();
            dataGridView1.DataSource = dv.ToTable();
        }

        // FILTERS:
        private void filterCases_Click(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.CasesTable.DefaultView;
            string filterText = noFilter.Text.Trim();

            if (!string.IsNullOrEmpty(filterText))
            {
                dv.RowFilter = $"Convert(No, 'System.String') = '{filterText}'";
            }
            else
            {
                dv.RowFilter = string.Empty;
            }

            dataGridView1.DataSource = dv.ToTable();
        }

        private void typeOfCaseFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.CasesTable.DefaultView;
            string selectedValue = typeOfCaseFilter.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedValue))
            {
                dv.RowFilter = $"[Type of Case] = '{selectedValue}'";
            }
            else
            {
                dv.RowFilter = string.Empty;
            }

            dataGridView1.DataSource = dv.ToTable();
        }

        private void statusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.CasesTable.DefaultView;
            string selectedValue = statusFilter.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedValue))
            {
                dv.RowFilter = $"Status = '{selectedValue}'";
            }
            else
            {
                dv.RowFilter = string.Empty;
            }

            dataGridView1.DataSource = dv.ToTable();
        }

        private void removeFilterCases_Click(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.CasesTable.DefaultView;
            dv.RowFilter = string.Empty;

            dataGridView1.DataSource = dv.ToTable();
        }
    }
}
