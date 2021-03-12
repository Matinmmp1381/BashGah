using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace BashGah.Forms
{
    partial class FrmMain
    {
        private Form ActiveForm;
        private int RecegnizeSubBtn, RecegniseMainBtn;
        private IconButton CurrentBtn;
        private IconButton CurrentSubIconBtn;
        private Panel CurrentPanel;
        private int count1, count2, count3, count4, count5 = 0;
        private Panel PnlR1, PnlR2, PnlR3, PnlR4, PnlR5;
        private Panel RightLittleSubBtnPnl;
        private List<IconButton> IconbtnList = new List<IconButton>();
        private void ActiveBtn(object sender, ref IconButton iconBtn, Color color, ref int count, ref Panel rightlittlepanel, Panel subPanel, int recegnize)
        {

            RecegniseMainBtn = recegnize;
            if (sender != null && count == 0)
            {

                IconbtnList.Add((IconButton)sender);
                count = 1;
                iconBtn = (IconButton)sender;
                CurrentBtn = iconBtn;
                iconBtn.ImageAlign = ContentAlignment.MiddleLeft;
                iconBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconBtn.IconSize = 38;
                iconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                iconBtn.ForeColor = color;
                iconBtn.IconColor = color;
                iconBtn.BackColor = Color.FromArgb(50, 50, 80);
                //
                ActiveSubMenuPanel(subPanel);
                //
                ActiveRightLittlePanel(iconBtn, rightlittlepanel, color, 6);
                //
                pctHome.IconChar = iconBtn.IconChar;
                pctHome.ForeColor = iconBtn.ForeColor;
                lblHome.Text = iconBtn.Text;
                lblHome.ForeColor = iconBtn.ForeColor;
                pctSubBtn.IconChar = IconChar.None;
                lblSubBtn.Text = null;
                DisablSubMenuBtn(CurrentSubIconBtn);
            }
            else
            {
                IconbtnList.Remove((IconButton)sender);
                if (IconbtnList.Count() > 0)
                {
                    {
                        pctHome.ForeColor = lblHome.ForeColor = IconbtnList[IconbtnList.Count() - 1].ForeColor;
                        pctHome.IconChar = IconbtnList[IconbtnList.Count() - 1].IconChar;
                        lblHome.Text = IconbtnList[IconbtnList.Count() - 1].Text;
                        lblSubBtn.Text = null;
                        pctSubBtn.IconChar = IconChar.None;
                    }
                }
                else
                {
                    pctHome.IconChar = IconChar.Home;
                    pctHome.ForeColor = Color.FromArgb(255, 128, 128);
                    lblHome.Text = "خانه";
                    lblHome.ForeColor = Color.FromArgb(255, 128, 128);
                    pctSubBtn.IconChar = IconChar.None;
                    lblSubBtn.Text = null;
                }

                Disablebtn(iconBtn);
                DisablePanel(subPanel);
                rightlittlepanel.Visible = false;
                count = 0;
                CheckRecegnize();
            }
        }
        private void Disablebtn(IconButton iconBtn)
        {
            if (iconBtn != null)
            {
                iconBtn.IconSize = 34;
                iconBtn.ImageAlign = ContentAlignment.MiddleRight;
                iconBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                iconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                iconBtn.ForeColor = Color.White;
                iconBtn.IconColor = Color.White;
                iconBtn.BackColor = Color.FromArgb(40, 40, 60);
            }
        }

        private void ActiveRightLittlePanel(IconButton iconBtn, Panel rightlittlepanel, Color color, int size)
        {
            rightlittlepanel.BackColor = color;
            rightlittlepanel.Dock = DockStyle.Right;
            rightlittlepanel.Size = new Size(size, iconBtn.Size.Height);
            iconBtn.Controls.Add(rightlittlepanel);
            rightlittlepanel.Location = new Point();
            rightlittlepanel.Location = new Point(iconBtn.Location.X, iconBtn.Location.Y);
            rightlittlepanel.Visible = true;
            rightlittlepanel.BringToFront();
        }
        private void DisableRightLittlePanle(Panel panel)
        {
            panel.Visible = false;
        }
        private void ActiveSubMenuBtn(object sender, Panel rightlittlepanel, Color color, int recegnize)
        {
            if (sender != null)
            {
                RecegnizeSubBtn = recegnize;
                DisablSubMenuBtn(CurrentSubIconBtn);
                CurrentSubIconBtn = (IconButton)sender;
                CurrentSubIconBtn.BackColor = Color.FromArgb(40, 40, 50);
                CurrentSubIconBtn.ImageAlign = ContentAlignment.MiddleLeft;
                CurrentSubIconBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentSubIconBtn.IconSize = 30;
                CurrentSubIconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                CurrentSubIconBtn.ForeColor = color;
                CurrentSubIconBtn.IconColor = color;

                //
                ActiveRightLittlePanel(CurrentSubIconBtn, rightlittlepanel, color, 3);
                //
                pctSubBtn.IconChar = CurrentSubIconBtn.IconChar;
                pctSubBtn.ForeColor = CurrentSubIconBtn.ForeColor;
                lblSubBtn.Text = CurrentSubIconBtn.Text;
                lblSubBtn.ForeColor = CurrentSubIconBtn.ForeColor;
                //
                ActivePctSubBtn();
            }
        }
     
        private void ActivePctSubBtn()
        {
            switch (RecegnizeSubBtn)
            {
                case 1:
                    {
                        SetPctHomeProp(btnGymMember);
                        break;
                    }
                case 2:
                    {
                        SetPctHomeProp(btnStore);
                        break;
                    }

                case 3:
                    {
                        SetPctHomeProp(btnWardRobe);
                        break;
                    }
                case 4:
                    {
                        SetPctHomeProp(btnSystemUsers);
                        break;
                    }
                case 5:
                    {
                        SetPctHomeProp(btnTakeReport);
                        break;
                    }
            }
        }
        private void SetPctHomeProp(IconButton IconBtn)
        {
            pctHome.IconChar = IconBtn.IconChar;
            pctHome.ForeColor = IconBtn.ForeColor;
            lblHome.Text = IconBtn.Text;
            lblHome.ForeColor = IconBtn.ForeColor;
        }
        private void DisablSubMenuBtn(IconButton iconBtn)
        {
            if (iconBtn != null)
            {
                DisableRightLittlePanle(RightLittleSubBtnPnl);
                iconBtn.IconSize = 26;
                iconBtn.ImageAlign = ContentAlignment.MiddleRight;
                iconBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                iconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                iconBtn.ForeColor = Color.White;
                iconBtn.IconColor = Color.White;
                iconBtn.BackColor = Color.FromArgb(40, 40, 40);
            }
        }
        private void ActiveSubMenuPanel(Panel panel)
        {
            panel.Visible = true;
        }
        private void DisablePanel(Panel panel)
        {
            panel.Visible = false;
        }
        private void CheckRecegnize()
        {
            if (RecegniseMainBtn == 1 && RecegnizeSubBtn == 1)
            {
                ActiveForm.Close();
                DisablSubMenuBtn(CurrentSubIconBtn);
            }
            else if (RecegniseMainBtn == 2 && RecegnizeSubBtn == 2)
            {
                ActiveForm.Close();
                DisablSubMenuBtn(CurrentSubIconBtn);
            }
            else if (RecegniseMainBtn == 3 && RecegnizeSubBtn == 3)
            {
                ActiveForm.Close();
                DisablSubMenuBtn(CurrentSubIconBtn);
            }
            else if (RecegniseMainBtn == 4 && RecegnizeSubBtn == 4)
            {
                ActiveForm.Close();
                DisablSubMenuBtn(CurrentSubIconBtn);
            }
            else if (RecegniseMainBtn == 5 && RecegnizeSubBtn == 5)
            {
                ActiveForm.Close();
                DisablSubMenuBtn(CurrentSubIconBtn);
            }
            else
            {
                pctSubBtn.IconChar = IconChar.None;
                lblSubBtn.Text = null;
            }
        }
        private void DisableEveryThings()
        {
            count1 = count2 = count3 = count4 = count5 = 0;
            IconbtnList.Clear();
            DisablePanel(pnlGymMemberBtnHolder);
            DisablePanel(pnlStoreBtnHolder);
            DisablePanel(pnlWardrobebtnHolder);
            DisablePanel(pnlTakeReport);
            DisablePanel(pnlSystemUsers);
            Disablebtn(btnGymMember);
            Disablebtn(btnStore);
            Disablebtn(btnWardRobe);
            Disablebtn(btnSystemUsers);
            Disablebtn(btnTakeReport);
            DisablePanel(PnlR1);
            DisablePanel(PnlR2);
            DisablePanel(PnlR3);
            DisablePanel(PnlR4);
            DisablePanel(PnlR5);
            pctHome.ForeColor = lblHome.ForeColor = Color.FromArgb(255, 128, 128);
            pctHome.IconChar = IconChar.Home;
            lblHome.Text = "خانه";
            pctSubBtn.IconChar = IconChar.None;
            lblSubBtn.Text = null;
        }

        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = childForm;

            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelFormParents.Controls.Add(childForm);
            panelFormParents.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private struct RGBColor
        {
            public static Color color1 = Color.DeepSkyBlue;
            public static Color color2 = Color.LimeGreen;
            public static Color color3 = Color.Orange;
            public static Color color4 = Color.Red;
            public static Color color5 = Color.DarkViolet;
            public static Color color6 = Color.Aqua;
            public static Color color7 = Color.SpringGreen;
            public static Color color8 = Color.Yellow;
            public static Color color9 = Color.Fuchsia;
            public static Color color10 = Color.FromArgb(240, 40, 60);
        }
    }
}

