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
    public partial class UncompleteSubs : Form
    {
        public UncompleteSubs()
        {
            InitializeComponent();
        }
        private void RefreshList()
        {
            DgvList.DataSource = clsSubscription.GetTraineesWithRemaining();
            DgvList.ForeColor = Color.Black;
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GeneralMethods.ChangeColumnNames(ref DgvList);
        }
        private void UncompleteSubs_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void PayTheRest_Click(object sender, EventArgs e)
        {
            GeneralMethods.QuickAddMoney_click(DgvList.CurrentRow.Cells[0].Value);
            RefreshList();
        }
    }
}
