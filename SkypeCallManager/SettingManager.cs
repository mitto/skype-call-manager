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
                var time = Settings.Default.CallStopTime;
                var now = DateTime.Now;
                return new DateTime(now.Year, now.Month, now.Day, time.Hours, time.Minutes, 0);
            }
            set
            {
                Settings.Default.CallStopTime = new TimeSpan(value.Hour, value.Minute, 0);
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

        public static bool IsSignAfter
        {
            get
            {
                return Settings.Default.IsSignAfter;
            }
            set
            {
                Settings.Default.IsSignAfter = value;
                Settings.Default.Save();
            }
        }

        public static string Sign
        {
            get
            {
                return Settings.Default.Sign;
            }
            set
            {
                Settings.Default.Sign = value;
                Settings.Default.Save();
            }
        }

        public static bool IsBootVisible
        {
            get
            {
                return Settings.Default.IsBootVisible;
            }
            set
            {
                Settings.Default.IsBootVisible = value;
                Settings.Default.Save();
            }
        }

        public static bool IsTrayNotificationEnabled
        {
            get
            {
                return Settings.Default.IsTrayNotificationEnable;
            }
            set
            {
                Settings.Default.IsTrayNotificationEnable = value;
                Settings.Default.Save();
            }
        }

        public static string DisconnectMessage
        {
            get
            {
                return Settings.Default.DisconnectMessage;
            }
            set
            {
                Settings.Default.DisconnectMessage = value;
                Settings.Default.Save();
            }
        }
    }
}
