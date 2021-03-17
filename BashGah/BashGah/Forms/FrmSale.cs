using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using System.Globalization;

namespace BashGah.Forms
{
    public partial class FrmSale : Form
    {
        private int _AthleteID, _GoodsID = 0;
        public FrmSale()
        {

            InitializeComponent();
            dtGridGoods.AutoGenerateColumns = false;
            dtGridAthlete.AutoGenerateColumns = false;
            using (DB_GymEntities dbGym = new DB_GymEntities())
            {
                dtGridAthlete.DataSource = dbGym.Tbl_Athlete.ToList();
                dtGridGoods.DataSource = dbGym.Tbl_Store.ToList();
            }
        }

        private void dtGridAthlete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGridAthlete.CurrentRow != null)
            {
                _AthleteID = int.Parse(dtGridAthlete.CurrentRow.Cells[0].Value.ToString());
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {
                    var tbl = dbGym.Tbl_Athlete.Where(c => c.Athlete_ID == _AthleteID).ToList();
                    lblAthleteName.Text = tbl[0].Athlete_FullName;
                }
                if (_AthleteID > 0 && _GoodsID > 0)
                {
                    btnEdit.Enabled = true;
                }
            }
            else
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید");
        }
           

        private void txtNumber_ValueChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = (int.Parse(lblPrice.Text) * txtNumber.Value).ToString();

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            string date = pc.GetYear(DateTime.Today).ToString("0000") + "/" + pc.GetMonth(DateTime.Today).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Today).ToString("00");
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    using (DB_GymEntities dbGym = new DB_GymEntities())
                    {
                        Tbl_Factor tblfactor = new Tbl_Factor()
                        {
                            Facotr_Price = int.Parse(lblTotalPrice.Text),
                            Athlete_ID = _AthleteID,
                            Factor_Type = "خرید از فروشگاه",
                            Factor_Date = date                            
                        };
                        
                        var tblstore = dbGym.Tbl_Store.Where(c => c.Store_FoodID == _GoodsID).ToList();
                        tblstore[0].Store_FoodID = _GoodsID;
                        tblstore[0].Store_FoodInventory = (int.Parse(tblstore[0].Store_FoodInventory) - txtNumber.Value).ToString();
                        dbGym.Tbl_Factor.Add(tblfactor);
                        dbGym.SaveChanges();
                        ts.Complete();
                      
                    }
                    MessageBox.Show("عملیات موفقیت آمیز بود");
                   
                }
            }
            catch
            {

                MessageBox.Show("عملیات موفقیت آمیز نبود");
            }
            using (DB_GymEntities dbGym = new DB_GymEntities())
            {
                dtGridGoods.DataSource = dbGym.Tbl_Store.ToList();
                dtGridAthlete.DataSource = dbGym.Tbl_Athlete.ToList();
                txtAthleteSearch.ResetText();
                txtGoodsSearch.ResetText();
                lblAthleteName.ResetText();
                lblGoodsName.ResetText();
                lblPrice.ResetText();
                lblTotalPrice.ResetText();
                btnEdit.Enabled = txtNumber.Enabled = false;
            }

        }

        private void txtAthleteSearch_TextChanged(object sender, EventArgs e)
        {
            using (DB_GymEntities dbGym = new DB_GymEntities())
            {
                var tbl = dbGym.Tbl_Athlete.Where(c => c.Athlete_FullName.Contains(txtAthleteSearch.Text)).ToList();
                dtGridAthlete.DataSource = tbl;
            }
        }

        private void txtGoodsSearch_TextChanged(object sender, EventArgs e)
        {
            using (DB_GymEntities dbGym = new DB_GymEntities())
            {
                var tbl = dbGym.Tbl_Store.Where(c => c.Store_FoodName.Contains(txtGoodsSearch.Text)).ToList();
                dtGridGoods.DataSource = tbl;
            }
        }

        private void dtGridGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGridGoods.CurrentRow != null)
            {
                _GoodsID = int.Parse(dtGridGoods.CurrentRow.Cells[0].Value.ToString());
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {
                    var tbl = dbGym.Tbl_Store.Where(c => c.Store_FoodID == _GoodsID).ToList();
                    lblGoodsName.Text = tbl[0].Store_FoodName;
                    lblPrice.Text = tbl[0].Store_FoodPrice;
                    lblTotalPrice.Text = tbl[0].Store_FoodPrice;
                    txtNumber.Maximum = int.Parse(tbl[0].Store_FoodInventory);
                }
                if (_GoodsID >= 0)
                {
                    txtNumber.Enabled = true;
                }
                if (_AthleteID > 0 && _GoodsID > 0)
                {
                    btnEdit.Enabled = true;
                }
            }
           else
                MessageBox.Show("لطفا یک کالا را انتخاب کنید");

        }


    }
}
