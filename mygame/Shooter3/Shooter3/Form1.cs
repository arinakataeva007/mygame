using System;
using System.Windows.Forms;

namespace Shooter3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var game = new Shooter();
            game.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
