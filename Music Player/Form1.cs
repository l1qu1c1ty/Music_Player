using System;
using System.Text;
using System.Windows.Forms;

namespace Music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private void Play_Click(object sender, System.EventArgs e)
        {
            player.SoundLocation = textBox1.Text;
            player.Play();
        }

        private void Stop_Click(object sender, System.EventArgs e)
        {
            player.Stop();
        }
    }
}