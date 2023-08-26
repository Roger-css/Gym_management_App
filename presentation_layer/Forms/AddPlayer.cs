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

namespace presentation_layer
{
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }
        string imagePath;
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
            if (int.TryParse(TbPaidPrice.Text,out int paidPrices))
            {
                MessageBox.Show("يرجى ادخال الارقام فقط في حقل المبلغ المدفوع");
                ValidData = false;
            }
            if (ValidData)
            {
                int added = clsTrainee.AddPalyerWithSubscribtion(TbName.Text, TbPhone.Text,
                imagePath, DtpStartDate.Value, DtpEndDate.Value,
                int.Parse(LbPrices.Text), paidPrices);
                if (added != -1)
                {
                    MessageBox.Show($"رقم بطاقة اللاعب هي {added}");
                }
            }
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {
            DtpEndDate.Value = DateTime.Now.AddMonths(1);
        }
        private void PaidAmount_valueChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(((MaskedTextBox)sender).Text, out int PaidPrice) && ((MaskedTextBox)sender).Text != "")
            {
                MessageBox.Show("يرجى ادخال الارقام فقط في هذا الحقل");
            }
        }
    }
}
