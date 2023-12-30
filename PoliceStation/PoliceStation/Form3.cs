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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeStationDataSet2.CasesTable' table. You can move, or remove it, as needed.
            this.casesTableTableAdapter.Fill(this.policeStationDataSet2.CasesTable);

        }

        private void addShift_Click(object sender, EventArgs e)
        {
            casesTableBindingSource.AddNew();
        }

        private void saveShift_Click(object sender, EventArgs e)
        {
            casesTableBindingSource.EndEdit();
            casesTableTableAdapter.Update(policeStationDataSet2.CasesTable);
        }

        private void deleteShift_Click(object sender, EventArgs e)
        {
            casesTableBindingSource.RemoveCurrent();
            casesTableTableAdapter.Update(policeStationDataSet2.CasesTable);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void printCases_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
