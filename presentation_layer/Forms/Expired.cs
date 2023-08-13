using GymBussniesLayer;
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
        private void Expired_Load(object sender, EventArgs e)
        {
            DgvList.DataSource = clsTrainee.GetTraineesExpiredSubscription();
            DgvList.ForeColor = Color.Black;
            DgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GeneralMethods.ChangeColumnNames(ref DgvList);
        }
    }
}