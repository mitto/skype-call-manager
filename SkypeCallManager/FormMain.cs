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
                    if (now.Hour == stoptime.Hour && now.Minute == stoptime.Minute)
                    {
                        _skypeManager.FinishActiveCall();
                    }
                };
        }
    }
}
