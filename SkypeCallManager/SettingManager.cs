using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SkypeCallManager.Properties;

namespace SkypeCallManager
{
    public static class SettingManager
    {
        /// <summary>
        /// 通話を切断する時間
        /// </summary>
        public static DateTime CallStopTime
        {
            get
            {
                return Settings.Default.CallStopTime;
            }
            set
            {
                Settings.Default.CallStopTime = value;
                Settings.Default.Save();
            }
        }

        public static string OneMinuteMessage
        {
            get
            {
                return Settings.Default.OneMinuteMessage;
            }
            set
            {
                Settings.Default.OneMinuteMessage = value;
                Settings.Default.Save();
            }
        }

        public static string ThreeMinuteMessage
        {
            get
            {
                return Settings.Default.ThreeMinuteMessage;
            }
            set
            {
                Settings.Default.ThreeMinuteMessage = value;
                Settings.Default.Save();
            }
        }

        public static string FiveMinuteMessage
        {
            get
            {
                return Settings.Default.FiveMinuteMessage;
            }
            set
            {
                Settings.Default.FiveMinuteMessage = value;
                Settings.Default.Save();
            }
        }

        public static string TenMinuteMessage
        {
            get
            {
                return Settings.Default.TenMinuteMessage;
            }
            set
            {
                Settings.Default.TenMinuteMessage = value;
                Settings.Default.Save();
            }
        }

        public static string FifteenMinuteMessage
        {
            get
            {
                return Settings.Default.FifteenMinuteMessage;
            }
            set
            {
                Settings.Default.FifteenMinuteMessage = value;
                Settings.Default.Save();
            }
        }
    }
}
