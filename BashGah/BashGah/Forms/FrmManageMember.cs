using System;
using System.Transactions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string _fullname;
        private string _validay;
        private int _width = 0;
        private string _imageName;
        private int? _num = 0;
        private int _flag, _timerflag = 0;
        public FrmManageMember()
        {
            InitializeComponent();
            pnlSubMenu.Size = new Size(0, pnlSubMenu.Height);
            pnlSubMenu.Visible = false;
            dtGrid.AutoGenerateColumns = false;
            pnlPayMent.Visible = false;
            using (DB_GymEntities gymDb = new DB_GymEntities())
            {
                dtGrid.DataSource = gymDb.Tbl_Athlete.ToList();
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

        private void btnOpenSubMenu_Click(object sender, EventArgs e)
        {
            pnlSubMenu.Visible = true;

            pnlSub.Visible = false;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Enabled = txtAddress.Enabled = txtBirthDay.Enabled =
            txtJoinDay.Enabled = txtValidDay.Enabled = txtName.Enabled = btnOpenPicture.Enabled = false;
            btnEdit.Visible = false;
            pnlSub.Size = new Size(pnlSubMenu.Width, pnlSubMenu.Height);
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
                    var tbl = dbGym.Tbl_Athlete.Where(c => c.Athlete_ID == _num).ToList();
                    txtName.Text = tbl[0].Athlete_FullName;
                    txtAddress.Text = tbl[0].Athlete_Address;
                    txtBirthDay.Text = tbl[0].Athlete_BirthDay;
                    txtJoinDay.Text = tbl[0].Athlete_JoinDate;
                    txtValidDay.Text = tbl[0].Athlete_ValidityDate;
                    txtPhoneNumber.Text = tbl[0].Athlete_PhoneNumber;
                    pctImage.ImageLocation = Application.StartupPath + "/Images/" + tbl[0].Athlete_Image;
                    _fullname = tbl[0].Athlete_FullName;
                    _validay = tbl[0].Athlete_ValidityDate;
                }
            }
            catch
            {

                MessageBox.Show("مشکل رد نمایش اطلاعات");
            }

        }

        private void btnSubDetail_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
            txtPhoneNumber.Enabled = txtAddress.Enabled = txtBirthDay.Enabled =
            txtJoinDay.Enabled = txtValidDay.Enabled = txtName.Enabled = btnOpenPicture.Enabled = false;
            btnEdit.Visible = false;
            pnlSub.Visible = true;
            pnlPayMent.Visible = false;
        }


        private void btnSubEdite_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
            txtPhoneNumber.Enabled = txtAddress.Enabled = txtBirthDay.Enabled =
             txtJoinDay.Enabled = txtValidDay.Enabled = txtName.Enabled = btnOpenPicture.Enabled = true;
            btnEdit.Visible = true;
            pnlSub.Visible = true;
            pnlPayMent.Visible = false;
        }

        private void btnSubPayFee_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
            pnlSub.Visible = false;
            pnlPayMent.Visible = true;
            txtFeeName.Text = _fullname;
            txtValidDayFee.Text = _validay;
            txtFee.Value = int.Parse(Properties.Settings.Default.Fee);
        }

        private void btnSubDelete_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
            if (MessageBox.Show("آیا از حذف این کاربر مطمن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.OK)
            {
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {
                    var tbl = dbGym.Tbl_Athlete.Where(c => c.Athlete_ID == _num).ToList();
                    File.Delete(Application.StartupPath + "/Images/" + tbl[0].Athlete_Image);
                    dbGym.Tbl_Athlete.Remove(dbGym.Tbl_Athlete.Find(_num));
                    dbGym.SaveChanges();
                    dtGrid.DataSource = dbGym.Tbl_Athlete.ToList();
                }
                _timerflag = 0;
                _width = 0;
                pnlSubMenu.Size = new Size(_width, pnlSubMenu.Height);
                pnlSubMenu.Visible = false;
            }

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

        private void btnEdit_Click(object sender, EventArgs e)
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
                    if (_flag == 1)
                    {
                        _imageName = Guid.NewGuid().ToString() + Path.GetExtension(pctImage.ImageLocation);
                    }
                    else
                    {
                        _imageName = Guid.NewGuid().ToString() + ".png";
                        _flag = 0;
                    }
                    string path = Application.StartupPath + "/Images/";
                    if (Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    pctImage.Image.Save(path + _imageName);
                    var tblr = gymDB.Tbl_Athlete.Where(c => c.Athlete_ID == _num).ToList();
                    File.Delete(Application.StartupPath + "/Images/" + tblr[0].Athlete_Image);
                    var tbl = gymDB.Tbl_Athlete.Where(c => c.Athlete_ID == _num).ToList();

                    tbl[0].Athlete_ID = _num.Value;
                    tbl[0].Athlete_Address = txtAddress.Text;
                    tbl[0].Athlete_FullName = txtName.Text;
                    tbl[0].Athlete_PhoneNumber = txtPhoneNumber.Text.ToString();
                    tbl[0].Athlete_WardropNum = null;
                    tbl[0].Athlete_Image = _imageName;
                    tbl[0].Athlete_BirthDay = txtBirthDay.Text.ToString();
                    tbl[0].Athlete_JoinDate = txtJoinDay.Text.ToString();
                    tbl[0].Athlete_ValidityDate = txtValidDay.Text.ToString();

                    gymDB.SaveChanges();

                    pctImage.Image.Save(path + _imageName);
                    MessageBox.Show("عملیات موفقیت آمیز بود");
                    dtGrid.DataSource = gymDB.Tbl_Athlete.ToList();
                    pnlSubMenu.Visible = false;
                    _width = 0;
                    _timerflag = 0;
                    pnlSubMenu.Size = new Size(_width, pnlSubMenu.Height);

                };
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
                MessageBox.Show("عملیات موفقیت آمیز نبود");
            }
        }

        private void btnOpenPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "image File (*.jpg;*.png) | *.jpg;*.png;";
            openFile.Title = "انتخاب عکس";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pctImage.ImageLocation = openFile.FileName;
                _flag = 1;
            }
        }

        private void dtGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPhoneNumber.Enabled = txtAddress.Enabled = txtBirthDay.Enabled =
            txtJoinDay.Enabled = txtValidDay.Enabled = txtName.Enabled = btnOpenPicture.Enabled = false;
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

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    using (DB_GymEntities dbGym = new DB_GymEntities())
                    {
                        var tblAthlete = dbGym.Tbl_Athlete.Where(c => c.Athlete_ID == _num).ToList();
                        tblAthlete[0].Athlete_ValidityDate = txtValidDayFee.Text;

                        Tbl_Factor tblFactor = new Tbl_Factor()
                        {
                            Facotr_Price = int.Parse(txtFee.Value.ToString()),
                            Factor_Date = txtValidDayFee.Text,
                            Factor_Type = "شهریه",
                            Athlete_ID = _num.Value
                        };
                        dbGym.Tbl_Factor.Add(tblFactor);
                        dbGym.SaveChanges();
                    }
                    ts.Complete();
                    Properties.Settings.Default.Fee = txtFee.Value.ToString();
                }
                _width = 0;
                pnlSubMenu.Size = new Size(_width, pnlSubMenu.Height);
                pnlSub.Visible = true;
                pnlPayMent.Visible = false;
                _timerflag = 0;
                Properties.Settings.Default.Fee = txtFee.Value.ToString();
            }
            catch
            {
                MessageBox.Show("عملیات موفقیت آمیز نبود");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (DB_GymEntities dbGym = new DB_GymEntities())
            {
                var list = dbGym.Tbl_Athlete.Where(c => c.Athlete_FullName.Contains(txtSearch.Text)).ToList();
                dtGrid.DataSource = list;
            }
        }
    }
}


