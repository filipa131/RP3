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
    }
}
