using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkypeCallManager
{
    public partial class FormMain : Form
    {
        private readonly SkypeManager _skypeManager = new SkypeManager();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            RegisterEventHandler();

            timerMain.Enabled = true;
        }

        private void RegisterEventHandler()
        {
            Shown += (sender, e) =>
                {
                    SetVisible(false);
                    _skypeManager.AttachSkype();
                };
            FormClosing +=
                (sender, e) =>
                {
                    if (e.CloseReason == CloseReason.UserClosing)
                    {
                        e.Cancel = true;
                        SetVisible(false);
                    }
                };

            notifyIconMain.MouseClick +=
                (sender, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        SetVisible(!Visible);
                    }
                };


            toolStripMenuItemFileExit.Click += (sender, e) => Application.Exit();
            toolStripMenuItemFileSetting.Click +=
                (sender, e) =>
                {
                    new FormSetting().ShowDialog();
                    UpdateLabelStatus();
                };
            toolStripMenuItemTrayRightExit.Click += (sender, e) => Application.Exit();
            toolStripMenuItemToolSkypeAttach.Click += (sender, e) => _skypeManager.AttachSkype();
            toolStripMenuItemToolCloseActiveCalls.Click += (sender, e) => _skypeManager.FinishActiveCall();

            UpdateLabelStatus();
            timerMain.Tick +=
                (sender, e) =>
                {
                    var now = DateTime.Now;
                    var stoptime = SettingManager.CallStopTime;
                    stoptime = new DateTime(now.Year, now.Month, now.Day, stoptime.Hour, stoptime.Minute, stoptime.Second);
                    var diff = stoptime - now;

                    UpdateLabelStatus();

                    switch (diff.Minutes)
                    {
                        case 1:
                            if (string.IsNullOrWhiteSpace(SettingManager.OneMinuteMessage)) return;
                            _skypeManager.SendMessageToCallPartner(SettingManager.OneMinuteMessage);
                            break;
                        case 3:
                            if (string.IsNullOrWhiteSpace(SettingManager.ThreeMinuteMessage)) return;
                            _skypeManager.SendMessageToCallPartner(SettingManager.ThreeMinuteMessage);
                            break;
                        case 5:
                            if (string.IsNullOrWhiteSpace(SettingManager.FiveMinuteMessage)) return;
                            _skypeManager.SendMessageToCallPartner(SettingManager.FiveMinuteMessage);
                            break;
                        case 10:
                            if (string.IsNullOrWhiteSpace(SettingManager.TenMinuteMessage)) return;
                            _skypeManager.SendMessageToCallPartner(SettingManager.TenMinuteMessage);
                            break;
                        case 15:
                            if (string.IsNullOrWhiteSpace(SettingManager.FifteenMinuteMessage)) return;
                            _skypeManager.SendMessageToCallPartner(SettingManager.FifteenMinuteMessage);
                            break;
                    }

                    if (now.Hour == stoptime.Hour && now.Minute == stoptime.Minute)
                    {
                        _skypeManager.FinishActiveCall();
                    }
                };

            _skypeManager.ChangeAttachmentStatus +=
                (sender, e) =>
                {
                    toolStripStatusLabelSkypeAttachStatus.Text = SkypeManager.GetAttachmentStatusMessage(_skypeManager.AttachmentStatus);
                };
            _skypeManager.IsEnabledCheckAttachmentStatusTimer = true;
        }

        private void SetVisible(Boolean isVisible)
        {
            if (isVisible)
            {
                ShowInTaskbar = true;
                Visible = true;
                Focus();
            }
            else
            {
                Visible = false;
                ShowInTaskbar = false;
            }
        }

        private void UpdateLabelStatus()
        {
            var now = DateTime.Now;
            var calltime = SettingManager.CallStopTime;
            calltime = new DateTime(now.Year, now.Month, now.Day, calltime.Hour, calltime.Minute, calltime.Second);
            var diff = calltime - now;

            if (diff < new TimeSpan(0, 0, 0))
            {
                calltime = calltime.AddDays(1);
                diff = calltime - now;
            }

            labelSettingTime.Text = String.Format("{0}", calltime.ToString("yyyy/MM/dd HH:mm"));
            labelToSettingTime.Text = String.Format("{0}時間{1}分くらい", diff.Hours, diff.Minutes);
        }
    }
}
