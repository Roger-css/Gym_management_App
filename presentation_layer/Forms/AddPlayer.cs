using GymBussniesLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace presentation_layer
{
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }

        private string imagePath;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (OfdPicture.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(OfdPicture.FileName);
                imagePath = OfdPicture.FileName;
            }
        }
        private void Lb_valueChange(object sender, EventArgs e)
        {
            TbPaidPrice.Text = LbPrices.Text;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool ValidData = true;
            if (TbName.Text == "")
            {
                MessageBox.Show("لايمكن ان يكون الاسم فارغ");
                ValidData = false;
            }
            if (DtpStartDate.Value >= DtpEndDate.Value)
            {
                ValidData = false;
            }
            if (TbPaidPrice.Text == "")
            {
                TbPaidPrice.Text = "0";
            }
            if (!int.TryParse(TbPaidPrice.Text, out int paidPrices))
            {
                MessageBox.Show("يرجى ادخال الارقام فقط في حقل المبلغ المدفوع");
                ValidData = false;
            }
            if (ValidData)
            {
                bool NameExists = clsTrainee.IsTraineeNameExists(TbName.Text.Trim());
                if (NameExists)
                {
                    if (MessageBox.Show("هذا الاسم موجود بالفعل هل انت متأكد انك تود اضافة لاعب بنفس الاسم؟", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                int added = clsTrainee.AddPlayerWithSubscribtion(TbName.Text, TbPhone.Text,
                        imagePath, DtpStartDate.Value, DtpEndDate.Value,
                        int.Parse(LbPrices.Text), paidPrices, PayDate.Value
                        );
                if (added != -1)
                {
                    MessageBox.Show($"رقم بطاقة اللاعب هي {added}");
                }
                else
                    MessageBox.Show("حدث خطأ يرجى التواصل مع المطور");
            }
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {
            DtpEndDate.Value = DateTime.Now.AddMonths(1);
            LbPrices.SelectedIndex = 4;
            LbPrices.Size = new Size(259, 44);
            DtpStartDate.Focus();
            SendKeys.Send("{F4}");
        }
        private void PaidAmount_valueChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(((MaskedTextBox)sender).Text, out _) && ((MaskedTextBox)sender).Text != "")
            {
                MessageBox.Show("يرجى ادخال الارقام فقط في هذا الحقل");
            }
        }

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            DtpEndDate.Value = DtpStartDate.Value.AddMonths(1);
        }
    }
}
