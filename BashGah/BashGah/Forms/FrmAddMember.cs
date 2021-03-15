using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace BashGah.Forms
{
    public partial class FrmAddMember : Form
    {
        private string _imageName;
        
        private int _flag = 0;
        public FrmAddMember()
        {
            InitializeComponent();
            Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                    string guid = Guid.NewGuid().ToString();
                    if (_flag == 1)
                    {
                        _imageName = guid+ Path.GetExtension(pctImage.ImageLocation);
                    }
                    else
                    {
                        _imageName = guid + ".png";
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

                        Athlete_Address = txtAddress.Text,
                        Athlete_FullName = txtName.Text,
                        Athlete_PhoneNumber = txtPhoneNumber.Text.ToString(),
                        Athlete_WardropNum = null,
                        Athlete_Image = _imageName,
                        Athlete_BirthDay = txtBirthDay.Text.ToString(),
                        Athlete_JoinDate = txtJoinDay.Text.ToString(),
                        Athlete_ValidityDate = txValidDay.Text.ToString(),
                        Athlete_Barcod = "_Barcode_" + guid + ".png"
                    };
                    gymDB.Tbl_Athlete.Add(tbl);
                    gymDB.SaveChanges();
                    //Make Barcode
                    barCodeCtrl.BarCode = tbl.Athlete_ID.ToString();
                    barCodeCtrl.SaveImage(path + "_Barcode_" + guid + ".png");
                    //
                    pctImage.Image.Save(path + _imageName);
                    MessageBox.Show("عملیات موفقیت آمیز بود");
                    Reset();
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

        private void Reset()
        {
            txtAddress.Text = txtName.Text = txtPhoneNumber.Text = String.Empty;
            pctImage.Image = Properties.Resources.profile;
            txtBirthDay.ResetText();
            txtJoinDay.ResetText();
            txValidDay.ResetText();
        }
    }
}





