using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation_layer.Forms.BalanceForms
{
    public partial class Custom : Form
    {
        public DateTime Start = DateTime.Parse("2023-08-01");
        public DateTime End = DateTime.Now;
        public Custom()
        {
            InitializeComponent();
        }

        private void DtpStart_ValueChanged(object sender, EventArgs e)
        {
            Start = ((DateTimePicker)sender).Value;
        }

        private void DtpEnd_ValueChanged(object sender, EventArgs e)
        {
            End = ((DateTimePicker)sender).Value;
        }
    }
}
