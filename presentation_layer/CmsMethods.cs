using presentation_layer.Forms.CmsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation_layer
{
    internal class CmsMethods
    {
        static public void EditToolStripMenuItem_Click(object value)
        {
            EditPlayer form = new EditPlayer((int) value);
            form.Show();
        }

        static public void ManualSub_click(object value)
        {
            LongSubscriptionForm form = new LongSubscriptionForm((int) value);
            form.Show();
        }

        static public void QuickSubBtn_Click(object value)
        {
            // do a quick subscription method here
        }
        static public void QuickAddMoney_click()
        {
            // do a quick add money method here
        }
    }
}
