using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Text.RegularExpressions;

namespace RentalApp
{
    public partial class ucTenant : UserControl
    {
        public ucTenant()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorTenant.SetError(txtName, "Please enter your name.");
            }
            else
            {
                validate = true;
                errorTenant.Clear();
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errorTenant.SetError(txtSurname, "Please enter your surname");
            }
            else
            {
                validate = true;
                errorTenant.Clear();
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || (!Regex.IsMatch(txtEmail.Text, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")))
            {
                errorTenant.SetError(txtEmail, "Please enter email");
            }
            else
            {
                validate = true;
                errorTenant.Clear();
            }
            if (string.IsNullOrEmpty(txtPassword.Text) || (Regex.IsMatch(txtPassword.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")))
            {
                errorTenant.SetError(txtPassword, "Please enter correct password format( atleast one number, one symbol (#?!@$%^&*-), one UPPERCASE LETTER, one lowercase letter)");
            }
            else
            {
                validate = true;
                errorTenant.Clear();
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errorTenant.SetError(txtPhone, "Please enter phone number");
            }
            else
            {
                validate = true;
                errorTenant.Clear();
            }

            if (validate)
            {
                Tenant t = new Tenant();
                t.Name = txtName.Text;
                t.Surname = txtSurname.Text;
                t.Email = txtEmail.Text;
                t.Password=txtPassword.Text;
                t.Phone = int.Parse(txtPhone.Text);
                t.Status = cmbStatus.Text;

                int x = bll.TenantInsert(t);

                if (x > 0)
                {
                    MessageBox.Show(x + "Added");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            t.Email = txtEmail.Text;
            t.Phone = int.Parse(txtPhone.Text);
            t.Status = cmbStatus.Text;

            int x = bll.TenantUpdate(t);

            if (x > 0)
            {
                MessageBox.Show(x + " Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();

            t.TenantID = int.Parse(txtTenantID.Text);

            int x = bll.TenantDelete(t);

            if (x > 0)
            {
                MessageBox.Show(x + " Deleted");
            }
        }

        private void dgvTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTenant.SelectedRows.Count > 0)
            {
                txtTenantID.Text = dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
                txtName.Text = dgvTenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvTenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvTenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvTenant.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvTenant.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvTenant.SelectedRows[0].Cells["Status"].Value.ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvTenant.DataSource = bll.TenantGet();
        }
    }
}
