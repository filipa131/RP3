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
        private bool loggedIn;
        private bool writeAccess;
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
            OpenForm(new Form1(writeAccess));
        }

        private void shiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2(writeAccess));
        }

        private void casesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form3(writeAccess));
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Form4(writeAccess));
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeAccess = false;
            loggedIn = false;

            textBoxID.Enabled = true;
            textBoxPassword.Enabled = true;

            employeesToolStripMenuItem.Enabled = false;
            shiftsToolStripMenuItem.Enabled = false;
            casesToolStripMenuItem.Enabled = false;
            inventoryToolStripMenuItem.Enabled = false;
            logOutToolStripMenuItem.Enabled = false;

            labelMsg.Text = "Enter employee ID and password to log in.";
            activeForm.Close();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            // TODO: provjera podataka u bazi

            if (loggedIn)
            {
                textBoxID.Enabled = false;
                textBoxPassword.Enabled = false;

                employeesToolStripMenuItem.Enabled = true;
                shiftsToolStripMenuItem.Enabled = true;
                casesToolStripMenuItem.Enabled = true;
                inventoryToolStripMenuItem.Enabled = true;
                logOutToolStripMenuItem.Enabled = true;

                labelMsg.Text = "You have successfully logged in. Welcome!";
            }
            else
            {
                labelMsg.Text = "Incorrect employee ID or password. Please try again!";
            }
        }
    }
}
