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
using BLL;
using System.Text.RegularExpressions;

namespace RentalApp
{
    public partial class ucAgent : UserControl
    {
        public ucAgent()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorAgent.SetError(txtName, "Please enter your name.");
            }
            else
            {
                validate = true;
                errorAgent.Clear();
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errorAgent.SetError(txtSurname, "Please enter your surname.");
            }
            else
            {
                validate = true;
                errorAgent.Clear();
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || (!Regex.IsMatch(txtEmail.Text, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")))
            {
                errorAgent.SetError(txtEmail, "Please enter email.");
            }
            else
            {
                validate = true;
                errorAgent.Clear();
            }
            if (string.IsNullOrEmpty(txtPassword.Text) || (Regex.IsMatch(txtPassword.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")))
            {
                errorAgent.SetError(txtPassword, "Please enter correct password format( atleast one number, one symbol (#?!@$%^&*-), one UPPERCASE LETTER, one lowercase letter)");
            }
            else
            {
                validate = true;
                errorAgent.Clear();
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errorAgent.SetError(txtPhone, "Please enter phone");
            }
            else
            {
                validate = true;
                errorAgent.Clear();
            }

            if (validate)
            {
                Agent a = new Agent();
                a.Name = txtName.Text;
                a.Surname = txtSurname.Text;
                a.Email = txtEmail.Text;
                a.Password = txtPassword.Text;
                a.Phone = int.Parse(txtPhone.Text);
                a.Status = cmbStatus.Text;

                int x = bll.AgentInsert(a);

                if (x > 0)
                {
                    MessageBox.Show(x + "Added");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            a.Email = txtEmail.Text;
            a.Phone = int.Parse(txtPhone.Text);
            a.Status = cmbStatus.Text;

            int x = bll.AgentUpdate(a);

            if (x > 0)
            {
                MessageBox.Show(x + " Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();

            a.AgentID = int.Parse(txtAgentID.Text);

            int x = bll.AgentDelete(a);

            if (x > 0)
            {
                MessageBox.Show(x + " Deleted");
            }
        }

        private void dgvAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgent.SelectedRows.Count > 0)
            {
                txtAgentID.Text = dgvAgent.SelectedRows[0].Cells["AgencyID"].Value.ToString();
                txtName.Text = dgvAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAgent.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvAgent.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvAgent.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvAgent.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvAgent.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbAgencyID.Text = dgvAgent.SelectedRows[0].Cells["AgencyID"].Value.ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAgent.DataSource = bll.AgentGET();
        }
    }
}
