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
    public partial class FrmCaseHistory : Form
    {
        public FrmCaseHistory()
        {
            InitializeComponent();
            dtGrid.AutoGenerateColumns = false;
            using (DB_GymEntities dbGym = new DB_GymEntities())
            {

                dtGrid.DataSource = dbGym.Vw_Factor.ToList();
            }
        }

        private void LoadInf()
        {
            dtGrid.AutoGenerateColumns = false;
            try
            {
                using (DB_GymEntities dbGym = new DB_GymEntities())
                {
                    var list = dbGym.Vw_Factor.ToList();

                    if (!String.IsNullOrEmpty(txtSearchName.Text))
                    {
                        list = list.Where(c => c.Athlete_FullName.Contains(txtSearchName.Text)).ToList();
                    }
                    if (!String.IsNullOrEmpty(txtSearchID.Text))
                    {
                        list = list.Where(c => c.Factor_ID == int.Parse(txtSearchID.Text)).ToList();
                    }
                    dtGrid.DataSource = list;
                }
            }
            catch
            {
            }


        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            LoadInf();
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            LoadInf();
        }
    }
}
