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
        OpenFileDialog file = new OpenFileDialog();

        private void Play_Click(object sender, System.EventArgs e)
        {
            player.SoundLocation = Music.GetItemText(Music.SelectedItem);
            player.Play();
            this.Text = Music.GetItemText(Music.SelectedItem);
        }

        private void Stop_Click(object sender, System.EventArgs e)
        {
            player.Stop();
            this.Text = "Music Player";
        }

        private void AddMusic_Click(object sender, EventArgs e)
        {
            file.Filter = "Media File(*.wav)|*.wav";
            if (file.ShowDialog() == DialogResult.OK)
            {
                Music.Items.Add(file.FileName);
            }
        }

        private void DeleteMusic_Click(object sender, EventArgs e)
        {
            Music.Items.Clear();
        }
    }
}