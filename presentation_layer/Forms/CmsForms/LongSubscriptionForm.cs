using GymBussniesLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace presentation_layer.Forms.CmsForms
{
    public partial class LongSubscriptionForm : Form
    {
        private readonly int _id = -1;
        private readonly bool _firstSub;
        public LongSubscriptionForm(int id = -1, bool firstSub = false)
        {
            InitializeComponent();
            _id = id;
            _firstSub = firstSub;
            if (firstSub)
            {
                LblName.Text = clsTrainee.Find(id).Name;
            }
        }
        private void ShowTraineeDetails()
        {
            DataTable trainee = clsTrainee.GetLastSubscriptionsByPlayerID(_id);
            LblName.Text = trainee.Rows[0]["Name"].ToString();
            SubPrices.SelectedIndex = SubPrices.FindString(trainee.Rows[0]["TotalAmount"].ToString());
            TbPaid.Text = trainee.Rows[0]["PaidAmount"].ToString();
            DtpStart.Text = trainee.Rows[0]["EnrollmentStart"].ToString();
            DtpEnd.Text = trainee.Rows[0]["EnrollmentEnd"].ToString();
        }
        private void LongSubscriptionForm_Load(object sender, EventArgs e)
        {
            SubPrices.SelectedItem = SubPrices.Items[SubPrices.FindString(25.ToString())];
            if (!_firstSub)
            {
                ShowTraineeDetails();
            }
            SubPrices.Size = new Size(154, 36);
            DtpStart.Value = DateTime.Now;
            DtpEnd.Value = DateTime.Now.AddMonths(1);
            BeginInvoke(new Action(() =>
            {
                DtpStart.Focus();
                SendKeys.Send("{F4}");
            }));
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            TbPaid.Text = SubPrices.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Valid = true;
            int Tprice = Convert.ToInt32(SubPrices.Text);
            if (!int.TryParse(TbPaid.Text, out int PaidAmount))
            {
                MessageBox.Show("المبلغ المدفوع ليس رقما صالحاً");
                Valid = false;
            }
            DateTime Start = DtpStart.Value,
                 end = DtpEnd.Value,
                 payDate = DtpPayDate.Value;
            if (end <= Start)
            {
                Valid = false;
                MessageBox.Show("موعد انتهاء الاشتراك لايمكن ان يساوي موعد بداية الاشتراك او ان يكون قبله");
            }
            if (PaidAmount > Tprice)
            {
                Valid = false;
            }

            if (Valid)
            {
                int ok = clsSubscription.AddNewSubscription(_id, Start, end, Tprice, PaidAmount, payDate);
                if (ok != -1)
                {
                    MessageBox.Show("تمت اضافة الاشتراك بنجاح");
                    Close();
                }
                else
                    MessageBox.Show("حدث خطأ يرجى التواصل مع المطور");
            }
        }

        private void PaidAmount_valueChanged(object sender, EventArgs e)
        {
            if ((!int.TryParse(((MaskedTextBox)sender).Text, out int PaidPrice)) && ((MaskedTextBox)sender).Text != "")
            {
                MessageBox.Show("يرجى ادخال الارقام فقط في هذا الحقل");
            }
        }

        private void DtpStart_ValueChanged(object sender, EventArgs e)
        {
            DtpEnd.Value = DtpStart.Value.AddMonths(1);
        }
    }
}
