﻿using presentation_layer.Forms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LblTitle.Text = ((Button)btnSender).Text.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddPlayer(), sender);
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchForm(), sender);
        }
        private void playersListBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PlayersList(), sender);
        }
        private void ExpiredListBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Expired(), sender);
        }
        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Balance(), sender);
        }
        private void UncompleteSubs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UncompleteSubs(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NoSubsPlayers(),sender);
        }
    }
}
