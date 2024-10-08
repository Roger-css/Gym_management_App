﻿using System;
using System.Windows.Forms;

namespace presentation_layer.Forms.BalanceForms
{
    public partial class monthly : Form
    {
        public DateTime Date = DateTime.Now;
        public monthly()
        {
            InitializeComponent();
        }

        private void monthly_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.ShowUpDown = true;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date = ((DateTimePicker)sender).Value;
        }
    }
}