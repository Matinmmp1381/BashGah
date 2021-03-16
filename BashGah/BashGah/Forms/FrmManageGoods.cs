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
        private int _width = 0;
        private int? _num;
        private int _flag, _timerflag;
        private IconButton _iconBtn;
        public FrmManageGoods()
        {
            InitializeComponent();
            using (DB_GymEntities dbGym = new DB_GymEntities())
            {
                dtGrid.DataSource = dbGym.Tbl_Store.ToList();
            }
            pnlSubMenu.Size = new Size(_width, pnlSubMenu.Height);
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (_timerflag == 1)
            {
                timer2.Enabled = true;
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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            pnlSub.Size = new Size(pnlSubMenu.Width, pnlSubMenu.Height);
            txtName.Enabled = txtprice.Enabled = txtInventory.Enabled = false;
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

        private void btnSubDetail_Click(object sender, EventArgs e)
        {
            txtName.Enabled = txtprice.Enabled = txtInventory.Enabled = false;
            btnEdit.Visible = false;
            ActiveSubMenuBtn(sender);
        }

        private void btnSubEdite_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            txtName.Enabled = txtprice.Enabled = txtInventory.Enabled = true;
            ActiveSubMenuBtn(sender);
        }

        private void btnSubDelete_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
            try
            {
                if (MessageBox.Show("آیا از حذف این مورد مطمن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (DB_GymEntities dbGym = new DB_GymEntities())
                    {
                        dbGym.Tbl_Store.Remove(dbGym.Tbl_Store.Find(_num));
                        dbGym.SaveChanges();
                        dtGrid.DataSource = dbGym.Tbl_Store.ToList();
                    }

                }
                _timerflag = 0;
                _width = 0;
                pnlSubMenu.Size = new Size(_width, pnlSubMenu.Height);
                pnlSubMenu.Visible = false;
            }
            catch 
            {

                
            }
        }

        private void dtGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Enabled = txtprice.Enabled = txtInventory.Enabled = false;
            btnEdit.Visible = false;
            ActiveSubMenuBtn(btnSubDetail);
            pnlSub.Size = new Size(pnlSubMenu.Width, pnlSubMenu.Height);

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

        private void DisableSubMenuBtn()
        {
            if (_iconBtn != null)
            {
                _iconBtn.BackColor = Color.LimeGreen;
                _iconBtn.ForeColor = _iconBtn.IconColor = Color.White;
            }

        }
        private void LoadInfo()
        {
            try
            {
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {
                    var tbl = dbGym.Tbl_Store.Where(c => c.Store_FoodID == _num).ToList();
                    txtName.Text = tbl[0].Store_FoodName;
                    txtprice.Value = int.Parse(tbl[0].Store_FoodPrice);
                    txtInventory.Value = int.Parse(tbl[0].Store_FoodInventory);
                }
            }
            catch
            {

                MessageBox.Show("مشکل رد نمایش اطلاعات");
            }
        }
    }
}
