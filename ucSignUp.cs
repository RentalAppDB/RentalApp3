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
    public partial class ucSignUp : UserControl
    {
        public ucSignUp()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ucAdmins adm = new ucAdmins();
            adm.Show();
            this.Hide();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            ucAgent ag = new ucAgent();
            ag.Show();
            this.Hide();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            ucTenant ten = new ucTenant();
            ten.Show();
            this.Hide();
        }
    }
}
