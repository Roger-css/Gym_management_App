using GymBussniesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation_layer.Forms
{
    public partial class PlayersList : Form
    {
        public PlayersList()
        {
            InitializeComponent();
        }
        private void RefreshList()
        {
            DgvList.DataSource = clsTrainee.GetTraineesAllSub();
            DgvList.ForeColor = Color.Black;
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GeneralMethods.ChangeColumnNames(ref DgvList);
        }
        private void PlayersList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (TbSearch.Text != string.Empty)
            {
                DgvList.DataSource = clsTrainee.GetTraineeAllSubsByName(TbSearch.Text);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
