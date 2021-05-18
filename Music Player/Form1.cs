using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        WMPLib.WindowsMediaPlayer muzikcalar = new WMPLib.WindowsMediaPlayer();
        OpenFileDialog file = new OpenFileDialog();
        List<string> OynatmaListesi = new List<string>();

        private void AddMusic_Click(object sender, EventArgs e)
        {
            file.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            file.Multiselect = true;
            file.InitialDirectory = Application.StartupPath;
            file.Title = "Dosya Seç";
            
            if (file.ShowDialog(this) == DialogResult.OK)
            {
                for (int i = 0; i < file.FileNames.Count(); i++)
                {
                    Music.Items.Add(file.SafeFileNames[i]);
                    OynatmaListesi.Add(file.FileNames[i]);
                }
                    Play.Enabled = true;
                    Stop.Enabled = true;
                    DeleteMusic.Enabled = true;
                    NewPlay.Enabled = true;
                }
        }

        private void DeleteMusic_Click(object sender, EventArgs e)
        {
            Music.Items.Clear();
            OynatmaListesi.Clear();
            Play.Enabled = false;
            Stop.Enabled = false;
            DeleteMusic.Enabled = false;
            NewPlay.Enabled = false;
            muzikcalar.controls.stop();
        }

        void Music_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.Music.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                try
                {
                    muzikcalar.URL = OynatmaListesi[Music.SelectedIndex].ToString();
                    muzikcalar.controls.play();
                    this.Text = Music.GetItemText(Music.SelectedItem);
                }
                
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Müzik bu konumda bulunamadı.");
                }          
            }
        }
        
        
        private void Play_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(muzikcalar.URL))
                {
                    if (muzikcalar.playState == WMPLib.WMPPlayState.wmppsPaused)
                    {
                        muzikcalar.controls.play();
                        this.Text = Music.GetItemText(Music.SelectedItem);
                    }
                    
                    else
                    {
                        muzikcalar.controls.pause();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Çalınacak Müzik Bulunamadı.");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            muzikcalar.controls.stop();
        }

        private void Music_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                Music.SelectedIndex = Music.IndexFromPoint(e.X, e.Y);
            else { }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = Music.SelectedIndex;
            Music.Items.RemoveAt(i);
            OynatmaListesi.RemoveAt(i);
            Music.Refresh();
            muzikcalar.controls.stop();
            MessageBox.Show("Liste Değişti. Müziği yeniden başlatın.");
        }

        private void NewPlay_Click(object sender, EventArgs e)
        {
            try
            {
                muzikcalar.URL = OynatmaListesi[Music.SelectedIndex].ToString();
                muzikcalar.controls.play();
                this.Text = Music.GetItemText(Music.SelectedItem);
            }

            catch
            {
                MessageBox.Show("Çalınacak Müzik Bulunamadı.");
            }
            
        }
    }
}