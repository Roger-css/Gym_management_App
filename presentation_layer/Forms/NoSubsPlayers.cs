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
    public partial class NoSubsPlayers : Form
    {
        public NoSubsPlayers()
        {
            InitializeComponent();
        }
        public void RefreshList()
        {
            DgvList.DataSource = clsTrainee.GetPlayersWithOutSubs();
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvList.ForeColor = Color.Black;
            GeneralMethods.ChangeColumnNames(ref DgvList);
        }
        private void NoSubsPlayers_Load(object sender, EventArgs e)
        {
            RefreshList();
            CBSearch.SelectedIndex = 0;
        }

        private void CBSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblSearchMethod.Text = $": {CBSearch.Text}";
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
