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
    public partial class FrmManageAdmin : Form
    {
        public FrmManageAdmin()
        {
            
            InitializeComponent();
            dtGrid.AutoGenerateColumns = false;
            using (DB_GymEntities dbGym = new DB_GymEntities())
            {
                dtGrid.DataSource = dbGym.Tbl_AdminAccess.ToList();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtPass.Text) || String.IsNullOrEmpty(txtPass2.Text))
            {
                MessageBox.Show("لطفا همه ی قسمت ها را پر کنید");
                return;
            }
            if (txtPass2.Text != txtPass.Text)
            {
                MessageBox.Show("رمز های عبور طتابق ندارد");
                return;
            }
            try
            {
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {
                    Tbl_AdminAccess tbl = new Tbl_AdminAccess()
                    {
                        AdminAccess_UserName = txtName.Text,
                        AdminAccess_PassWord = txtPass.Text,
                        AdminAccess_AddMember = (cbAddMember.Checked == true) ? true : false,
                        AdminAccess_AddGoods = (cbAddGoods.Checked == true) ? true : false,
                        AdminAccess_BackUp = (cbBackUp.Checked == true) ? true : false,
                        AdminAccess_CaseHistory = (cbCaseHistory.Checked == true) ? true : false,
                        AdminAccess_ManageAdmin = (cbManageAccess.Checked == true) ? true : false,
                        AdminAccess_ManageGoods = (cbManageGoods.Checked == true) ? true : false,
                        AdminAccess_ManageMember = (cbManageMember.Checked == true) ? true : false,
                        AdminAccess_ManageWardRobe = (cbManageWardrobe.Checked == true) ? true : false,
                        AdminAccess_Restore = (cbReStore.Checked == true) ? true : false,
                        AdminAccess_SaleGoods = (cbSaleGoods.Checked == true) ? true : false,
                    };
                    dbGym.Tbl_AdminAccess.Add(tbl);
                    dbGym.SaveChanges();
                    MessageBox.Show("عملیات موفقیت آمیز بود");
                    dtGrid.DataSource = dbGym.Tbl_AdminAccess.ToList();
                }
            }

            catch
            {

                MessageBox.Show("عملیات موفقیت آمیز نبود");
            }

        }
    }
}