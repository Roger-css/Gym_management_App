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

namespace presentation_layer.Forms.CmsForms
{
    public partial class EditPlayer : Form
    {
        int PlayerId = -1;
        string imagePath = string.Empty;
        public EditPlayer(int playerId = -1)
        {
            InitializeComponent();
            PlayerId = playerId;
        }
        private void ShowTraineeDetails()
        {
            DataTable trainee = clsTrainee.GetLastSubscriptionsByPlayerID(PlayerId);
            TbName.Text = trainee.Rows[0]["Name"].ToString();
            TbPhone.Text = trainee.Rows[0]["Phone"].ToString();
            SubPrices.SelectedValue = SubPrices.FindString(trainee.Rows[0]["TotalAmount"].ToString());
            TbPaid.Text = trainee.Rows[0]["PaidAmount"].ToString();
            DtpStart.Text = trainee.Rows[0]["EnrollmentStart"].ToString();
            DtpEnd.Text = trainee.Rows[0]["EnrollmentEnd"].ToString();
        }
        private void EditPlayer_Load(object sender, EventArgs e)
        {
            _id.Text = PlayerId.ToString();
            
            ShowTraineeDetails();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                imagePath = openFileDialog1.FileName;
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            TbPaid.Text = SubPrices.Text;
        }


    }
}