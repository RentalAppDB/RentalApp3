using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Xml.Linq;

namespace RentalApp
{
    public partial class ucPropertyAgent : UserControl
    {
        public ucPropertyAgent()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            if (string.IsNullOrEmpty(cmbProp.Text))
            {
                errorPropertyAgent.SetError(cmbProp, "Please enter description");
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbAgent.Text))
            {
                errorPropertyAgent.SetError(cmbAgent, "Please enter description");
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(dtaDate.Text))
            {
                errorPropertyAgent.SetError(dtaDate, "Please enter date.");
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                PropertyAgent pa = new PropertyAgent();
                pa.PropertyID = int.Parse(cmbProp.Text);
                pa.AgentID = int.Parse(cmbAgent.Text);
                pa.Date = dtaDate.Text;

                int x = bll.PropertyAgentInsert(pa);

                if (x > 0)
                {
                    MessageBox.Show(x + "Added");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PropertyAgent pa = new PropertyAgent();
            pa.PropertyID = int.Parse(cmbProp.Text);
            pa.AgentID = int.Parse(cmbAgent.Text);
            pa.Date = dtaDate.Text;

            int x = bll.PropertyAgentUpdate(pa);

            if (x > 0)
            {
                MessageBox.Show(x + " Updated");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropAgent.DataSource = bll.PropertyAgentGet();
        }

        private void dgvPropAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropAgent.SelectedRows.Count > 0)
            {
                txtPropertyAgentID.Text = dgvPropAgent.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbProp.Text = dgvPropAgent.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                cmbAgent.Text = dgvPropAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                dtaDate.Text = dgvPropAgent.SelectedRows[0].Cells["Date"].Value.ToString();
            }
        }

    }
}
