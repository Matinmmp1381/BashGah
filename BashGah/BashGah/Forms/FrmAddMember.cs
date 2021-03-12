using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BashGah.Forms
{
    public partial class FrmAddMember : Form
    {
        public FrmAddMember()
        {
            InitializeComponent();
            Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == String.Empty)
            {
                MessageBox.Show("قسمت نام را پر کنید");

                return;
            }
            try
            {
                using (DB_GymEntities gymDB = new DB_GymEntities())
                {
                    Tbl_Athletes tbl = new Tbl_Athletes()
                    {
                        Athlete_Address = txtAddress.Text,
                        Athlete_FullName = txtName.Text,
                        Athlete_PhoneNumber = txtPhoneNumber.Text.ToString(),
                        Athlete_WardropNum = null,
                      
                    };
                    gymDB.Tbl_Athletes.Add(tbl);
                    gymDB.SaveChanges();
                    MessageBox.Show("عملیات موفقیت آمیز بود");
                    Reset();
                }

            }
            catch
            {
                MessageBox.Show("عملیات موفقیت آمیز نبود");

            }

        }
        private void Reset()
        {

            txtAddress.Text = txtName.Text = txtPhoneNumber.Text = String.Empty;

           
        }

      
    }
}

