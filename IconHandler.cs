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
        static IPAddress address = IPAddress.Parse("10.0.0.0");
        static PingReply reply;

        public IconHandler()
        {
            icon = new NotifyIcon();
        }

        public void Display()
        {
            icon.MouseClick += new MouseEventHandler(icon_MouseClick);
            icon.Icon = System.Drawing.SystemIcons.Information;
            icon.Text = "Target Ready";
            icon.Visible = true;

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

        void icon_MouseClick(object sender, MouseEventArgs args)
        {
            // TODO: On right-click, show settings menu
            // Change target IP address
            // Change loop period
            Dispose();
        }

        private void CheckTarget(int param1, bool param2)
        {
            while (threadChecking)
            {
                // ping IP
                reply = ping.Send(address);
                if (reply.RoundtripTime < 200)
                {
                    icon.Icon = TargetCheck.Properties.Resources.iconTrue;
                }
                else
                {
                    icon.Icon = TargetCheck.Properties.Resources.iconFalse;
                }

                // wait 
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
