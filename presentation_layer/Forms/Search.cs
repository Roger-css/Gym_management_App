using Buisness_layer;
using GymBussniesLayer;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace presentation_layer
{
    public partial class SearchForm : Form
    {
        private readonly AutoComplete namesBank = new AutoComplete();
        private bool _autoComplete = true;
        public SearchForm()
        {
            InitializeComponent();

            Shown += Form_Shown;
            AutoCompleteList.DrawMode = DrawMode.OwnerDrawFixed;

            // Subscribe to the DrawItem event.
            AutoCompleteList.DrawItem += new DrawItemEventHandler(ListBox1_DrawItem);
            DgvList.SelectionChanged += DgvList_SelectionChanged;
        }

        private void DgvList_SelectionChanged(object sender, EventArgs e)
        {
            var item = CmsList.Items.Find("QuickAddMoney", true);
            var test = DgvList.CurrentRow.Cells[7];
            if (Convert.ToInt32(DgvList.CurrentRow.Cells[7].Value) == 0)
                item[0].Enabled = false;
            else
                item[0].Enabled = true;
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Clear the background and draw it in the default way.
            e.DrawBackground();
            string itemText = "";
            // Retrieve the item text.
            if (e.Index >= 0)
                itemText = AutoCompleteList.Items[e.Index].ToString();

            // Create a StringFormat object to specify the text alignment.
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Far, // Center horizontally
                LineAlignment = StringAlignment.Center // Center vertically
            };

            // Set the text color (highlighted if selected).
            Brush textBrush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                ? SystemBrushes.HighlightText
                : SystemBrushes.ControlText;

            // Draw the item text with custom alignment.
            e.Graphics.DrawString(itemText, e.Font, textBrush, e.Bounds, sf);

            // Draw the focus rectangle around the item.
            e.DrawFocusRectangle();
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
            AutoCompleteList.Visible = false;
            AutoCompleteList.Enabled = false;
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
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (!_autoComplete)
            {
                return;
            }

            if (TbSearch.Text.Length == 0)
            {
                HideAutoComplete();
                return;
            }
            var names = namesBank.GetAutoComplete(TbSearch.Text).ToArray();
            AutoCompleteList.Items.Clear();

            AutoCompleteList.Items.AddRange(names);
            if (AutoCompleteList.Items.Count > 0)
            {
                AutoCompleteList.Enabled = true;
                AutoCompleteList.Visible = true;
            }

        }
        private void HideAutoComplete()
        {
            AutoCompleteList.Enabled = false;
            AutoCompleteList.Visible = false;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SearchBtn_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void AutoCompleteSelected(object sender, EventArgs e)
        {
            var searchText = AutoCompleteList.SelectedItem.ToString();
            TbSearch.Text = searchText;
            HideAutoComplete();
        }

        private void ShowAutoCompleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _autoComplete = !_autoComplete;
        }
    }
}
