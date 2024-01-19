using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
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

        private string connectionString = "Data Source=.\\SQLEXPRESS;" +
            "Initial Catalog=PoliceStation;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
        }

        // Funkcija za otvaranje pojedinacnih formi 1 - 4 klikom na navigacijsku traku
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

        // Ovisno o tome ima li prijavljeni korisnik pravo privilegiranog pristupa (write access) u zaglavlje forme
        // stavljamo prikladan tekst
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelMsg.Text = "Form for viewing " + (writeAccess? "and editing " : "") + "the list of all current employees";
            OpenForm(new Form1(writeAccess));
        }

        private void shiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelMsg.Text = "Form for viewing " + (writeAccess? "and editing " : "") + "the shifts assigned to the employees";
            OpenForm(new Form2(writeAccess, connectionString));
        }

        private void casesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelMsg.Text = "Form for viewing " + (writeAccess? "and editing " : "") + "the list of all ongoing cases";
            OpenForm(new Form3(writeAccess));
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelMsg.Text = "Form for viewing " + (writeAccess? "and editing " : "") + "the currently available inventory";
            OpenForm(new Form4(writeAccess));
        }

        // Prilikom log-outa onemogucuju se svi gumbi u navigacijskoj traci, a omogucuje se unos ID-a i lozinke te se
        // gasi trenutna forma (ukoliko je ijedna bila otvorena) i vracamo se na pocetni ekran
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeAccess = false;
            loggedIn = false;

            textBoxID.Enabled = true;
            textBoxPassword.Enabled = true;
            buttonLogIn.Enabled = true;

            employeesToolStripMenuItem.Enabled = false;
            shiftsToolStripMenuItem.Enabled = false;
            casesToolStripMenuItem.Enabled = false;
            inventoryToolStripMenuItem.Enabled = false;
            logOutToolStripMenuItem.Enabled = false;

            labelMsg.Text = "Enter employee ID and password to log in.";
            labelName.Text = "";

            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        // Provjeravamo unesene podatke u bazi (tablica EmployeesTable) te dohvacamo podatak ima li korisnik
        // write access i ime korisnika koje ce pisati u gornjem desnom kutu
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Password, [Write Access], Name" +
                    " FROM [PoliceStation].[dbo].[EmployeesTable] WHERE ID=@ID", conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("ID", textBoxID.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() && reader["Password"].ToString() == textBoxPassword.Text)
                {
                    loggedIn = true;
                    writeAccess = Convert.ToBoolean(reader["Write Access"]);
                    labelName.Text = reader["Name"].ToString();
                }
            }

            // Ako je korisnik uspjesno ulogiran, onemogucujemo formu za ulogiranje, a omogucujemo pristup svim ostalim
            // formama putem navigacijske trake
            if (loggedIn)
            {
                textBoxID.Enabled = false;
                textBoxPassword.Enabled = false;
                buttonLogIn.Enabled = false;

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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
