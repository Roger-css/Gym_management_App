using GymDataAccesLayer;
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
            DataTable dt = clsTraineeDataAccess.GetAllTrainees();
            DgvList.DataSource = dt;
            DgvList.ForeColor = Color.Black;
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in DgvList.Columns)
            {
                switch (column.Name)
                {
                    case "_id":
                        column.HeaderText = "رقم البطاقة";
                        break;
                    case "TraineeName":
                        column.HeaderText = "اسم اللاعب";
                        break;
                    case "Phone":
                        column.HeaderText = "رقم الهاتف";
                        break;
                    case "EnrollmentStart":
                        column.HeaderText = "تاريخ البداية";
                        break;
                    case "EnrollmentEnd":
                        column.HeaderText = "تاريخ النهاية";
                        break;
                    case "DayLeft":
                        column.HeaderText = "الايام المتبقية";
                        break;
                    case "TotalAmount":
                        column.HeaderText = "المبلغ الكلي";
                        break;
                    case "PaidAmount":
                        column.HeaderText = "المبلغ المدفوع";
                        break;
                    case "RemainingAmount":
                        column.HeaderText = "المبلغ المتبقي";
                        break;
                    case "Photo":
                        column.HeaderText = "الصورة";
                        break;
                }
            }
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
