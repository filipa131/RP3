using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace PoliceStation
{
    public partial class Form2 : Form
    {
        private string connectionString;
        public Form2(bool writeAccess, string connectionString)
        {
            InitializeComponent();
            idShifts.Enabled = writeAccess;
            shift.Enabled = writeAccess;
            dateShift.Enabled = writeAccess;
            addShift.Enabled = writeAccess;
            saveShift.Enabled = writeAccess;
            deleteShift.Enabled = writeAccess;
            this.connectionString = connectionString;
        }

        // Sluzi za provjeru postoji li zaposlenik sa zadanim ID-om. Ako ne postoji, onda se ne smije dodati smjena
        // s tim ID-om. Provjeru da isti zaposlenik dvije smjene ne smije obavljati u istom danu vrsi baza, tako sto
        // su ID i datum zajedno primarni kljuc te bi pokusaj dodavanja takvog retka izazvao gresku.
        private bool CheckEmployeeID(Int32 id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name" +
                    " FROM [PoliceStation].[dbo].[EmployeesTable] WHERE ID=@ID", conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("ID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) 
                { 
                    return true; 
                }
                else 
                { 
                    return false; 
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeStationDataSet.ShiftsTable' table. You can move, or remove it, as needed.
            this.shiftsTableTableAdapter.Fill(this.policeStationDataSet.ShiftsTable);
        }

        // ADD, SAVE, DELETE:
        private void addShift_Click(object sender, EventArgs e)
        {
            if (CheckEmployeeID(Convert.ToInt32(idShifts.Text)))
            {
                shiftsTableBindingSource.AddNew();
            }
        }

        private void saveShift_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckEmployeeID(Convert.ToInt32(idShifts.Text)))
                {
                    shiftsTableBindingSource.EndEdit();
                    shiftsTableTableAdapter.Update(policeStationDataSet.ShiftsTable);
                    MessageBox.Show("Data saved successfully.");
                }
                else
                {
                    MessageBox.Show("Employee with this ID does not exist.");
                }
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
                shiftsTableBindingSource.RemoveCurrent();
                shiftsTableTableAdapter.Update(policeStationDataSet.ShiftsTable);
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
            string title = "Shifts";
            e.Graphics.DrawString(title, titleFont, Brushes.Black, new PointF(50, 30));

            string desc = Interaction.InputBox("Report description:", "Report");
            Font bodyFont = new Font("Arial", 12);
            e.Graphics.DrawString(desc, bodyFont, Brushes.Black, new PointF(50, 575));

            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 50, 80);
        }

        private void printShifts_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.Text = "Shifts";
            printPreviewDialog1.ShowDialog();
        }

        // SORT:
        private void sortShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.ShiftsTable.DefaultView;
            dv.Sort = sortShifts.SelectedItem.ToString();
            dataGridView1.DataSource = dv.ToTable();
        }

        // FILTER - TO DO date filter:
        private void shiftFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.ShiftsTable.DefaultView;
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
            DataView dv = policeStationDataSet.ShiftsTable.DefaultView;
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
            DataView dv = policeStationDataSet.ShiftsTable.DefaultView;
            dv.RowFilter = string.Empty;

            dataGridView1.DataSource = dv.ToTable();
        }

        private void dateFilter_ValueChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.ShiftsTable.DefaultView;
            DateTime selectedDate = dateFilter.Value.Date;

            string formattedDate = selectedDate.ToString("M/d/yyyy");

            dv.RowFilter = $"Date = #{formattedDate}#";

            dataGridView1.DataSource = dv.ToTable();
        }
    }
}
