using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BashGah.Forms
{
    public partial class FrmAddGoods : Form
    {
        public FrmAddGoods()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {
                    Tbl_Store tbl = new Tbl_Store()
                    {
                        Store_FoodName = txtName.Text,
                        Store_FoodPrice = txtPrice.Value.ToString(),
                        Store_FoodInventory = txtInventory.Value.ToString()                                    
                    };
                    dbGym.Tbl_Store.Add(tbl);
                    dbGym.SaveChanges();
                    MessageBox.Show("عملیات با موفقیت انجام شد");
                    ResetFields();
                }
            }
            catch 
            {
                MessageBox.Show("عملیات با موفقیت انجام نشد");
            }
           
        }

        private void ResetFields()
        {
            txtName.ResetText();
            txtPrice.Value = 0;
            txtInventory.Value = 0;
        }

        private void btnCalcel_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
    }
}
