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

        WMPLib.WindowsMediaPlayer musicplayer = new WMPLib.WindowsMediaPlayer();
        OpenFileDialog file = new OpenFileDialog();
        List<string> PlayList = new List<string>();

        private void AddMusic_Click(object sender, EventArgs e)
        {
            file.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            file.Multiselect = true;
            file.InitialDirectory = Application.StartupPath;
            file.Title = "Select File";
            
            if (file.ShowDialog(this) == DialogResult.OK)
            {
                for (int i = 0; i < file.FileNames.Count(); i++)
                {
                    Music.Items.Add(file.SafeFileNames[i]);
                    PlayList.Add(file.FileNames[i]);
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
            PlayList.Clear();
            Play.Enabled = false;
            Stop.Enabled = false;
            DeleteMusic.Enabled = false;
            NewPlay.Enabled = false;
            musicplayer.controls.stop();
        }

        void Music_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.Music.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                try
                {
                    musicplayer.URL = PlayList[Music.SelectedIndex].ToString();
                    musicplayer.controls.play();
                    this.Text = Music.GetItemText(Music.SelectedItem);
                }
                
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Music not found in this location.");
                }          
            }
        }
        
        
        private void Play_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(musicplayer.URL))
                {
                    if (musicplayer.playState == WMPLib.WMPPlayState.wmppsPaused)
                    {
                        musicplayer.controls.play();
                        this.Text = Music.GetItemText(Music.SelectedItem);
                    }
                    
                    else
                    {
                        musicplayer.controls.pause();
                    }
                }
            }

            catch
            {
                MessageBox.Show("No music to play.");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            musicplayer.controls.stop();
        }

        private void Music_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                Music.SelectedIndex = Music.IndexFromPoint(e.X, e.Y);
            else { }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Music.SelectedIndex;
                Music.Items.RemoveAt(i);
                PlayList.RemoveAt(i);
                Music.Refresh();
                musicplayer.controls.stop();

                if (Music.Items.Count == 0)
                {
                    Play.Enabled = false;
                    Stop.Enabled = false;
                    DeleteMusic.Enabled = false;
                    NewPlay.Enabled = false;
                }

            }
            catch{}
        }

        private void NewPlay_Click(object sender, EventArgs e)
        {
            try
            {
                musicplayer.URL = PlayList[Music.SelectedIndex].ToString();
                musicplayer.controls.play();
                this.Text = Music.GetItemText(Music.SelectedItem);
            }

            catch
            {
                MessageBox.Show("No music to play.");
            } 
        }
    }
}