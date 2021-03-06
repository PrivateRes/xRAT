﻿namespace xRAT_2.Forms
{
    partial class frmFileManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileManager));
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.lblDrive = new System.Windows.Forms.Label();
            this.lstDirectory = new xRAT_2.Controls.ListViewEx();
            this.hName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxtDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.imgListDirectory = new System.Windows.Forms.ImageList(this.components);
            this.botStrip = new System.Windows.Forms.StatusStrip();
            this.btnOpenDLFolder = new System.Windows.Forms.Button();
            this.TabControlFileManager = new System.Windows.Forms.TabControl();
            this.tabFileExplorer = new System.Windows.Forms.TabPage();
            this.tabTransfers = new System.Windows.Forms.TabPage();
            this.lstTransfers = new xRAT_2.Controls.ListViewEx();
            this.hID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgListTransfers = new System.Windows.Forms.ImageList(this.components);
            this.ctxtMenu.SuspendLayout();
            this.TabControlFileManager.SuspendLayout();
            this.tabFileExplorer.SuspendLayout();
            this.tabTransfers.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDrives
            // 
            this.cmbDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrives.FormattingEnabled = true;
            this.cmbDrives.Location = new System.Drawing.Point(50, 9);
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.Size = new System.Drawing.Size(52, 21);
            this.cmbDrives.TabIndex = 1;
            this.cmbDrives.SelectedIndexChanged += new System.EventHandler(this.cmbDrives_SelectedIndexChanged);
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Location = new System.Drawing.Point(8, 12);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(36, 13);
            this.lblDrive.TabIndex = 0;
            this.lblDrive.Text = "Drive:";
            // 
            // lstDirectory
            // 
            this.lstDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDirectory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hName,
            this.hSize,
            this.hType});
            this.lstDirectory.ContextMenuStrip = this.ctxtMenu;
            this.lstDirectory.FullRowSelect = true;
            this.lstDirectory.GridLines = true;
            this.lstDirectory.Location = new System.Drawing.Point(11, 36);
            this.lstDirectory.Name = "lstDirectory";
            this.lstDirectory.Size = new System.Drawing.Size(659, 315);
            this.lstDirectory.SmallImageList = this.imgListDirectory;
            this.lstDirectory.TabIndex = 2;
            this.lstDirectory.UseCompatibleStateImageBehavior = false;
            this.lstDirectory.View = System.Windows.Forms.View.Details;
            this.lstDirectory.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstDirectory_ColumnClick);
            this.lstDirectory.DoubleClick += new System.EventHandler(this.lstDirectory_DoubleClick);
            // 
            // hName
            // 
            this.hName.Text = "Name";
            this.hName.Width = 163;
            // 
            // hSize
            // 
            this.hSize.Text = "Size";
            this.hSize.Width = 117;
            // 
            // hType
            // 
            this.hType.Text = "Type";
            this.hType.Width = 128;
            // 
            // ctxtMenu
            // 
            this.ctxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxtDownload});
            this.ctxtMenu.Name = "ctxtMenu";
            this.ctxtMenu.Size = new System.Drawing.Size(129, 26);
            // 
            // ctxtDownload
            // 
            this.ctxtDownload.Image = global::xRAT_2.Properties.Resources.download;
            this.ctxtDownload.Name = "ctxtDownload";
            this.ctxtDownload.Size = new System.Drawing.Size(128, 22);
            this.ctxtDownload.Text = "Download";
            this.ctxtDownload.Click += new System.EventHandler(this.ctxtDownload_Click);
            // 
            // imgListDirectory
            // 
            this.imgListDirectory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDirectory.ImageStream")));
            this.imgListDirectory.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListDirectory.Images.SetKeyName(0, "back.png");
            this.imgListDirectory.Images.SetKeyName(1, "folder.png");
            this.imgListDirectory.Images.SetKeyName(2, "file.png");
            this.imgListDirectory.Images.SetKeyName(3, "application.png");
            this.imgListDirectory.Images.SetKeyName(4, "text.png");
            this.imgListDirectory.Images.SetKeyName(5, "archive.png");
            this.imgListDirectory.Images.SetKeyName(6, "word.png");
            this.imgListDirectory.Images.SetKeyName(7, "pdf.png");
            this.imgListDirectory.Images.SetKeyName(8, "image.png");
            this.imgListDirectory.Images.SetKeyName(9, "movie.png");
            this.imgListDirectory.Images.SetKeyName(10, "music.png");
            // 
            // botStrip
            // 
            this.botStrip.Location = new System.Drawing.Point(0, 383);
            this.botStrip.Name = "botStrip";
            this.botStrip.Size = new System.Drawing.Size(686, 22);
            this.botStrip.TabIndex = 3;
            this.botStrip.Text = "statusStrip1";
            // 
            // btnOpenDLFolder
            // 
            this.btnOpenDLFolder.Location = new System.Drawing.Point(531, 9);
            this.btnOpenDLFolder.Name = "btnOpenDLFolder";
            this.btnOpenDLFolder.Size = new System.Drawing.Size(139, 21);
            this.btnOpenDLFolder.TabIndex = 4;
            this.btnOpenDLFolder.Text = "&Open Download Folder";
            this.btnOpenDLFolder.UseVisualStyleBackColor = true;
            this.btnOpenDLFolder.Click += new System.EventHandler(this.btnOpenDLFolder_Click);
            // 
            // TabControlFileManager
            // 
            this.TabControlFileManager.Controls.Add(this.tabFileExplorer);
            this.TabControlFileManager.Controls.Add(this.tabTransfers);
            this.TabControlFileManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlFileManager.Location = new System.Drawing.Point(0, 0);
            this.TabControlFileManager.Name = "TabControlFileManager";
            this.TabControlFileManager.SelectedIndex = 0;
            this.TabControlFileManager.Size = new System.Drawing.Size(686, 383);
            this.TabControlFileManager.TabIndex = 5;
            // 
            // tabFileExplorer
            // 
            this.tabFileExplorer.Controls.Add(this.btnOpenDLFolder);
            this.tabFileExplorer.Controls.Add(this.lstDirectory);
            this.tabFileExplorer.Controls.Add(this.lblDrive);
            this.tabFileExplorer.Controls.Add(this.cmbDrives);
            this.tabFileExplorer.Location = new System.Drawing.Point(4, 22);
            this.tabFileExplorer.Name = "tabFileExplorer";
            this.tabFileExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.tabFileExplorer.Size = new System.Drawing.Size(678, 357);
            this.tabFileExplorer.TabIndex = 0;
            this.tabFileExplorer.Text = "File Explorer";
            this.tabFileExplorer.UseVisualStyleBackColor = true;
            // 
            // tabTransfers
            // 
            this.tabTransfers.Controls.Add(this.lstTransfers);
            this.tabTransfers.Location = new System.Drawing.Point(4, 22);
            this.tabTransfers.Name = "tabTransfers";
            this.tabTransfers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransfers.Size = new System.Drawing.Size(678, 357);
            this.tabTransfers.TabIndex = 1;
            this.tabTransfers.Text = "Transfers";
            this.tabTransfers.UseVisualStyleBackColor = true;
            // 
            // lstTransfers
            // 
            this.lstTransfers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTransfers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hID,
            this.hStatus,
            this.hFilename});
            this.lstTransfers.FullRowSelect = true;
            this.lstTransfers.GridLines = true;
            this.lstTransfers.Location = new System.Drawing.Point(8, 6);
            this.lstTransfers.Name = "lstTransfers";
            this.lstTransfers.Size = new System.Drawing.Size(662, 345);
            this.lstTransfers.SmallImageList = this.imgListTransfers;
            this.lstTransfers.TabIndex = 0;
            this.lstTransfers.UseCompatibleStateImageBehavior = false;
            this.lstTransfers.View = System.Windows.Forms.View.Details;
            // 
            // hID
            // 
            this.hID.Text = "ID";
            this.hID.Width = 128;
            // 
            // hStatus
            // 
            this.hStatus.Text = "Status";
            this.hStatus.Width = 112;
            // 
            // hFilename
            // 
            this.hFilename.Text = "Filename";
            this.hFilename.Width = 417;
            // 
            // imgListTransfers
            // 
            this.imgListTransfers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListTransfers.ImageStream")));
            this.imgListTransfers.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListTransfers.Images.SetKeyName(0, "cancel.png");
            this.imgListTransfers.Images.SetKeyName(1, "done.png");
            // 
            // frmFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 405);
            this.Controls.Add(this.TabControlFileManager);
            this.Controls.Add(this.botStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(663, 377);
            this.Name = "frmFileManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xRAT 2.0 - File Manager []";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFileManager_FormClosing);
            this.Load += new System.EventHandler(this.frmFileManager_Load);
            this.ctxtMenu.ResumeLayout(false);
            this.TabControlFileManager.ResumeLayout(false);
            this.tabFileExplorer.ResumeLayout(false);
            this.tabFileExplorer.PerformLayout();
            this.tabTransfers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.ImageList imgListDirectory;
        public System.Windows.Forms.ComboBox cmbDrives;
        public Controls.ListViewEx lstDirectory;
        private System.Windows.Forms.ColumnHeader hName;
        private System.Windows.Forms.ColumnHeader hSize;
        private System.Windows.Forms.ColumnHeader hType;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxtDownload;
        public System.Windows.Forms.StatusStrip botStrip;
        private System.Windows.Forms.Button btnOpenDLFolder;
        private System.Windows.Forms.TabControl TabControlFileManager;
        private System.Windows.Forms.TabPage tabFileExplorer;
        private System.Windows.Forms.TabPage tabTransfers;
        public Controls.ListViewEx lstTransfers;
        private System.Windows.Forms.ColumnHeader hStatus;
        private System.Windows.Forms.ColumnHeader hFilename;
        private System.Windows.Forms.ColumnHeader hID;
        private System.Windows.Forms.ImageList imgListTransfers;
    }
}