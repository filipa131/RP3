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
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeStationDataSet.InventoryTable' table. You can move, or remove it, as needed.
            this.inventoryTableTableAdapter.Fill(this.policeStationDataSet.InventoryTable);

        }

        private void addInventory_Click(object sender, EventArgs e)
        {
            inventoryTableBindingSource.AddNew();
        }

        private void saveInventory_Click(object sender, EventArgs e)
        {
            inventoryTableBindingSource.EndEdit();
            inventoryTableTableAdapter.Update(policeStationDataSet.InventoryTable);
        }

        private void deleteInventory_Click(object sender, EventArgs e)
        {
            inventoryTableBindingSource.RemoveCurrent();
            inventoryTableTableAdapter.Update(policeStationDataSet.InventoryTable);
        }

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
    }
}
