﻿namespace mediaPlayer1
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
            this.btmOpen = new System.Windows.Forms.Button();
            this.ListFile = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btmOpen
            // 
            this.btmOpen.Location = new System.Drawing.Point(576, 349);
            this.btmOpen.Name = "btmOpen";
            this.btmOpen.Size = new System.Drawing.Size(99, 23);
            this.btmOpen.TabIndex = 1;
            this.btmOpen.Text = "Open";
            this.btmOpen.UseVisualStyleBackColor = true;
            this.btmOpen.Click += new System.EventHandler(this.btmOpen_Click);
            // 
            // ListFile
            // 
            this.ListFile.FormattingEnabled = true;
            this.ListFile.Location = new System.Drawing.Point(576, 12);
            this.ListFile.Name = "ListFile";
            this.ListFile.Size = new System.Drawing.Size(303, 329);
            this.ListFile.TabIndex = 2;
            this.ListFile.SelectedIndexChanged += new System.EventHandler(this.ListFile_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(536, 360);
            this.axWindowsMediaPlayer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 397);
            this.Controls.Add(this.ListFile);
            this.Controls.Add(this.btmOpen);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Button btmOpen;
        private System.Windows.Forms.ListBox ListFile;
    }
}

