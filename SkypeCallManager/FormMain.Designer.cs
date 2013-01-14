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
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSkypeAttachStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxTimerStatus = new System.Windows.Forms.GroupBox();
            this.labelSettingTime = new System.Windows.Forms.Label();
            this.labelToSettingTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemToolSkypeAttach = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemToolCloseActiveCalls = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTrayRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemTrayRightExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelpCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripContainerMain.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.ContentPanel.SuspendLayout();
            this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.groupBoxTimerStatus.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripTrayRight.SuspendLayout();
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
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.groupBoxTimerStatus);
            this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(284, 213);
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
            // statusStripMain
            // 
            this.statusStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSkypeAttachStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 0);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(284, 23);
            this.statusStripMain.TabIndex = 0;
            // 
            // toolStripStatusLabelSkypeAttachStatus
            // 
            this.toolStripStatusLabelSkypeAttachStatus.Name = "toolStripStatusLabelSkypeAttachStatus";
            this.toolStripStatusLabelSkypeAttachStatus.Size = new System.Drawing.Size(164, 18);
            this.toolStripStatusLabelSkypeAttachStatus.Text = "Skypeと接続されていません";
            // 
            // groupBoxTimerStatus
            // 
            this.groupBoxTimerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTimerStatus.Controls.Add(this.labelSettingTime);
            this.groupBoxTimerStatus.Controls.Add(this.labelToSettingTime);
            this.groupBoxTimerStatus.Controls.Add(this.label2);
            this.groupBoxTimerStatus.Controls.Add(this.label1);
            this.groupBoxTimerStatus.Location = new System.Drawing.Point(12, 15);
            this.groupBoxTimerStatus.Name = "groupBoxTimerStatus";
            this.groupBoxTimerStatus.Size = new System.Drawing.Size(260, 183);
            this.groupBoxTimerStatus.TabIndex = 0;
            this.groupBoxTimerStatus.TabStop = false;
            this.groupBoxTimerStatus.Text = "切断タイマーステータス";
            // 
            // labelSettingTime
            // 
            this.labelSettingTime.AutoSize = true;
            this.labelSettingTime.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSettingTime.Location = new System.Drawing.Point(18, 48);
            this.labelSettingTime.Name = "labelSettingTime";
            this.labelSettingTime.Size = new System.Drawing.Size(0, 36);
            this.labelSettingTime.TabIndex = 2;
            // 
            // labelToSettingTime
            // 
            this.labelToSettingTime.AutoSize = true;
            this.labelToSettingTime.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelToSettingTime.Location = new System.Drawing.Point(18, 125);
            this.labelToSettingTime.Name = "labelToSettingTime";
            this.labelToSettingTime.Size = new System.Drawing.Size(0, 36);
            this.labelToSettingTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "次の設定時間まであと：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "次の設定時間：";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemTool,
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
            // toolStripMenuItemTool
            // 
            this.toolStripMenuItemTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemToolSkypeAttach,
            this.toolStripSeparator2,
            this.toolStripMenuItemToolCloseActiveCalls});
            this.toolStripMenuItemTool.Name = "toolStripMenuItemTool";
            this.toolStripMenuItemTool.Size = new System.Drawing.Size(74, 22);
            this.toolStripMenuItemTool.Text = "ツール(&T)";
            // 
            // toolStripMenuItemToolSkypeAttach
            // 
            this.toolStripMenuItemToolSkypeAttach.Name = "toolStripMenuItemToolSkypeAttach";
            this.toolStripMenuItemToolSkypeAttach.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItemToolSkypeAttach.Text = "Skypeへ接続(&C)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
            // 
            // toolStripMenuItemToolCloseActiveCalls
            // 
            this.toolStripMenuItemToolCloseActiveCalls.Name = "toolStripMenuItemToolCloseActiveCalls";
            this.toolStripMenuItemToolCloseActiveCalls.Size = new System.Drawing.Size(244, 22);
            this.toolStripMenuItemToolCloseActiveCalls.Text = "アクティブな通話をすべて終了";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelpCheckUpdate,
            this.toolStripSeparator3,
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
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripTrayRight;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "SkypeCallManager";
            this.notifyIconMain.Visible = true;
            // 
            // contextMenuStripTrayRight
            // 
            this.contextMenuStripTrayRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTrayRightExit});
            this.contextMenuStripTrayRight.Name = "contextMenuStripTrayRight";
            this.contextMenuStripTrayRight.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItemTrayRightExit
            // 
            this.toolStripMenuItemTrayRightExit.Name = "toolStripMenuItemTrayRightExit";
            this.toolStripMenuItemTrayRightExit.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItemTrayRightExit.Text = "終了";
            // 
            // toolStripMenuItemHelpCheckUpdate
            // 
            this.toolStripMenuItemHelpCheckUpdate.Name = "toolStripMenuItemHelpCheckUpdate";
            this.toolStripMenuItemHelpCheckUpdate.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemHelpCheckUpdate.Text = "最新版を確認";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStripContainerMain);
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(300, 300);
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
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBoxTimerStatus.ResumeLayout(false);
            this.groupBoxTimerStatus.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripTrayRight.ResumeLayout(false);
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
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTrayRight;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTrayRightExit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSkypeAttachStatus;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTool;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemToolSkypeAttach;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemToolCloseActiveCalls;
        private System.Windows.Forms.GroupBox groupBoxTimerStatus;
        private System.Windows.Forms.Label labelToSettingTime;
        private System.Windows.Forms.Label labelSettingTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelpCheckUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

