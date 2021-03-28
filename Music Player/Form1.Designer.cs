namespace Music
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Music = new System.Windows.Forms.ListBox();
            this.AddMusic = new System.Windows.Forms.Button();
            this.DeleteMusic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.Location = new System.Drawing.Point(346, 256);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(91, 87);
            this.Stop.TabIndex = 5;
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.Location = new System.Drawing.Point(236, 256);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(88, 87);
            this.Play.TabIndex = 4;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Music
            // 
            this.Music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Music.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Music.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Music.FormattingEnabled = true;
            this.Music.ItemHeight = 19;
            this.Music.Location = new System.Drawing.Point(12, 25);
            this.Music.Name = "Music";
            this.Music.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Music.Size = new System.Drawing.Size(448, 213);
            this.Music.Sorted = true;
            this.Music.TabIndex = 1;
            // 
            // AddMusic
            // 
            this.AddMusic.BackColor = System.Drawing.Color.Transparent;
            this.AddMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddMusic.Image = ((System.Drawing.Image)(resources.GetObject("AddMusic.Image")));
            this.AddMusic.Location = new System.Drawing.Point(12, 256);
            this.AddMusic.Name = "AddMusic";
            this.AddMusic.Size = new System.Drawing.Size(89, 87);
            this.AddMusic.TabIndex = 2;
            this.AddMusic.UseVisualStyleBackColor = false;
            this.AddMusic.Click += new System.EventHandler(this.AddMusic_Click);
            // 
            // DeleteMusic
            // 
            this.DeleteMusic.BackColor = System.Drawing.Color.Transparent;
            this.DeleteMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteMusic.Image = ((System.Drawing.Image)(resources.GetObject("DeleteMusic.Image")));
            this.DeleteMusic.Location = new System.Drawing.Point(119, 256);
            this.DeleteMusic.Name = "DeleteMusic";
            this.DeleteMusic.Size = new System.Drawing.Size(100, 87);
            this.DeleteMusic.TabIndex = 3;
            this.DeleteMusic.UseVisualStyleBackColor = false;
            this.DeleteMusic.Click += new System.EventHandler(this.DeleteMusic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(195, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Music List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteMusic);
            this.Controls.Add(this.AddMusic);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Stop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.ListBox Music;
        private System.Windows.Forms.Button AddMusic;
        private System.Windows.Forms.Button DeleteMusic;
        private System.Windows.Forms.Label label1;
    }
}

