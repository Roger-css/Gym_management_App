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
    public partial class LongSubscriptionForm : Form
    {
        int _id = -1;
        public LongSubscriptionForm(int id = -1)
        {
            InitializeComponent();
            _id = id;
        }

        private void LongSubscriptionForm_Load(object sender, EventArgs e)
        {
            SubPrices.SelectedItem = SubPrices.Items[SubPrices.FindString(Convert.ToString(25))];
            DtpStartSub.Value = DateTime.Now;
            DtpEndOfSub.Value = DateTime.Now.AddMonths(1);
        }
    }
}
