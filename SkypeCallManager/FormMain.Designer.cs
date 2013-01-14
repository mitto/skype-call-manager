namespace SkypeCallManager
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
            this.buttonEndCall = new System.Windows.Forms.Button();
            this.buttonAttachCheck = new System.Windows.Forms.Button();
            this.buttonSkypeAttach = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripContainerMain.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.ContentPanel.SuspendLayout();
            this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainerMain
            // 
            // 
            // toolStripContainerMain.BottomToolStripPanel
            // 
            this.toolStripContainerMain.BottomToolStripPanel.Controls.Add(this.statusStripMain);
            // 
            // toolStripContainerMain.ContentPanel
            // 
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.buttonEndCall);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.buttonAttachCheck);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.buttonSkypeAttach);
            this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(284, 214);
            this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerMain.Name = "toolStripContainerMain";
            this.toolStripContainerMain.Size = new System.Drawing.Size(284, 262);
            this.toolStripContainerMain.TabIndex = 0;
            this.toolStripContainerMain.Text = "toolStripContainer1";
            // 
            // toolStripContainerMain.TopToolStripPanel
            // 
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.menuStripMain);
            // 
            // buttonEndCall
            // 
            this.buttonEndCall.Location = new System.Drawing.Point(12, 76);
            this.buttonEndCall.Name = "buttonEndCall";
            this.buttonEndCall.Size = new System.Drawing.Size(75, 23);
            this.buttonEndCall.TabIndex = 2;
            this.buttonEndCall.Text = "通話終了";
            this.buttonEndCall.UseVisualStyleBackColor = true;
            // 
            // buttonAttachCheck
            // 
            this.buttonAttachCheck.Location = new System.Drawing.Point(12, 47);
            this.buttonAttachCheck.Name = "buttonAttachCheck";
            this.buttonAttachCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonAttachCheck.TabIndex = 1;
            this.buttonAttachCheck.Text = "接続確認";
            this.buttonAttachCheck.UseVisualStyleBackColor = true;
            // 
            // buttonSkypeAttach
            // 
            this.buttonSkypeAttach.Location = new System.Drawing.Point(12, 18);
            this.buttonSkypeAttach.Name = "buttonSkypeAttach";
            this.buttonSkypeAttach.Size = new System.Drawing.Size(75, 23);
            this.buttonSkypeAttach.TabIndex = 0;
            this.buttonSkypeAttach.Text = "接続";
            this.buttonSkypeAttach.UseVisualStyleBackColor = true;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(284, 26);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileSetting,
            this.toolStripSeparator1,
            this.toolStripMenuItemFileExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(85, 22);
            this.toolStripMenuItemFile.Text = "ファイル(&F)";
            // 
            // toolStripMenuItemFileSetting
            // 
            this.toolStripMenuItemFileSetting.Name = "toolStripMenuItemFileSetting";
            this.toolStripMenuItemFileSetting.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemFileSetting.Text = "設定(&S)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // toolStripMenuItemFileExit
            // 
            this.toolStripMenuItemFileExit.Name = "toolStripMenuItemFileExit";
            this.toolStripMenuItemFileExit.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemFileExit.Text = "終了(&X)";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelpVersion});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(75, 22);
            this.toolStripMenuItemHelp.Text = "ヘルプ(&H)";
            // 
            // toolStripMenuItemHelpVersion
            // 
            this.toolStripMenuItemHelpVersion.Name = "toolStripMenuItemHelpVersion";
            this.toolStripMenuItemHelpVersion.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemHelpVersion.Text = "バージョン情報(&A)...";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 60000;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStripMain.Location = new System.Drawing.Point(0, 0);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(284, 22);
            this.statusStripMain.TabIndex = 0;
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "SkypeCallManager";
            this.notifyIconMain.Visible = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStripContainerMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMainLoad);
            this.toolStripContainerMain.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainerMain.BottomToolStripPanel.PerformLayout();
            this.toolStripContainerMain.ContentPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.PerformLayout();
            this.toolStripContainerMain.ResumeLayout(false);
            this.toolStripContainerMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelpVersion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button buttonSkypeAttach;
        private System.Windows.Forms.Button buttonAttachCheck;
        private System.Windows.Forms.Button buttonEndCall;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
    }
}

