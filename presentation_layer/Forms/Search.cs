using GymBussniesLayer;
using presentation_layer.Forms.CmsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation_layer
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        public void RefreshList()
        {
            DgvList.DataSource = clsTrainee.GetTraineesLastSub();
            DgvList.ForeColor = Color.Black;
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GeneralMethods.ChangeColumnNames(ref DgvList);
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralMethods.EditToolStripMenuItem_Click(DgvList.CurrentRow.Cells[0].Value);
        }

        private void ManualSub_click(object sender, EventArgs e)
        {
            GeneralMethods.ManualSub_click(DgvList.CurrentRow.Cells[0].Value);
        }

        private void QuickSubBtn_Click(object sender, EventArgs e)
        {
            GeneralMethods.QuickSubBtn_Click(DgvList.CurrentRow.Cells[0].Value);
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if(TbSearch.Text != string.Empty)
            {
                DgvList.DataSource = clsTrainee.GetTraineeLastSub(TbSearch.Text);
            }
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void HandleEnter_key(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void QuickAddMoney_click(object sender, EventArgs e)
        {
            GeneralMethods.QuickAddMoney_click(DgvList.CurrentRow.Cells[0].Value);
        }
    }
}
