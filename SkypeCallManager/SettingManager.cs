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
        
    }
}
