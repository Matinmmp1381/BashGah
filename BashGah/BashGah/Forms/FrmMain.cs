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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            pnlGymMemberBtnHolder.Visible = pnlStoreBtnHolder.Visible = pnlWardrobebtnHolder.Visible = pnlTakeReport.Visible =
               pnlTakeReport.Visible = pnlSystemUsers.Visible = false;
            PnlR1 = new Panel();
            PnlR2 = new Panel();
            PnlR3 = new Panel();
            PnlR4 = new Panel();
            PnlR5 = new Panel();
            RightLittleSubBtnPnl = new Panel();
        }

        private void btnGymMember_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, ref btnGymMember, RGBColor.color1, ref count1, ref PnlR1, pnlGymMemberBtnHolder, 1);
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, ref btnStore, RGBColor.color2, ref count2, ref PnlR2, pnlStoreBtnHolder, 2);
        }

        private void btnWardRobe_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, ref btnWardRobe, RGBColor.color3, ref count3, ref PnlR3, pnlWardrobebtnHolder, 3);
        }

        private void btnTakeReport_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, ref btnTakeReport, RGBColor.color4, ref count4, ref PnlR4, pnlTakeReport, 5);
        }

        private void btnSystemUsers_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, ref btnSystemUsers, RGBColor.color5, ref count5, ref PnlR5, pnlSystemUsers, 4);
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender, RightLittleSubBtnPnl, RGBColor.color6, 1);
              OpenChildForm(new FrmAddMember());
        }

        private void btnManageMember_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender, RightLittleSubBtnPnl, RGBColor.color6, 1);
            OpenChildForm(new FrmManageMember());
        }

        private void btnCaseHistory_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender, RightLittleSubBtnPnl, RGBColor.color6, 1);
            OpenChildForm(new FrmCaseHistory());
        }

        private void BtnAddGoods_Click(object sender, EventArgs e)
        {
            
            ActiveSubMenuBtn(sender, RightLittleSubBtnPnl, RGBColor.color7, 2);
            OpenChildForm(new FrmAddGoods());
        }

        private void BtnEditeOrDeleteGoods_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender, RightLittleSubBtnPnl, RGBColor.color7, 2);
            OpenChildForm(new FrmManageGoods());
        }

        private void btnSaleGoods_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender, RightLittleSubBtnPnl, RGBColor.color7, 2);
        }

        private void btnManageWardrobe_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender, RightLittleSubBtnPnl, RGBColor.color8, 3);
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender, RightLittleSubBtnPnl, RGBColor.color9, 4);
        }

        private void btnTakeSuport_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender, RightLittleSubBtnPnl, RGBColor.color10, 5);
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender, RightLittleSubBtnPnl, RGBColor.color10, 5);
        }

        private void pctFitness_Click(object sender, EventArgs e)
        {
            DisableEveryThings();
            ActiveForm.Close();
        }
    }
}
