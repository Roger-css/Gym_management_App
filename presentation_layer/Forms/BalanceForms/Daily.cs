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
    public partial class Daily : Form
    {
        public DateTime Date = DateTime.Now;
        public Daily()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Date = ((DateTimePicker)sender).Value;
        }
    }
}
