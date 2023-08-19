using GymBussniesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
        private void RefreshList()
        {
            DgvList.DataSource = clsTrainee.GetTraineesAllSub(); 
            DgvList.ForeColor = Color.Black;
            DgvList.Columns[8].DefaultCellStyle.ForeColor = Color.White;
            for (int i = 0; i < DgvList.Rows.Count; i++)
            {

                if (int.TryParse(DgvList.Rows[i].Cells[8].Value.ToString(), out int cellValue))
                {
                    if (cellValue < 0)
                    {
                        DgvList.Rows[i].Cells[8].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        DgvList.Rows[i].Cells[8].Style.BackColor = Color.Green;
                    }
                }
            }
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for(int i = 0;i < 9;i++)
            {
                DgvList.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; 
            }
            GeneralMethods.ChangeColumnNames(ref DgvList);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (TbSearch.Text != string.Empty)
            {
                DgvList.DataSource = clsTrainee.GetTraineeAllSubsByName(TbSearch.Text);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
