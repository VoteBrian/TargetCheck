using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;

namespace TargetCheck
{
    class IconHandler : IDisposable
    {
        NotifyIcon icon;
        private delegate void CheckTargetDelegate(int param1, bool param2);
        private CheckTargetDelegate ctDelegate;
        Boolean threadChecking = true;

        static Ping ping = new Ping();
        public static IPAddress address = IPAddress.Parse("192.168.1.101");
        PingOptions options = new PingOptions();
        static PingReply reply;

        public static int loopPeriod = 500;

        ContextMenuStrip menu;

        public IconHandler()
        {
            icon = new NotifyIcon();
        }

        public void Display()
        {
            icon.Icon = TargetCheck.Properties.Resources.iconFalse;
            icon.Text = "Target Ready";
            icon.Visible = true;

            menu = new CxtMenu().Create();
            icon.ContextMenuStrip = menu;

            ctDelegate = new CheckTargetDelegate(this.CheckTarget);
            ctDelegate.BeginInvoke(0, false, null, null);
        }

        public void Dispose()
        {
            threadChecking = false;
            icon.Visible = false;
            icon.Dispose();

            Application.Exit();
        }

        private void CheckTarget(int param1, bool param2)
        {
            while (threadChecking)
            {
                // ping IP
                reply = ping.Send(address);
                if (reply.Status == IPStatus.Success)
                {
                    icon.Icon = TargetCheck.Properties.Resources.iconTrue;
                }
                else
                {
                    icon.Icon = TargetCheck.Properties.Resources.iconFalse;
                }

                // wait 
                System.Threading.Thread.Sleep(loopPeriod);
            }
        }
    }
}
