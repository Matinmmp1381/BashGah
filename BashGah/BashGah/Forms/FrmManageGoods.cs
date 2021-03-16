using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace BashGah.Forms
{
    public partial class FrmManageGoods : Form
    {
        private IconButton _iconBtn;
        private int _width = 0;
        private int? _num = 0;
        private int  _timerflag = 0;
        public FrmManageGoods()
        {
            InitializeComponent();
            pnlSubMenu.Size = new Size(_width,pnlSubMenu.Height);
            using (DB_GymEntities dbGym = new DB_GymEntities())
            {
                dtGrid.DataSource = dbGym.Tbl_Store.ToList(); 

            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            txtGoodsName.Enabled = txtInventory.Enabled = txtPrice.Enabled = false;
            btnEdit.Visible = false;
            
            ActiveSubMenuBtn(btnSubDetail);
            if (dtGrid.CurrentRow != null)
                _num = int.Parse(dtGrid.CurrentRow.Cells[0].Value.ToString());

            if (_num == null || _num == 0)
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
                return;
            }
            LoadInfo();
            if (_timerflag == 0)
            {
                timer1.Enabled = true;
                pnlSubMenu.Visible = true;

            }
        }

        private void LoadInfo()
        {
            try
            {
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {
                    var tbl = dbGym.Tbl_Store.Where(c => c.Store_FoodID == _num).ToList();
                    txtGoodsName.Text = tbl[0].Store_FoodName;
                    txtInventory.Value = int.Parse(tbl[0].Store_FoodInventory);
                    txtPrice.Value = int.Parse(tbl[0].Store_FoodPrice);
                }
            }
            catch
            {

                MessageBox.Show("مشکل رد نمایش اطلاعات");
            }

        }

        private void ActiveSubMenuBtn(object sender)
        {
            DisableSubMenuBtn();
            if (sender != null)
            {
                _iconBtn = (IconButton)sender;
                _iconBtn.BackColor = Color.Chartreuse;
               _iconBtn.ForeColor = _iconBtn.IconColor = Color.DarkGreen;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (_timerflag == 1)
            {
                DisableSubMenuBtn();
                timer2.Enabled = true;
            }
        }

        private void btnSubDetail_Click(object sender, EventArgs e)
        {
            txtGoodsName.Enabled = txtInventory.Enabled = txtPrice.Enabled = false;
            btnEdit.Visible = false;
            ActiveSubMenuBtn(sender);
           
            btnEdit.Visible = false;
            pnlSub.Visible = true;
        }

        private void btnSubEdite_Click(object sender, EventArgs e)
        {
            txtGoodsName.Enabled = txtInventory.Enabled = txtPrice.Enabled = true;
            btnEdit.Visible = true;
            ActiveSubMenuBtn(sender);
           
            btnEdit.Visible = true;
            pnlSub.Visible = true;
        }

        private void btnSubDelete_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
            if (MessageBox.Show("آیا از حذف این کاربر مطمن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {                   
                    dbGym.Tbl_Store.Remove(dbGym.Tbl_Store.Find(_num));
                    dbGym.SaveChanges();
                    dtGrid.DataSource = dbGym.Tbl_Store.ToList();
                }
                _timerflag = 0;
                _width = 0;
                pnlSubMenu.Size = new Size(_width, pnlSubMenu.Height);
                pnlSubMenu.Visible = false;
            }
        }

        

        private void DisableSubMenuBtn()
        {
            if (_iconBtn != null)
            {
                _iconBtn.BackColor = Color.LimeGreen;
                _iconBtn.ForeColor = _iconBtn.IconColor = Color.White;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _width -= 10;
            pnlSubMenu.Size = new Size(_width, pnlSubMenu.Height);

            if (_width <= 0)
            {
                timer2.Enabled = false;
                _timerflag = 0;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _width += 10;
            pnlSubMenu.Size = new Size(_width, pnlSubMenu.Height);

            if (_width >= 250)
            {
                timer1.Enabled = false;
                _timerflag = 1;
            }
        }

        private void dtGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGoodsName.Enabled = txtInventory.Enabled = txtPrice.Enabled = false;
            btnEdit.Visible = false;
            btnEdit.Visible = false;
            ActiveSubMenuBtn(btnSubDetail);            
            _num = int.Parse(dtGrid.CurrentRow.Cells[0].Value.ToString());
            if (_num == null || _num == 0)
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
                return;
            }
            LoadInfo();
            if (_timerflag == 0)
            {
                timer1.Enabled = true;
                pnlSubMenu.Visible = true;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {
                    var tbl = dbGym.Tbl_Store.Where(c => c.Store_FoodID == _num).ToList();
                    tbl[0].Store_FoodName = txtGoodsName.Text;
                    tbl[0].Store_FoodPrice = txtPrice.Value.ToString();
                    tbl[0].Store_FoodInventory = txtInventory.Value.ToString();
                    dbGym.SaveChanges();
                    dtGrid.DataSource = dbGym.Tbl_Store.ToList();
                }
                MessageBox.Show("عملیات موفقیت آمیز بود");
                _timerflag = 0;
                _width = 0;
                pnlSubMenu.Size = new Size(_width, pnlSubMenu.Height);
                
            }
            catch 
            {

                MessageBox.Show("عملیات موفقیت آمیز بود","اخطار");
            }
            
        }
    }
}
