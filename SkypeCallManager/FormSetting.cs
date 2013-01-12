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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSettingLoad(object sender, EventArgs e)
        {
            LoadSettings();
            RegisterEventHandler();
        }

        private void LoadSettings()
        {
            dateTimePickerStopTime.Value = SettingManager.CallStopTime;
        }

        private void RegisterEventHandler()
        {
            buttonClose.Click += (sender, e) => this.Close();

            dateTimePickerStopTime.ValueChanged += (sender, e) => SettingManager.CallStopTime = dateTimePickerStopTime.Value;
        }
    }
}
