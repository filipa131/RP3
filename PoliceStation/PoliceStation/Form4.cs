using PoliceStation.PoliceStationDataSetTableAdapters;
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
    public partial class Form4 : Form
    {
        public Form4(bool writeAccess)
        {
            InitializeComponent();
            sNoAdd.Enabled = writeAccess;
            departmentAdd.Enabled = writeAccess;
            quantityAdd.Enabled = writeAccess;
            addInventory.Enabled = writeAccess;
            saveInventory.Enabled = writeAccess;
            deleteInventory.Enabled = writeAccess;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeStationDataSet.InventoryTable' table. You can move, or remove it, as needed.
            this.inventoryTableTableAdapter.Fill(this.policeStationDataSet.InventoryTable);

        }

        // ADD, SAVE, DELETE:
        private void addInventory_Click(object sender, EventArgs e)
        {
            inventoryTableBindingSource.AddNew();
        }

        private void saveInventory_Click(object sender, EventArgs e)
        {
            try
            {
                inventoryTableBindingSource.EndEdit();
                inventoryTableTableAdapter.Update(policeStationDataSet.InventoryTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteInventory_Click(object sender, EventArgs e)
        {
            try
            {
                inventoryTableBindingSource.RemoveCurrent();
                inventoryTableTableAdapter.Update(policeStationDataSet.InventoryTable);
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

        private void printInventory_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        // SORT:
        private void sortInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.InventoryTable.DefaultView;
            dv.Sort = sortInventory.SelectedItem.ToString();
            dataGridView1.DataSource = dv.ToTable();
        }

        // FILTER:
        private void filterInventory_Click(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.InventoryTable.DefaultView;
            string filterText = sNoFilter.Text.Trim();

            if (!string.IsNullOrEmpty(filterText))
            {
                dv.RowFilter = $"Convert([S No], 'System.String') = '{filterText}'";
            }
            else
            {
                dv.RowFilter = string.Empty;
            }

            dataGridView1.DataSource = dv.ToTable();
        }

        private void inventoryTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.InventoryTable.DefaultView;
            string selectedValue = inventoryTypeFilter.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedValue))
            {
                dv.RowFilter = $"[Inventory Type] = '{selectedValue}'";
            }
            else
            {
                dv.RowFilter = string.Empty;
            }

            dataGridView1.DataSource = dv.ToTable();
        }

        private void removeFilterInventory_Click(object sender, EventArgs e)
        {
            DataView dv = policeStationDataSet.InventoryTable.DefaultView;
            dv.RowFilter = string.Empty;

            dataGridView1.DataSource = dv.ToTable();
        }
    }
}
