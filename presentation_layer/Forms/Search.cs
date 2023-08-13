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
            DataTable dt = clsTrainee.GetTraineesLastSub();
            DgvList.DataSource = dt;
            DgvList.ForeColor = Color.Black;
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GeneralMethods.ChangeColumnNames(ref DgvList);
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPlayer form = new EditPlayer((int) DgvList.CurrentRow.Cells[0].Value);
            form.Show();
        }

        private void ManualSub_click(object sender, EventArgs e)
        {
            LongSubscriptionForm form = new LongSubscriptionForm((int)DgvList.CurrentRow.Cells[0].Value);
            form.Show();
        }

        private void QuickSubBtn_Click(object sender, EventArgs e)
        {
            // do a quick subscription method here
        }
    }
}
