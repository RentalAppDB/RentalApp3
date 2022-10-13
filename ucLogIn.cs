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

namespace RentalApp
{
    public partial class ucLogIn : UserControl
    {
        public ucLogIn()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable addt = bll.AdminLogIn(txtEmail.Text,txtPassword.Text);
            DataTable agdt =  bll.AgentLogIn(txtEmail.Text,txtPassword.Text);
            DataTable tdt = bll.TenantLogIn(txtEmail.Text,txtPassword.Text);

            if(addt.Rows.Count > 0)
            {
                ucAdmins ucAdmins = new ucAdmins();
                ucAdmins.Show();
                this.Hide();
            }
            else if(agdt.Rows.Count > 0)
            {
                ucAgent ucAgent = new ucAgent();
                ucAgent.Show();
                this.Hide();
            }
            else if(tdt.Rows.Count > 0)
            {
                ucTenant ucTenant = new ucTenant();
                ucTenant.Show();
                this.Hide();
            }
            else if(addt.Rows.Count == 0 && agdt.Rows.Count == 0 && tdt.Rows.Count == 0)
            {
                errorLogin.Visible = true;
            }
            
        }

        private void errorLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
