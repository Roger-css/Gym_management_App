using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymBussniesLayer;
namespace presentation_layer.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TbUserName.Text == "hm" && TbPassword.Text == "123456")
            {
                Form frm = new MainMenu();
                frm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("كلمة المرور او اسم المستخدم خاطئ");
                TbUserName.Text = "";
                TbPassword.Text = "";
            }
        }
    }
}
