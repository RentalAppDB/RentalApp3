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
    public partial class ucSurburbs : UserControl
    {
        public ucSurburbs()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();
        private void Add_Click(object sender, EventArgs e)
        {
            bool validate = false;

            if (string.IsNullOrEmpty(txtSuburbDescr.Text))
            {
                errorSurbubs.SetError(txtSuburbDescr, "Please enter description");
            }
            else
            {
                validate = true;
                errorSurbubs.Clear();
            }
            if (string.IsNullOrEmpty(txtPostalCode.Text))
            {
                errorSurbubs.SetError(txtPostalCode, "Please enter postalCode");
            }
            else
            {
                validate=true;
                errorSurbubs.Clear();
            }

            if (validate)
            {
                Surbub sb = new Surbub();
                sb.SurbubDescription = txtSuburbDescr.Text;

                int x = bll.SuburbsInsert(sb);

                if (x > 0)
                {
                    MessageBox.Show(x + "Added");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvSuburbs.DataSource = bll.SurbubGet();
        }
    }
}
