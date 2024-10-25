using GymBussniesLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace presentation_layer.Forms.CmsForms
{
    public partial class EditPlayer : Form
    {
        private readonly int PlayerId = -1;
        private string imagePath = string.Empty;
        private int TotalPrice = 10,
            PaidPrice = 10;
        private string name;
        public EditPlayer(int playerId = -1)
        {
            InitializeComponent();
            PlayerId = playerId;
        }
        private void ShowTraineeDetails()
        {
            DataTable trainee = clsTrainee.GetLastSubscriptionsByPlayerID(PlayerId);
            name = trainee.Rows[0]["Name"].ToString();
            TbName.Text = trainee.Rows[0]["Name"].ToString();
            TbPhone.Text = trainee.Rows[0]["Phone"].ToString();
            SubPrices.SelectedIndex = SubPrices.FindString(trainee.Rows[0]["TotalAmount"].ToString());
            string photo = trainee.Rows[0]["Photo"].ToString();
            if (photo != string.Empty)
            {
                pictureBox1.Load(photo);
            }
            TbPaid.Text = trainee.Rows[0]["PaidAmount"].ToString();
            DtpStart.Text = trainee.Rows[0]["EnrollmentStart"].ToString();
            DtpEnd.Text = trainee.Rows[0]["EnrollmentEnd"].ToString();
            DtpPayDate.Text = trainee.Rows[0]["PayDate"].ToString();
        }
        private void EditPlayer_Load(object sender, EventArgs e)
        {
            _id.Text = PlayerId.ToString();
            ShowTraineeDetails();
            SubPrices.Size = new Size(139, 33);
            BeginInvoke(new Action(() =>
            {
                DtpStart.Focus();
                SendKeys.Send("{F4}");
            }));
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                imagePath = openFileDialog1.FileName;
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            TbPaid.Text = SubPrices.Text;
            TotalPrice = Convert.ToInt32(((ListBox)sender).Text);
        }

        private void PaidPrice_Changed(object sender, EventArgs e)
        {
            if (!int.TryParse(((MaskedTextBox)sender).Text, out PaidPrice) && ((MaskedTextBox)sender).Text != "")
            {
                MessageBox.Show("يرجى ادخال الارقام فقط في هذا الحقل");
            }

        }

        private void DtpStart_ValueChanged(object sender, EventArgs e)
        {
            DtpEnd.Value = DtpStart.Value.AddMonths(1);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            bool ValidData = true;
            if (TbName.Text == "")
            {
                MessageBox.Show("لايمكن ان يكون الاسم فارغ");
                ValidData = false;
            }
            if (DtpStart.Value >= DtpEnd.Value)
            {
                ValidData = false;
            }
            if (TbPaid.Text == "")
            {
                TbPaid.Text = "0";
            }
            if (!int.TryParse(TbPaid.Text, out PaidPrice))
            {
                MessageBox.Show("يرجى ادخال الارقام فقط في حقل المبلغ المدفوع");
                ValidData = false;
            }
            if (TbName.Text != name)
            {
                var nameAlreadyExist = clsTrainee.IsTraineeNameExists(TbName.Text);
                if (nameAlreadyExist)
                {
                    MessageBox.Show("يوجد لاعب بهذا الاسم مسبقاً");
                    ValidData = false;
                }
            }
            if (ValidData)
            {
                bool ok = clsTrainee.UpdatePlayerSubscription(PlayerId, TbName.Text, DtpStart.Value, DtpEnd.Value
                , TbPhone.Text, imagePath, TotalPrice,
                PaidPrice, DtpPayDate.Value);
                if (ok)
                {
                    MessageBox.Show("تم تعديل بيانات اللاعب بنجاح");
                    Close();
                }
            }
        }
    }
}
