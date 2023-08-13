using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation_layer.Forms
{
    public partial class Expired : Form
    {
        public Expired()
        {
            InitializeComponent();
        }

        private void CmsQuickSub_Click(object sender, EventArgs e)
        {
            CmsMethods.QuickSubBtn_Click(DgvList.CurrentRow.Cells[0].Value);
        }

        private void CmsManualSub_Click(object sender, EventArgs e)
        {
            CmsMethods.ManualSub_click(DgvList.CurrentRow.Cells[0].Value);
        }
    }
}
