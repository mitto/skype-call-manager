namespace SkypeCallManager
{
    partial class FormSetting
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
            this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageGeneralSetting = new System.Windows.Forms.TabPage();
            this.dateTimePickerStopTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageChatSetting = new System.Windows.Forms.TabPage();
            this.groupBoxChatMessages = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOneMinuteMessage = new System.Windows.Forms.TextBox();
            this.textBoxThreeMinuteMessage = new System.Windows.Forms.TextBox();
            this.textBoxFiveMinuteMessage = new System.Windows.Forms.TextBox();
            this.textBoxTenMinuteMessage = new System.Windows.Forms.TextBox();
            this.textBoxFifteenMinuteMessage = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.toolStripContainerMain.ContentPanel.SuspendLayout();
            this.toolStripContainerMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneralSetting.SuspendLayout();
            this.tabPageChatSetting.SuspendLayout();
            this.groupBoxChatMessages.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainerMain
            // 
            this.toolStripContainerMain.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainerMain.ContentPanel
            // 
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.panel2);
            this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(284, 262);
            this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerMain.LeftToolStripPanelVisible = false;
            this.toolStripContainerMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerMain.Name = "toolStripContainerMain";
            this.toolStripContainerMain.RightToolStripPanelVisible = false;
            this.toolStripContainerMain.Size = new System.Drawing.Size(284, 262);
            this.toolStripContainerMain.TabIndex = 0;
            this.toolStripContainerMain.Text = "toolStripContainer1";
            this.toolStripContainerMain.TopToolStripPanelVisible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 223);
            this.panel1.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageGeneralSetting);
            this.tabControlMain.Controls.Add(this.tabPageChatSetting);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(284, 223);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageGeneralSetting
            // 
            this.tabPageGeneralSetting.Controls.Add(this.dateTimePickerStopTime);
            this.tabPageGeneralSetting.Controls.Add(this.label1);
            this.tabPageGeneralSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneralSetting.Name = "tabPageGeneralSetting";
            this.tabPageGeneralSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneralSetting.Size = new System.Drawing.Size(276, 197);
            this.tabPageGeneralSetting.TabIndex = 0;
            this.tabPageGeneralSetting.Text = "全般";
            this.tabPageGeneralSetting.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStopTime
            // 
            this.dateTimePickerStopTime.CustomFormat = "HH:mm";
            this.dateTimePickerStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStopTime.Location = new System.Drawing.Point(209, 6);
            this.dateTimePickerStopTime.Name = "dateTimePickerStopTime";
            this.dateTimePickerStopTime.ShowUpDown = true;
            this.dateTimePickerStopTime.Size = new System.Drawing.Size(64, 19);
            this.dateTimePickerStopTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "この時間になったら通話を止める";
            // 
            // tabPageChatSetting
            // 
            this.tabPageChatSetting.Controls.Add(this.groupBoxChatMessages);
            this.tabPageChatSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPageChatSetting.Name = "tabPageChatSetting";
            this.tabPageChatSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChatSetting.Size = new System.Drawing.Size(276, 197);
            this.tabPageChatSetting.TabIndex = 1;
            this.tabPageChatSetting.Text = "チャット";
            this.tabPageChatSetting.UseVisualStyleBackColor = true;
            // 
            // groupBoxChatMessages
            // 
            this.groupBoxChatMessages.Controls.Add(this.label2);
            this.groupBoxChatMessages.Controls.Add(this.label3);
            this.groupBoxChatMessages.Controls.Add(this.label4);
            this.groupBoxChatMessages.Controls.Add(this.label5);
            this.groupBoxChatMessages.Controls.Add(this.label6);
            this.groupBoxChatMessages.Controls.Add(this.textBoxOneMinuteMessage);
            this.groupBoxChatMessages.Controls.Add(this.textBoxThreeMinuteMessage);
            this.groupBoxChatMessages.Controls.Add(this.textBoxFiveMinuteMessage);
            this.groupBoxChatMessages.Controls.Add(this.textBoxTenMinuteMessage);
            this.groupBoxChatMessages.Controls.Add(this.textBoxFifteenMinuteMessage);
            this.groupBoxChatMessages.Location = new System.Drawing.Point(8, 6);
            this.groupBoxChatMessages.Name = "groupBoxChatMessages";
            this.groupBoxChatMessages.Size = new System.Drawing.Size(260, 185);
            this.groupBoxChatMessages.TabIndex = 2;
            this.groupBoxChatMessages.TabStop = false;
            this.groupBoxChatMessages.Text = "切断前に送信するメッセージ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "1分前";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "3分前";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "5分前";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "10分前";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "15分前";
            // 
            // textBoxOneMinuteMessage
            // 
            this.textBoxOneMinuteMessage.Location = new System.Drawing.Point(70, 18);
            this.textBoxOneMinuteMessage.Name = "textBoxOneMinuteMessage";
            this.textBoxOneMinuteMessage.Size = new System.Drawing.Size(184, 19);
            this.textBoxOneMinuteMessage.TabIndex = 1;
            // 
            // textBoxThreeMinuteMessage
            // 
            this.textBoxThreeMinuteMessage.Location = new System.Drawing.Point(70, 43);
            this.textBoxThreeMinuteMessage.Name = "textBoxThreeMinuteMessage";
            this.textBoxThreeMinuteMessage.Size = new System.Drawing.Size(184, 19);
            this.textBoxThreeMinuteMessage.TabIndex = 3;
            // 
            // textBoxFiveMinuteMessage
            // 
            this.textBoxFiveMinuteMessage.Location = new System.Drawing.Point(70, 68);
            this.textBoxFiveMinuteMessage.Name = "textBoxFiveMinuteMessage";
            this.textBoxFiveMinuteMessage.Size = new System.Drawing.Size(184, 19);
            this.textBoxFiveMinuteMessage.TabIndex = 5;
            // 
            // textBoxTenMinuteMessage
            // 
            this.textBoxTenMinuteMessage.Location = new System.Drawing.Point(70, 93);
            this.textBoxTenMinuteMessage.Name = "textBoxTenMinuteMessage";
            this.textBoxTenMinuteMessage.Size = new System.Drawing.Size(184, 19);
            this.textBoxTenMinuteMessage.TabIndex = 7;
            // 
            // textBoxFifteenMinuteMessage
            // 
            this.textBoxFifteenMinuteMessage.Location = new System.Drawing.Point(70, 118);
            this.textBoxFifteenMinuteMessage.Name = "textBoxFifteenMinuteMessage";
            this.textBoxFifteenMinuteMessage.Size = new System.Drawing.Size(184, 19);
            this.textBoxFifteenMinuteMessage.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 39);
            this.panel2.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.Location = new System.Drawing.Point(0, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(284, 39);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // FormSetting
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStripContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.FormSettingLoad);
            this.toolStripContainerMain.ContentPanel.ResumeLayout(false);
            this.toolStripContainerMain.ResumeLayout(false);
            this.toolStripContainerMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneralSetting.ResumeLayout(false);
            this.tabPageGeneralSetting.PerformLayout();
            this.tabPageChatSetting.ResumeLayout(false);
            this.groupBoxChatMessages.ResumeLayout(false);
            this.groupBoxChatMessages.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageGeneralSetting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DateTimePicker dateTimePickerStopTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageChatSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxChatMessages;
        private System.Windows.Forms.TextBox textBoxFifteenMinuteMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTenMinuteMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFiveMinuteMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxThreeMinuteMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOneMinuteMessage;

    }
}