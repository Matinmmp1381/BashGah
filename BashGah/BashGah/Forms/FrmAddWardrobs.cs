using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BashGah.Forms
{
    public partial class FrmAddWardrobs : Form
    {
        public FrmAddWardrobs()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {
                    bool any = dbGym.Tbl_Wardrops.Any(c => c.Wardrop_Number == txt.Text);
                    if (any)
                    {
                        lblWarn.Text = "این شماره ی کمد وجود دارد";
                        lblWarn.ForeColor = Color.Red;
                        dbGym.Dispose();
                        return;
                    }
                    Tbl_Wardrops tbl = new Tbl_Wardrops()
                    {
                        Wardrop_AthleteName = "بدون مشتری",
                        Wardrop_Number = txt.Text,
                        Wardrop_State = "خالی"
                    };
                    dbGym.Tbl_Wardrops.Add(tbl);
                    dbGym.SaveChanges();
                    lblWarn.Text = "کمد ثبت شد";
                    lblWarn.ForeColor = Color.Green;
                }
            }
            catch 
            {
                MessageBox.Show("مشکل در ثبت کمد");
               
            }
            
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("[0-9]");
            if (!reg.IsMatch(txt.Text))
            {
                txt.ResetText();
            }
            if (String.IsNullOrEmpty(txt.Text))
            {
                lblWarn.Text = "...";
                lblWarn.ForeColor = Color.Black;
            }
        }

       
    }
}
