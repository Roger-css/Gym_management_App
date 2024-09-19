using GymBussniesLayer;
using presentation_layer.Forms.CmsForms;
using System.Windows.Forms;

namespace presentation_layer
{
    internal class GeneralMethods
    {
        public static void EditToolStripMenuItem_Click(object value)
        {
            EditPlayer form = new EditPlayer((int)value);
            form.Show();
        }

        public static void ManualSub_click(object value, bool firstSub = false)
        {
            LongSubscriptionForm form = new LongSubscriptionForm((int)value, firstSub);
            form.Show();
        }
        public static void QuickSubBtn_Click(object value)
        {
            int _id = (int)value;
            if (MessageBox.Show("هل انت متأكد؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsTrainee.quickSubscribe(_id);
            }
        }
        public static void QuickAddMoney_click(object value)
        {
            int _id = (int)value;
            if (MessageBox.Show("هل انت متأكد؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsTrainee.AutoPayRemaining(_id);
            }
        }
        public static void ChangeColumnNames(ref DataGridView dataGrid)
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
        public static void DeleteSub(object value)
        {
            int _id = (int)value;
            if (MessageBox.Show("هل انت متأكد؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsTrainee.DeletePlayerSub(_id);
            }
        }
    }
}
