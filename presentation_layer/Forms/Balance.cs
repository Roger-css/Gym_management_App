using GymBussniesLayer;
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
        yearly YearControl = new yearly();
        Daily DailyControl = new Daily();
        monthly MonthlyControl = new monthly();
        Custom CustomControl = new Custom();
        public Balance()
        {
            InitializeComponent();
        }
        public string GetLastDayOfMonth(int year, int month)
        {
            if (month == 2)
            {
                return DateTime.IsLeapYear(year) ? "29" : "28";
            }
            
            int[] months = {1,3,5,7,8,10,12};
            
            for (int i = 0; i <= 12; i++)
            {
                if (month == months[i])
                {
                    return "31";
                }
            }
            return "30";
        }
        private void OpenChildForm(Form childForm)
        {
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
                    OpenChildForm(YearControl);
                    break;
                case "شهري":
                    OpenChildForm(MonthlyControl);
                    break;
                case "يومي":
                    OpenChildForm(DailyControl);
                    break;
                case "يدوي":
                    OpenChildForm(CustomControl);
                    break;
                default:
                    break;
            }
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            CbCalcType.SelectedIndex = CbCalcType.FindString("شهري");
            OpenChildForm(MonthlyControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm == CustomControl)
            {
                
                clsSubscription.GetTraineesSubscriptionsByDates(CustomControl.Start,CustomControl.End);
            }
            else if(activeForm == MonthlyControl)
            {
                string startDate = MonthlyControl.Date.Year.ToString();
                startDate += "-";
                startDate += MonthlyControl.Date.Month.ToString();
                startDate += "-01";
                string endDate = MonthlyControl.Date.Year.ToString();
                endDate += "-";
                endDate += MonthlyControl.Date.Month.ToString();
                endDate += "-";
                endDate += GetLastDayOfMonth(MonthlyControl.Date.Year, MonthlyControl.Date.Month);
                MessageBox.Show($"{startDate}####{endDate}");

            }
            else if (activeForm == DailyControl)
            {
                //MessageBox.Show($"{CustomControl.Start.ToShortDateString()} , {CustomControl.End.ToShortDateString()}");

            }
            else if (activeForm == YearControl)
            {
                //MessageBox.Show($"{CustomControl.Start.ToShortDateString()} , {CustomControl.End.ToShortDateString()}");

            }
            else
            {
                MessageBox.Show("somethings wrong");
            }

        }
    }
}
