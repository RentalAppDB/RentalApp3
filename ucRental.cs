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

namespace RentalApp
{
    public partial class ucRental : UserControl
    {
        public ucRental()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;
            if (string.IsNullOrEmpty(cmbPropTenantID.Text))
            {
                errorRental.SetError(cmbPropTenantID, "Please select property tenant");
            }
            else
            {
                validate = true;
                errorRental.Clear();
            }
            if (string.IsNullOrEmpty(cmbTenantID.Text))
            {
                errorRental.SetError(cmbTenantID, "Please select tenant");
            }
            else
            {
                validate = true;
                errorRental.Clear();
            }
            if (string.IsNullOrEmpty(dtaStartDate.Text))
            {
                errorRental.SetError(dtaStartDate, "Please enter start date");
            }
            else
            {
                validate = true;
                errorRental.Clear();
            }
            if (string.IsNullOrEmpty(dtaEndDate.Text))
            {
                errorRental.SetError(dtaEndDate, "Please enter end date");
            }
            else
            {
                validate = true;
                errorRental.Clear();
            }
            if (validate)
            {
                Rental r = new Rental();                
                r.PropertyTenantID = int.Parse(cmbPropTenantID.Text);
                r.TenantID = int.Parse(cmbTenantID.Text);
                r.StartDate = (dtaStartDate.Text);
                r.EndDate = (dtaEndDate.Text);

                int x = bll.RentalInsert(r);

                if (x > 0)
                {
                    MessageBox.Show(x + "Added");
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rental r = new Rental();
            r.StartDate = (dtaStartDate.Text);
            r.EndDate = (dtaEndDate.Text);

            int x = bll.RentaltUpdate(r);

            if (x > 0)
            {
                MessageBox.Show(x + " Updated");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvRental.DataSource = bll.PropertyAgentGet();
        }

        private void dgvRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                txtRentalID.Text = dgvRental.SelectedRows[0].Cells["RentalID"].Value.ToString();
                cmbPropTenantID.Text = dgvRental.SelectedRows[0].Cells["PropertyTenantID"].Value.ToString();
                cmbTenantID.Text = dgvRental.SelectedRows[0].Cells["TenantID"].Value.ToString();
                dtaStartDate.Text = dgvRental.SelectedRows[0].Cells["StartDate"].Value.ToString();
                dtaEndDate.Text = dgvRental.SelectedRows[0].Cells["EndDate"].Value.ToString();

            }
        }
    }
}
