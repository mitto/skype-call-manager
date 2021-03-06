﻿using System;
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
            Icon = Properties.Resources.skype;
        }

        private void RegisterEventHandler()
        {
            Shown += (sender, e) =>
                {
                    SetVisible(SettingManager.IsBootVisible);
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
            toolStripMenuItemHelpCheckUpdate.Click += (sender, e) => Growl_for_Skype_Notification.Utilities.CheckNewDeployment();
            toolStripMenuItemHelpVersion.Click += (sender, e) => Growl_for_Skype_Notification.Utilities.AboutSoftware();

            UpdateLabelStatus();
            timerMain.Tick +=
                (sender, e) =>
                {
                    var now = DateTime.Now;
                    var stoptime = SettingManager.CallStopTime;
                    stoptime = new DateTime(now.Year, now.Month, now.Day, stoptime.Hour, stoptime.Minute, stoptime.Second);
                    var diff = stoptime - now;

                    UpdateLabelStatus();
                    if (!_skypeManager.ExistsActiveCalls || diff.Hours > 0 || diff.Seconds != 0) return;

                    var message = "";
                    var isAlert = false;

                    switch ((int)diff.TotalMinutes)
                    {
                        case 0:
                            _skypeManager.FinishActiveCall();
                            message = SettingManager.DisconnectMessage;
                            isAlert = true;
                            break;
                        case 1:
                            message = SettingManager.OneMinuteMessage;
                            isAlert = true;
                            break;
                        case 3:
                            message = SettingManager.ThreeMinuteMessage;
                            isAlert = true;
                            break;
                        case 5:
                            message = SettingManager.FiveMinuteMessage;
                            isAlert = true;
                            break;
                        case 10:
                            message = SettingManager.TenMinuteMessage;
                            isAlert = true;
                            break;
                        case 15:
                            message = SettingManager.FifteenMinuteMessage;
                            isAlert = true;
                            break;
                    }

                    if (isAlert && SettingManager.IsTrayNotificationEnabled) AlertBalloon((int)diff.TotalMinutes, stoptime);
                    if (string.IsNullOrWhiteSpace(message)) return;

                    if (SettingManager.IsSignAfter)
                    {
                        message += SettingManager.Sign;
                    }
                    else
                    {
                        message = SettingManager.Sign + message;
                    }

                    _skypeManager.SendMessageToCallPartner(message);
                };

            _skypeManager.ChangeAttachmentStatus += (sender, e) =>
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

            labelSettingTime.Text = String.Format("{0}", calltime.ToString("yyyy/MM/dd HH:mm:ss"));
            var message = "";
            if (_skypeManager.ExistsActiveCalls)
            {
                message = String.Format("{0:00}時間{1:00}分{2:00}秒くらい", diff.Hours, diff.Minutes, diff.Seconds);
            }
            else
            {
                message = "No active calls.";
            }
            labelToSettingTime.Text = message;
        }

        private void AlertBalloon(int minute, DateTime endtime)
        {
            var title = minute == 0 ? Properties.Resources.Information : string.Format("通話を切るまであと{0}分くらいです", minute);
            var message = minute == 0 ? "通話を終了しました" : string.Format("通話終了予定時刻\n「{0}」", endtime.ToString("yyyy/MM/dd HH:mm:ss"));
            AlertBalloon(title, message);
        }

        private void AlertBalloon(string title, string message, ToolTipIcon icon = ToolTipIcon.Info, int time = 5000)
        {
            notifyIconMain.BalloonTipTitle = title;
            notifyIconMain.BalloonTipText = message;
            notifyIconMain.BalloonTipIcon = icon;
            notifyIconMain.ShowBalloonTip(time);
        }
    }
}
