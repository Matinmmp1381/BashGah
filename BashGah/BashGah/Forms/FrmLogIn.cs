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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || (String.IsNullOrEmpty(txtPassWord.Text)))
            {
                MessageBox.Show("لطفا همه ی فیلد ها را پر کنید ");
                return;

            }
            bool any;
            using (DB_GymEntities dbGym = new DB_GymEntities())
            {
                any = dbGym.Tbl_AdminAccess.Any(c => c.AdminAccess_UserName == txtName.Text);
                if (!any)
                {
                    MessageBox.Show("همچین نام کاربری وجود ندارد");
                    return;
                }
                var tbl = dbGym.Tbl_AdminAccess.Where(c => c.AdminAccess_UserName == txtName.Text).ToList();
                Properties.Settings.Default.UserID = tbl[0].AdminAccess_ID;
                if (tbl[0].AdminAccess_PassWord == txtPassWord.Text)
                {
                    FrmMain frm = new FrmMain();
                    Hide();
                    frm.ShowDialog();
                    Close();
                }
                else 
                {
                    MessageBox.Show("رمز عبور اشتباه می باشد");
                }
            }
        }
    }
}
