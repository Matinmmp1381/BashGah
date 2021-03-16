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
        }


        private void FrmCaseHistory_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void LoadData()
        {
            dtGrid.AutoGenerateColumns = false;

            using (DB_GymEntities dbGym = new DB_GymEntities())
            {
                var list = dbGym.Vw_Factor.ToList();

                if (!String.IsNullOrEmpty(txtSearchByName.Text))
                {
                    list = list.Where(c => c.Athlete_FullName.Contains(txtSearchByName.Text)).ToList();
                }
                if (!String.IsNullOrEmpty(txtSearchById.Text))
                {
                    list = list.Where(c => c.Factor_ID == int.Parse(txtSearchById.Text)).ToList();
                }
                dtGrid.DataSource = list;
            }
        }
        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
