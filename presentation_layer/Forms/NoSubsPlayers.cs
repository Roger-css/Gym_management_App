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
            DgvList.Columns[0].Width = 60;
            DgvList.Columns[1].Width = 300;
        }

        private void CBSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblSearchMethod.Text = $": {CBSearch.Text}";
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void AddSub_Click(object sender, EventArgs e)
        {
            GeneralMethods.ManualSub_click(DgvList.CurrentRow.Cells[0].Value,true);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (TbSearch.Text != string.Empty)
            {
                switch (CBSearch.SelectedItem.ToString())
                {
                    case "الاسم":
                        dt = clsTrainee.GetPlayersWithOutSubsByName(TbSearch.Text.Trim());
                        break;
                    case "رقم البطاقة":
                        if (!int.TryParse(TbSearch.Text, out int id))
                        {
                            MessageBox.Show("يرجى ادخال رقم صحيح");
                            return;
                        }
                        dt = clsTrainee.GetPlayersWithOutSubsByID(id);
                        break;
                    default:
                        MessageBox.Show("حدث خطأ غير متوقع تواصل مع المطور");
                        break;
                }
            }
            DgvList.DataSource = dt;
        }
    }
}
