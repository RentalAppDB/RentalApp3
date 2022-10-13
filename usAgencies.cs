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
    public partial class usAgencies : UserControl
    {
        public usAgencies()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            if (string.IsNullOrEmpty(txtAgencyName.Text))
            {
                errorAgency.SetError(txtAgencyName, "Please enter agency name.");
            }
            else
            {
                validate = true;
            }
            
            if (validate)
            {
                Agency a = new Agency();
                a.AgencyName = txtAgencyName.Text;

                int x = bll.AgenciesInsert(a);

                if (x > 0)
                {
                    MessageBox.Show(x + "Added");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAgency.DataSource = bll.AgenciesGet();
        }


        private void dgvAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAgency.SelectedRows.Count> 0)
            {
                txtAgencyID.Text = dgvAgency.SelectedRows[0].Cells["AgencyID"].Value.ToString();
                txtAgencyName.Text = dgvAgency.SelectedRows[0].Cells["AgencyName"].Value.ToString();
                cmbSuburbID.Text = dgvAgency.SelectedRows[0].Cells["SurbubID"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agency a = new Agency();

            a.AgencyID = int.Parse(txtAgencyID.Text);
            
            int x = bll.AgenciesDelete(a);

            if(x > 0)
            {
                MessageBox.Show(x + " Deleted");
            }
        }
    }
}
