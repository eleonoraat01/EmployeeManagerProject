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
    public partial class StartForm : Form
    {
        AboutTheAuthorForm form;
        AddEmployeeForm addForm;
        public StartForm()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.SendToBack();
            label2.SendToBack();
            label3.SendToBack();
            pictureBox1.SendToBack();

            if (addForm == null)
            {
                addForm = new AddEmployeeForm();
                addForm.MdiParent = this;
                addForm.Show();
            }
            else
            {
                MessageBox.Show("Form is already opened!", "Form opened!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.SendToBack();
            label2.SendToBack();
            label3.SendToBack();
            pictureBox1.SendToBack();
        }

        private void changeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.SendToBack();
            label2.SendToBack();
            label3.SendToBack();
            pictureBox1.SendToBack();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.SendToBack();
            label2.SendToBack();
            label3.SendToBack();
            pictureBox1.SendToBack();
        }
        
        
        private void aboutTheAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.SendToBack();
            label2.SendToBack();
            label3.SendToBack();
            pictureBox1.SendToBack();

            if (form == null)
            {
                form = new AboutTheAuthorForm();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Form is already opened!", "Form opened!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                form = null;
            }
        }
    }
}
