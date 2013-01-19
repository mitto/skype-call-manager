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
            Icon = Properties.Resources.skype;
        }

        private void LoadSettings()
        {
            dateTimePickerStopTime.Value = SettingManager.CallStopTime;
            textBoxDisconnectMessage.Text = SettingManager.DisconnectMessage;
            textBoxOneMinuteMessage.Text = SettingManager.OneMinuteMessage;
            textBoxThreeMinuteMessage.Text = SettingManager.ThreeMinuteMessage;
            textBoxFiveMinuteMessage.Text = SettingManager.FiveMinuteMessage;
            textBoxTenMinuteMessage.Text = SettingManager.TenMinuteMessage;
            textBoxFifteenMinuteMessage.Text = SettingManager.FifteenMinuteMessage;
            textBoxSign.Text = SettingManager.Sign;

            checkBoxAutoHideForm.Checked = SettingManager.IsBootVisible;
            checkBoxTrayNotificationEnable.Checked = SettingManager.IsTrayNotificationEnabled;

            if (SettingManager.IsSignAfter)
            {
                radioButtonSignAfter.Checked = true;
            }
            else
            {
                radioButtonSignBefore.Checked = true;
            }
        }

        private void RegisterEventHandler()
        {
            buttonClose.Click += (sender, e) => this.Close();

            dateTimePickerStopTime.ValueChanged += (sender, e) => SettingManager.CallStopTime = dateTimePickerStopTime.Value;

            textBoxDisconnectMessage.TextChanged += (sender, e) => SettingManager.DisconnectMessage = textBoxDisconnectMessage.Text;
            textBoxOneMinuteMessage.TextChanged += (sender, e) => SettingManager.OneMinuteMessage = textBoxOneMinuteMessage.Text;
            textBoxThreeMinuteMessage.TextChanged += (sender, e) => SettingManager.ThreeMinuteMessage = textBoxThreeMinuteMessage.Text;
            textBoxFiveMinuteMessage.TextChanged += (sender, e) => SettingManager.FiveMinuteMessage = textBoxFiveMinuteMessage.Text;
            textBoxTenMinuteMessage.TextChanged += (sender, e) => SettingManager.TenMinuteMessage = textBoxTenMinuteMessage.Text;
            textBoxFifteenMinuteMessage.TextChanged += (sender, e) => SettingManager.FifteenMinuteMessage = textBoxFifteenMinuteMessage.Text;
            textBoxSign.TextChanged += (sender, e) => SettingManager.Sign = textBoxSign.Text;

            radioButtonSignAfter.Click += (sender, e) => SettingManager.IsSignAfter = true;
            radioButtonSignBefore.Click += (sender, e) => SettingManager.IsSignAfter = false;

            checkBoxAutoHideForm.CheckedChanged += (sender, e) => SettingManager.IsBootVisible = checkBoxAutoHideForm.Checked;
            checkBoxTrayNotificationEnable.CheckedChanged += (sender, e) => SettingManager.IsTrayNotificationEnabled = checkBoxTrayNotificationEnable.Checked;
        }

    }
}
