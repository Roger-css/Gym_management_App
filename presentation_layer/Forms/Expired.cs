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
    public partial class Expired : Form
    {
        public Expired()
        {
            InitializeComponent();
        }
        private void RefreshList()
        {
            DgvList.DataSource = clsTrainee.GetTraineesExpiredSubscription();
            DgvList.ForeColor = Color.Black;
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (DgvList.Rows.Count != 0)
            {
                DgvList.Columns[0].Width = 80;
                DgvList.Columns[1].Width = 300;
                DgvList.Columns[8].Width = 300;
            }
            GeneralMethods.ChangeColumnNames(ref DgvList);
        }
        private void Expired_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void QuickSub_Click(object sender, EventArgs e)
        {
            GeneralMethods.QuickSubBtn_Click(DgvList.CurrentRow.Cells[0].Value);
            RefreshList();
        }

        private void ManualSub_Click(object sender, EventArgs e)
        {
            GeneralMethods.ManualSub_click(DgvList.CurrentRow.Cells[0].Value);
            RefreshList();
        }
    }
}