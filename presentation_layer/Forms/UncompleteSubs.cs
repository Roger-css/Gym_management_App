using GymBussniesLayer;
using System;
using System.Drawing;
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
            if (DgvList.Rows.Count != 0)
            {
                DgvList.Columns[0].Width = 30;
                DgvList.Columns[1].Width = 120;
            }
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
