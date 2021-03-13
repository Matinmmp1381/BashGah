using System;
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
        private int _width = 0;
        private string _imageName;
        private int? _num = 0;
        private int _flag, _timerflag = 0;
        public FrmManageMember()
        {
            InitializeComponent();
            pnlSubMenu.Size = new Size(0, 700);
            pnlSubMenu.Visible = false;
            dtGrid.AutoGenerateColumns = false;
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
                ActiveSubMenuBtn(btnSubDetail);


                timer1.Enabled = true;
                pnlSubMenu.Visible = true;

            }

        }

        private void LoadInfo()
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
            }
        }

        private void btnSubDetail_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
            txtPhoneNumber.Enabled = txtAddress.Enabled = txtBirthDay.Enabled =
            txtJoinDay.Enabled = txtValidDay.Enabled = txtName.Enabled = btnOpenPicture.Enabled = false;
            btnEdit.Visible = false;
        }


        private void btnSubEdite_Click(object sender, EventArgs e)
        {
            ActiveSubMenuBtn(sender);
            txtPhoneNumber.Enabled = txtAddress.Enabled = txtBirthDay.Enabled =
             txtJoinDay.Enabled = txtValidDay.Enabled = txtName.Enabled = btnOpenPicture.Enabled = true;
            btnEdit.Visible = true;
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
                    Tbl_Athlete tbl = new Tbl_Athlete()
                    {
                        Athlete_ID = _num.Value,
                        Athlete_Address = txtAddress.Text,
                        Athlete_FullName = txtName.Text,
                        Athlete_PhoneNumber = txtPhoneNumber.Text.ToString(),
                        Athlete_WardropNum = null,
                        Athlete_Image = _imageName,
                        Athlete_BirthDay = txtBirthDay.Text.ToString(),
                        Athlete_JoinDate = txtJoinDay.Text.ToString(),
                        Athlete_ValidityDate = txtValidDay.Text.ToString(),
                    };
                    gymDB.Entry(tbl).State = System.Data.Entity.EntityState.Modified;
                    gymDB.SaveChanges();
                    pctImage.Image.Save(path + _imageName);
                    MessageBox.Show("عملیات موفقیت آمیز بود");
                    dtGrid.DataSource = gymDB.Tbl_Athlete.ToList();
                    pnlSubMenu.Visible = false;
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
            _num = int.Parse(dtGrid.CurrentRow.Cells[0].Value.ToString());
            if (_num == null || _num == 0)
            {
                MessageBox.Show("لطفا یک ردیف را انتخاب کنید");
                return;
            }
            LoadInfo();
            if (_timerflag == 0)
            {
                ActiveSubMenuBtn(btnSubDetail);


                timer1.Enabled = true;
                pnlSubMenu.Visible = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _width += 10;
            pnlSubMenu.Size = new Size(_width, 700);

            if (_width >= 250)
            {
                timer1.Enabled = false;
                _timerflag = 1;
            }


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            _width -= 10;
            pnlSubMenu.Size = new Size(_width, 700);

            if (_width <= 0)
            {
                timer2.Enabled = false;
                _timerflag = 0;

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

