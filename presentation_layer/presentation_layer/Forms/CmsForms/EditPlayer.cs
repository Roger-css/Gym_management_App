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
    public partial class EditPlayer : Form
    {
        int PlayerId = -1;
        string imagePath = string.Empty;
        public EditPlayer(int playerId = -1)
        {
            InitializeComponent();
            PlayerId = playerId;
        }

        private void EditPlayer_Load(object sender, EventArgs e)
        {
            _id.Text = PlayerId.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                imagePath = openFileDialog1.FileName;
            }
        }
    }
}
