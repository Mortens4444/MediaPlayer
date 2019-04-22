namespace MediaPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ofd_FileSelector = new System.Windows.Forms.OpenFileDialog();
            this.ts_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsb_AddFiles = new System.Windows.Forms.ToolStripButton();
            this.ss_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.tssl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.p_Main = new System.Windows.Forms.Panel();
            this.p_Playlist = new System.Windows.Forms.Panel();
            this.lv_Playlist = new System.Windows.Forms.ListView();
            this.ch_Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p_Upper = new System.Windows.Forms.Panel();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.ts_ToolStrip.SuspendLayout();
            this.ss_StatusStrip.SuspendLayout();
            this.p_Main.SuspendLayout();
            this.p_Playlist.SuspendLayout();
            this.p_Upper.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd_FileSelector
            // 
            this.ofd_FileSelector.Filter = "Media files|*.avi;*.mov;*.mp3;*.mp4;*.wav|All files|*.*";
            this.ofd_FileSelector.Multiselect = true;
            // 
            // ts_ToolStrip
            // 
            this.ts_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_AddFiles});
            this.ts_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ts_ToolStrip.Name = "ts_ToolStrip";
            this.ts_ToolStrip.Size = new System.Drawing.Size(531, 25);
            this.ts_ToolStrip.TabIndex = 0;
            this.ts_ToolStrip.Text = "toolStrip1";
            // 
            // tsb_AddFiles
            // 
            this.tsb_AddFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AddFiles.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AddFiles.Image")));
            this.tsb_AddFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AddFiles.Name = "tsb_AddFiles";
            this.tsb_AddFiles.Size = new System.Drawing.Size(23, 22);
            this.tsb_AddFiles.Text = "toolStripButton1";
            this.tsb_AddFiles.Click += new System.EventHandler(this.tsb_AddFiles_Click);
            // 
            // ss_StatusStrip
            // 
            this.ss_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Status});
            this.ss_StatusStrip.Location = new System.Drawing.Point(0, 250);
            this.ss_StatusStrip.Name = "ss_StatusStrip";
            this.ss_StatusStrip.Size = new System.Drawing.Size(531, 22);
            this.ss_StatusStrip.TabIndex = 1;
            this.ss_StatusStrip.Text = "statusStrip1";
            // 
            // tssl_Status
            // 
            this.tssl_Status.Name = "tssl_Status";
            this.tssl_Status.Size = new System.Drawing.Size(38, 17);
            this.tssl_Status.Text = "Ready";
            // 
            // p_Main
            // 
            this.p_Main.Controls.Add(this.p_Playlist);
            this.p_Main.Controls.Add(this.p_Upper);
            this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Main.Location = new System.Drawing.Point(0, 25);
            this.p_Main.Name = "p_Main";
            this.p_Main.Size = new System.Drawing.Size(531, 225);
            this.p_Main.TabIndex = 2;
            // 
            // p_Playlist
            // 
            this.p_Playlist.Controls.Add(this.lv_Playlist);
            this.p_Playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Playlist.Location = new System.Drawing.Point(0, 36);
            this.p_Playlist.Name = "p_Playlist";
            this.p_Playlist.Size = new System.Drawing.Size(531, 189);
            this.p_Playlist.TabIndex = 1;
            // 
            // lv_Playlist
            // 
            this.lv_Playlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Filename});
            this.lv_Playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Playlist.FullRowSelect = true;
            this.lv_Playlist.Location = new System.Drawing.Point(0, 0);
            this.lv_Playlist.MultiSelect = false;
            this.lv_Playlist.Name = "lv_Playlist";
            this.lv_Playlist.Size = new System.Drawing.Size(531, 189);
            this.lv_Playlist.TabIndex = 0;
            this.lv_Playlist.UseCompatibleStateImageBehavior = false;
            this.lv_Playlist.View = System.Windows.Forms.View.Details;
            this.lv_Playlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_Playlist_MouseDoubleClick);
            // 
            // ch_Filename
            // 
            this.ch_Filename.Text = "Filename";
            this.ch_Filename.Width = 523;
            // 
            // p_Upper
            // 
            this.p_Upper.Controls.Add(this.btn_Previous);
            this.p_Upper.Controls.Add(this.btn_Next);
            this.p_Upper.Controls.Add(this.btn_Stop);
            this.p_Upper.Controls.Add(this.btn_Play);
            this.p_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Upper.Location = new System.Drawing.Point(0, 0);
            this.p_Upper.Name = "p_Upper";
            this.p_Upper.Size = new System.Drawing.Size(531, 36);
            this.p_Upper.TabIndex = 0;
            // 
            // btn_Previous
            // 
            this.btn_Previous.Image = global::MediaPlayer.Properties.Resources.c7;
            this.btn_Previous.Location = new System.Drawing.Point(0, -1);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(43, 39);
            this.btn_Previous.TabIndex = 3;
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Image = global::MediaPlayer.Properties.Resources.c1;
            this.btn_Next.Location = new System.Drawing.Point(130, 0);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(43, 39);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Image = global::MediaPlayer.Properties.Resources.c8;
            this.btn_Stop.Location = new System.Drawing.Point(86, 0);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(43, 39);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Image = global::MediaPlayer.Properties.Resources.c2;
            this.btn_Play.Location = new System.Drawing.Point(42, 0);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(43, 39);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 272);
            this.Controls.Add(this.p_Main);
            this.Controls.Add(this.ss_StatusStrip);
            this.Controls.Add(this.ts_ToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.ts_ToolStrip.ResumeLayout(false);
            this.ts_ToolStrip.PerformLayout();
            this.ss_StatusStrip.ResumeLayout(false);
            this.ss_StatusStrip.PerformLayout();
            this.p_Main.ResumeLayout(false);
            this.p_Playlist.ResumeLayout(false);
            this.p_Upper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_FileSelector;
        private System.Windows.Forms.ToolStrip ts_ToolStrip;
        private System.Windows.Forms.StatusStrip ss_StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Status;
        private System.Windows.Forms.Panel p_Main;
        private System.Windows.Forms.Panel p_Playlist;
        private System.Windows.Forms.Panel p_Upper;
        private System.Windows.Forms.ToolStripButton tsb_AddFiles;
        private System.Windows.Forms.ListView lv_Playlist;
        private System.Windows.Forms.ColumnHeader ch_Filename;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
    }
}

