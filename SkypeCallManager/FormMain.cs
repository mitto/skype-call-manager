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
            toolStripMenuItemFileExit.Click += (sender, e) => Application.Exit();
            toolStripMenuItemFileSetting.Click += (sender, e) => new FormSetting().ShowDialog();

            buttonSkypeAttach.Click += (sender, e) => _skypeManager.AttachSkype();
            buttonAttachCheck.Click += (sender, e) => MessageBox.Show(_skypeManager.IsAttached ? "Skypeと接続しています" : "Skypeと接続できていません");
            buttonEndCall.Click += (sender, e) => _skypeManager.FinishActiveCall();

            timerMain.Tick +=
                (sender, e) =>
                {
                    var now = DateTime.Now;
                    var stoptime = SettingManager.CallStopTime;
                    stoptime = new DateTime(now.Year, now.Month, now.Day, stoptime.Hour, stoptime.Minute, stoptime.Second);
                    var diff = stoptime - now;

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
        }
    }
}
