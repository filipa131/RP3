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
    public partial class MainForm : Form
    {
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Controls.Add(form);
            form.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void shiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2());
        }

        private void casesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form3());
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form4());
        }
    }
}
