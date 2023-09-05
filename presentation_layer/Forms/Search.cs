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

            Shown += Form_Shown;
        }
        private void Form_Shown(object sender, EventArgs e)
        {
            RefreshList();
            for (int i = 0; i < DgvList.ColumnCount; i++)
            {
                DgvList.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void ChangeListColors()
        {
            DgvList.ForeColor = Color.Black;
            if(DgvList.Rows.Count > 0)
                DgvList.Columns[8].DefaultCellStyle.ForeColor = Color.White;
            for (int i = 0; i < DgvList.Rows.Count; i++)
            {

                if (int.TryParse(DgvList.Rows[i].Cells[8].Value.ToString(), out int cellValue))
                {
                    if (cellValue < 0)
                    {
                        DgvList.Rows[i].Cells[8].Style.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        DgvList.Rows[i].Cells[8].Style.BackColor = Color.Green;
                    }
                }
            }
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GeneralMethods.ChangeColumnNames(ref DgvList);
        }
        public void RefreshList()
        {
            DgvList.DataSource = clsTrainee.GetTraineesLastSub();
            ChangeListColors();
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralMethods.EditToolStripMenuItem_Click(DgvList.CurrentRow.Cells[0].Value);
            RefreshList();
        }

        private void ManualSub_click(object sender, EventArgs e)
        {
            GeneralMethods.ManualSub_click(DgvList.CurrentRow.Cells[0].Value);
            RefreshList();
        }

        private void QuickSubBtn_Click(object sender, EventArgs e)
        {
            GeneralMethods.QuickSubBtn_Click(DgvList.CurrentRow.Cells[0].Value);
            RefreshList();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (TbSearch.Text != string.Empty)
            {
                switch (CBSearch.SelectedItem.ToString())
                {
                    case "الاسم":
                        dt = clsTrainee.GetTraineeLastSub(TbSearch.Text.Trim());
                        ChangeListColors();
                        break;
                    case "رقم البطاقة":
                        if (!int.TryParse(TbSearch.Text, out int id))
                        {
                            MessageBox.Show("يرجى ادخال رقم صحيح");
                            return;
                        }
                        dt = clsTrainee.GetLastSubscriptionByPlayerIDWithoutPhoto(id);
                        break;
                    case "رقم الهاتف":
                        dt = clsTrainee.GetTraineeLastSubByPhone(TbSearch.Text.Trim());
                        break;
                    default:
                        MessageBox.Show("حدث خطأ غير متوقع تواصل مع المطور");
                        break;
                }
            }
            DgvList.DataSource = dt;
            ChangeListColors();
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void QuickAddMoney_click(object sender, EventArgs e)
        {
            GeneralMethods.QuickAddMoney_click(DgvList.CurrentRow.Cells[0].Value);
            RefreshList();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            CBSearch.SelectedIndex = 0;
        }
    }
}
