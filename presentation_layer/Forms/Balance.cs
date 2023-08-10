using presentation_layer.Forms.BalanceForms;
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
    public partial class Balance : Form
    {
        Form activeForm;
        public Balance()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            FormsPanel.Controls.Add(childForm);
            FormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ValueChanged_event(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedItem.ToString())
            {
                case "سنوي":
                    OpenChildForm(new yearly());
                    break;
                case "شهري":
                    OpenChildForm(new monthly());
                    break;
                case "يومي":
                    OpenChildForm(new Daily());
                    break;
                case "يدوي":
                    OpenChildForm(new Custom());
                    break;
                case "جميع السنين":
                    activeForm.Close();
                    FormsPanel.Controls.Clear();
                    break;
                default:
                    break;
            }
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            CbCalcType.SelectedIndex = CbCalcType.FindString("شهري");
            OpenChildForm(new monthly());
        }
    }
}
