using GymBussniesLayer;
using presentation_layer.Forms.BalanceForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace presentation_layer.Forms
{
    public partial class Balance : Form
    {
        private Form activeForm;
        private readonly yearly YearControl = new yearly();
        private readonly Daily DailyControl = new Daily();
        private readonly monthly MonthlyControl = new monthly();
        private readonly Custom CustomControl = new Custom();
        public Balance()
        {
            InitializeComponent();
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
            button1.PerformClick();
            Dgv.ForeColor = Color.Black;
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (Dgv.Rows.Count != 0)
            {
                Dgv.Columns[0].Width = 80;
                Dgv.Columns[1].Width = 200;
                Dgv.Columns[8].Width = 200;
            }
            GeneralMethods.ChangeColumnNames(ref Dgv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm == CustomControl)
            {
                Dgv.DataSource = clsSubscription.GetTraineesSubscriptionsByDates(CustomControl.Start, CustomControl.End);
                LblTotalAmount.Text = Convert.ToString(clsSubscription.GetBalanceByDates
                    (Convert.ToDateTime(CustomControl.Start), Convert.ToDateTime(CustomControl.End)));
            }
            else if (activeForm == MonthlyControl)
            {
                string startDate = MonthlyControl.Date.Year.ToString();
                startDate += "-";
                startDate += MonthlyControl.Date.Month.ToString();
                startDate += "-01";
                string endDate = MonthlyControl.Date.Year.ToString();
                endDate += "-";
                endDate += MonthlyControl.Date.Month.ToString();
                endDate += "-";
                endDate += DateTime.DaysInMonth(MonthlyControl.Date.Year, MonthlyControl.Date.Month);
                Dgv.DataSource =
                clsSubscription.GetTraineesSubscriptionsByDates
                (Convert.ToDateTime(startDate), Convert.ToDateTime(endDate));
                LblTotalAmount.Text = Convert.ToString(clsSubscription.GetBalanceByDates
                    (Convert.ToDateTime(startDate), Convert.ToDateTime(endDate)));

            }
            else if (activeForm == DailyControl)
            {
                string Date = DailyControl.Date.ToShortDateString();
                Dgv.DataSource =
                clsSubscription.GetTraineesSubscriptionsByDates
                (Convert.ToDateTime(Date), Convert.ToDateTime(Date).AddHours(23).AddMinutes(59).AddSeconds(59));
                LblTotalAmount.Text = Convert.ToString(clsSubscription.GetBalanceByDates
                    (Convert.ToDateTime(Date), Convert.ToDateTime(Date).AddHours(23).AddMinutes(59).AddSeconds(59)));
            }
            else if (activeForm == YearControl)
            {
                string startDate = Convert.ToString(YearControl.Date.Year);
                startDate += "-01-01";
                string endDate = Convert.ToString(YearControl.Date.Year);
                endDate += "-12-31";
                Dgv.DataSource =
                clsSubscription.GetTraineesSubscriptionsByDates
                (Convert.ToDateTime(startDate), Convert.ToDateTime(endDate));
                LblTotalAmount.Text = Convert.ToString(clsSubscription.GetBalanceByDates
                    (Convert.ToDateTime(startDate), Convert.ToDateTime(endDate)));
            }
            else
            {
                MessageBox.Show("حدث خطأ يرجى التواصل مع المطور");
            }
            GeneralMethods.ChangeColumnNames(ref Dgv);
        }
    }
}
