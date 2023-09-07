using presentation_layer.Forms.CmsForms;
using System;
using GymBussniesLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation_layer
{
    internal class GeneralMethods
    {
        static public void EditToolStripMenuItem_Click(object value)
        {
            EditPlayer form = new EditPlayer((int) value);
            form.Show();
        }

        static public void ManualSub_click(object value, bool firstSub = false)
        {
            LongSubscriptionForm form = new LongSubscriptionForm((int) value,firstSub);
            form.Show();
        }
        static public void QuickSubBtn_Click(object value)
        {
            int _id = (int)value;
            if (MessageBox.Show("هل انت متأكد؟","",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsTrainee.quickSubscribe(_id);
            }
        }
        static public void QuickAddMoney_click(object value)
        {
            int _id = (int)value;
            if (MessageBox.Show("هل انت متأكد؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsTrainee.AutoPayRemaining(_id);
            }
        }
        static public void ChangeColumnNames(ref DataGridView dataGrid)
        {
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                switch (column.Name)
                {
                    case "_id":
                        column.HeaderText = "رقم البطاقة";
                        break;
                    case "Name":
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
                    case "DaysTillSubscriptionExpired":
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
                }
            }
        }
        static public void DeleteSub(object value)
        {
            int _id = (int)value;
            if (MessageBox.Show("هل انت متأكد؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsTrainee.DeletePlayerSub(_id);
            }
        }
    }
}
