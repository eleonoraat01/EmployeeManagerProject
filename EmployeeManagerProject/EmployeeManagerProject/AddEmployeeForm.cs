using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerProject
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            //Sales Department
            comboBoxPosition.Items.Add("Sales Manager");
            comboBoxPosition.Items.Add("Sales Consultant");
            comboBoxPosition.Items.Add("Assistant");
            //Production Department
            comboBoxPosition.Items.Add("Production Manager");
            comboBoxPosition.Items.Add("Production Technologist");
            comboBoxPosition.Items.Add("Production Worker");
            comboBoxPosition.Items.Add("Unloader");
            //Accounting Department
            comboBoxPosition.Items.Add("Main Accountant");
            comboBoxPosition.Items.Add("Accountant");
            comboBoxPosition.Items.Add("Secretary");
            //Marketing and Advertising Department
            comboBoxPosition.Items.Add("Marketing Manager");
            comboBoxPosition.Items.Add("PR");
            comboBoxPosition.Items.Add("Advertising Manager");

            comboBoxDepartment.Items.Add("Sales Department");
            comboBoxDepartment.Items.Add("Production Department");
            comboBoxDepartment.Items.Add("Accounting Department");
            comboBoxDepartment.Items.Add("Marketing and Advertising Department");
            
            lblDate.Text = "";
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dtpReceipt.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
            this.DialogResult = DialogResult.OK;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to close? Your changes will not be saved!", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
