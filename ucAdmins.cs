using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;


namespace RentalApp
{
    public partial class ucAdmins : UserControl
    {
        public ucAdmins()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorAdmin.SetError(txtName, "Please enter your name.");
            }
            else
            {
                validate = true;
                errorAdmin.Clear();
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errorAdmin.SetError(txtSurname, "Please enter your surname.");
            }
            else
            {
                validate = true;
                errorAdmin.Clear();
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || (!Regex.IsMatch(txtEmail.Text, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")))
            {
                errorAdmin.SetError(txtEmail, "Please enter email.");
            }
            else
            {
                validate = true;
                errorAdmin.Clear();
            }
            if (string.IsNullOrEmpty(txtPassword.Text) || (Regex.IsMatch(txtPassword.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")))
            {
                errorAdmin.SetError(txtPassword, "Please enter correct password format( atleast one number, one symbol (#?!@$%^&*-), one UPPERCASE LETTER, one lowercase letter)");
            }
            else
            {
                validate = true;
                errorAdmin.Clear();
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errorAdmin.SetError(cmbStatus, "Please select status");
            }
            else
            {
                validate = true;
                errorAdmin.Clear();
            }

            if (validate)
            {
                Admin adm = new Admin();
                adm.AdminName = txtName.Text;
                adm.AdminSurname = txtSurname.Text;
                adm.AdminEmail = txtEmail.Text;
                adm.AdminPassword = txtPassword.Text;
                adm.AdminStatus = cmbStatus.Text;

                int x = bll.AdminInsert(adm);

                if (x > 0)
                {
                    MessageBox.Show(x + "Added");
                }
            }
        
    }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.AdminEmail = txtEmail.Text;
            adm.AdminPassword = txtPassword.Text;
            adm.AdminStatus = cmbStatus.Text;

            int x = bll.AdminUpdate(adm);

            if (x > 0)
            {
                MessageBox.Show(x + " Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();

            adm.AdminID = int.Parse(txtAdminID.Text);

            int x = bll.AdminHardDelete(adm);

            if (x > 0)
            {
                MessageBox.Show(x + " Deleted");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAdmin.DataSource = bll.AdminGET();
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                txtAdminID.Text = dgvAdmin.SelectedRows[0].Cells["AdminID"].Value.ToString();
                txtName.Text = dgvAdmin.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAdmin.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvAdmin.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvAdmin.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbStatus.Text = dgvAdmin.SelectedRows[0].Cells["Status"].Value.ToString();
            }
        }
    }
}
