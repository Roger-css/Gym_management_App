﻿using GymBussniesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace presentation_layer.Forms.CmsForms
{
    public partial class LongSubscriptionForm : Form
    {
        int _id = -1;
        bool _firstSub;
        public LongSubscriptionForm(int id = -1,bool firstSub = false)
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
            SubPrices.SelectedItem = SubPrices.Items[SubPrices.FindString(Convert.ToString(25))];
            if (!_firstSub)
            {
                ShowTraineeDetails();
            }
            SubPrices.Size = new Size(154, 36);
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            TbPaid.Text = SubPrices.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Valid = true;
            int Tprice = Convert.ToInt32(SubPrices.Text);
            if(!int.TryParse(TbPaid.Text, out int PaidAmount))
            {
                MessageBox.Show("المبلغ المدفوع ليس رقما صالحاً");
                Valid = false;
            }
            DateTime Start = DtpStart.Value,
                 End = DtpEnd.Value;
            if (End <= Start)
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
                int ok = clsSubscription.AddNewSubscription(_id, Start, End, Tprice, PaidAmount);
                if (ok != -1)
                {
                    MessageBox.Show("تمت اضافة الاشتراك بنجاح");
                    Close();
                }
            }
        }

        private void PaidAmount_valueChanged(object sender, EventArgs e)
        {
            if ((!int.TryParse(((MaskedTextBox)sender).Text, out int PaidPrice)) && ((MaskedTextBox)sender).Text != "")
            {
                MessageBox.Show("يرجى ادخال الارقام فقط في هذا الحقل");
            }
        }
    }
}
