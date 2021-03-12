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
    public partial class FrmManageMember : Form
    {
        private IconButton iconBtn;
        public FrmManageMember()
        {
            InitializeComponent();
          //  pnlSubMenu.Visible = false;
            dtGrid.AutoGenerateColumns = false;
            using (DB_GymEntities gymDb = new DB_GymEntities())
            {
                dtGrid.DataSource = gymDb.Tbl_Athletes.ToList();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = false;
            btnOpenSubMenu.Visible = true;
        }

        private void btnOpenSubMenu_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = true;
            btnOpenSubMenu.Visible = false;
            pnlSub.Visible = false;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            int? num = int.Parse(dtGrid.CurrentRow.Cells[0].Value.ToString());
            if (num == null)
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
            }
            MessageBox.Show(num.ToString());
        }

        private void btnSubDetail_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
        }


        private void btnSubEdite_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
        }

        private void btnSubPayFee_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
        }

        private void btnSubDelete_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
        }

        private void ActiveSubMenuBtn(object sender)
        {
            DisableSubMenuBtn();
            if (sender != null)
            {
                iconBtn = (IconButton)sender;
                iconBtn.BackColor = Color.SteelBlue;
                iconBtn.ForeColor = iconBtn.IconColor = Color.Indigo;
            }
        }

        private void DisableSubMenuBtn()
        {
            if (iconBtn != null)
            {
                iconBtn.BackColor = Color.DeepSkyBlue;
                iconBtn.ForeColor = iconBtn.IconColor = Color.White;
            }
            
        }

       

        
    }
    }

