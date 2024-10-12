using GymBussniesLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace presentation_layer
{
    public partial class SearchForm : Form
    {
        private readonly Timer debounceTimer = new Timer();
        private readonly int debounceInterval = 500;
        public SearchForm()
        {
            InitializeComponent();

            Shown += Form_Shown;
            DgvList.SelectionChanged += DgvList_SelectionChanged;

            // Debounce functionality
            debounceTimer.Interval = debounceInterval;
            debounceTimer.Tick += DebounceTimer_Tick;
            TbSearch.TextChanged += TextBox_TextChanged;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            SearchBtn_Click();
        }
        private void DgvList_SelectionChanged(object sender, EventArgs e)
        {
            var item = CmsList.Items.Find("QuickAddMoney", true);
            if (Convert.ToInt32(DgvList.CurrentRow.Cells[7].Value) == 0)
                item[0].Enabled = false;
            else
                item[0].Enabled = true;
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
            if (DgvList.Rows.Count > 0)
                DgvList.Columns[9].DefaultCellStyle.ForeColor = Color.White;
            for (int i = 0; i < DgvList.Rows.Count; i++)
            {

                if (int.TryParse(DgvList.Rows[i].Cells[9].Value.ToString(), out int cellValue))
                {
                    if (cellValue < 0)
                    {
                        DgvList.Rows[i].Cells[9].Style.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        DgvList.Rows[i].Cells[9].Style.BackColor = Color.Green;
                    }
                }
            }
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (DgvList.Rows.Count != 0)
            {
                DgvList.Columns[0].Width = 80;
                DgvList.Columns[1].Width = 200;
                DgvList.Columns[8].Width = 200;
                DgvList.Columns[9].Width = 200;
            }
            GeneralMethods.ChangeColumnNames(ref DgvList);
        }
        public void RefreshList()
        {
            TbSearch.Text = string.Empty;
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
        private void SearchBtn_Click()
        {
            DataTable dt = new DataTable();
            var searchText = TbSearch.Text.Trim();
            if (searchText.Length == 0)
            {
                RefreshList();
                return;
            }
            if (TbSearch.Text != string.Empty)
            {
                switch (CBSearch.SelectedItem.ToString())
                {
                    case "الاسم":
                        dt = clsTrainee.GetTraineeLastSub(searchText);
                        break;
                    case "رقم البطاقة":
                        if (!int.TryParse(searchText, out int id))
                        {
                            MessageBox.Show("يرجى ادخال رقم صحيح");
                            return;
                        }
                        dt = clsTrainee.GetLastSubscriptionByPlayerIDWithoutPhoto(id);
                        break;
                    case "رقم الهاتف":
                        dt = clsTrainee.GetTraineeLastSubByPhone(searchText);
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

        private void CBSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblSearchMethod.Text = $": {CBSearch.Text}";
        }

        private void DeleteSub_Click(object sender, EventArgs e)
        {
            GeneralMethods.DeleteSub(DgvList.CurrentRow.Cells[0].Value);
            RefreshList();
        }
    }
}
