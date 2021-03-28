using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

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
            try
            {
                player.SoundLocation = Music.GetItemText(Music.SelectedItem);
                player.Play();
            }
            catch (FileNotFoundException) {
                MessageBox.Show("Müzik bu konumda bulunamadı.");
            }
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
            file.Multiselect = true;
            if (file.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string files in file.FileNames)
                {
                    Music.Items.Add(files);
                }
            }
        }

        private void DeleteMusic_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(Music);
            selectedItems = Music.SelectedItems;

            if (Music.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    Music.Items.Remove(selectedItems[i]);
            }
        }

        void Music_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.Music.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                try
                {
                    player.SoundLocation = Music.GetItemText(Music.SelectedItem);
                    player.Play();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Müzik bu konumda bulunamadı.");
                }
                this.Text = Music.GetItemText(Music.SelectedItem);
            }
        }
    }
}