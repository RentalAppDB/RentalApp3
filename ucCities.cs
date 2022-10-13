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
    public partial class ucCities : UserControl
    {
        public ucCities()
        {
            InitializeComponent();
        }
        BusinessAccessLayer bll = new BusinessAccessLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            if (string.IsNullOrEmpty(txtCityDesc.Text))
            {
                errorCities.SetError(txtCityDesc, "Please enter description");
            }
            else
            {
                validate = true;
            }

            if (validate)
            {
                City c = new City();
                c.CityDescription = txtCityDesc.Text;

                int x = bll.CityInsert(c);

                if (x > 0)
                {
                    MessageBox.Show(x + "Added");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvCity.DataSource = bll.CityGet();
        }
    }
}
