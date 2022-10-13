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

namespace RentalApp
{
    public partial class ucProvince : UserControl
    {
        public ucProvince()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                errorProvince.SetError(txtDesc, "Please enter description");
            }
            else
            {
                validate = true;
            }

            if (validate)
            {
                Province prov = new Province();
                prov.Description = txtDesc.Text;

                int x = bll.ProvinceInsert(prov);

                if (x > 0)
                {
                    MessageBox.Show(x + "Added");
                }
            }
        }


        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvProvince.DataSource = bll.ProvinceGet();
        }
    }
}
