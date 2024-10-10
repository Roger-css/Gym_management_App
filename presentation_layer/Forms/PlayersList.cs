using GymBussniesLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace presentation_layer.Forms
{
    public partial class PlayersList : Form
    {
        public PlayersList()
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
        private void RefreshList()
        {
            DgvList.DataSource = clsTrainee.GetTraineesAllSub();
            ChangeListColors();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (TbSearch.Text != string.Empty)
            {
                switch (CBSearch.SelectedItem.ToString())
                {
                    case "الاسم":
                        dt = clsTrainee.GetTraineeAllSubsByName(TbSearch.Text.Trim());
                        break;
                    case "رقم البطاقة":
                        if (!int.TryParse(TbSearch.Text, out int id))
                        {
                            MessageBox.Show("يرجى ادخال رقم صحيح");
                            return;
                        }
                        dt = clsTrainee.GetAllSubscriptionsByPlayerID(id);
                        break;
                    case "رقم الهاتف":
                        dt = clsTrainee.GetTraineeAllSubsByPhone(TbSearch.Text.Trim());
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

        private void PlayersList_Load(object sender, EventArgs e)
        {
            CBSearch.SelectedIndex = 0;
        }

        private void CBSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblSearchMethod.Text = $": {CBSearch.Text}";
        }
    }
}
