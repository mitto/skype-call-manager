using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SKYPE4COMLib;

using Growl_for_Skype_Notification;

namespace SkypeCallManager
{
    public class SkypeManager : SkypeManagerBase
    {
        public SkypeManager()
        {
        }

        public void FinishActiveCall()
        {
            foreach (Call call in Skype.ActiveCalls)
            {
                call.Finish(); 
            }
        }

        public bool ExistsActiveCalls
        {
            get
            {
                return Skype.ActiveCalls.Count > 0;
            }
        }

        public void SendMessageToCallPartner(string message)
        {
            foreach (Call call in Skype.ActiveCalls)
            {
                Skype.SendMessage(call.PartnerHandle, message);
            }
        }
    }
}
