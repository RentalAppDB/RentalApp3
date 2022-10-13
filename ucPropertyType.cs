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
    public partial class ucPropertyType : UserControl
    {
        public ucPropertyType()
        {
            InitializeComponent();
        }

        BusinessAccessLayer bll = new BusinessAccessLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            if (string.IsNullOrEmpty(txtPropertyTypeDesc.Text))
            {
                errorPropertyTypes.SetError(txtPropertyTypeDesc, "Please enter description");
            }
            else
            {
                validate = true;
            }

            if (validate)
            {
                PropertyType pt = new PropertyType();
                pt.PropertyTypeDescription = txtPropertyTypeDesc.Text;

                int x = bll.PropertyTypeInsert(pt);

                if(x > 0)
                {
                    MessageBox.Show(x + "Added");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropertyType.DataSource = bll.PropertyTypeGET();
        }
    }
}
