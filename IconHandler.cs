﻿using System;
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
        // Icon variables
        NotifyIcon icon;
        private delegate void CheckTargetDelegate(int param1, bool param2);
        private CheckTargetDelegate ctDelegate;
        private Boolean threadChecking = true;

        // Ping variables
        private static Ping ping = new Ping();
        public  static IPAddress address = IPAddress.Parse("192.168.1.101");
        private static PingReply reply;
        public  static int timeout = 500; //ms

        // Ping thread repetition rate
        public  static int loopPeriod = 1000; // ms

        ContextMenuStrip menu;

        public IconHandler()
        {
            icon = new NotifyIcon();
        }

        public void Display()
        {
            // Initialize Icon
            icon.Icon = TargetCheck.Properties.Resources.iconFalse;
            icon.Text = "Target Ready";
            icon.Visible = true;

            // Context Menu
            menu = new CxtMenu().Create();
            icon.ContextMenuStrip = menu;

            // Create thread to continuously check ping
            ctDelegate = new CheckTargetDelegate(this.CheckTarget);
            ctDelegate.BeginInvoke(0, false, null, null);
        }

        // Unused?
        public void Dispose()
        {
            // Kill looping thread
            threadChecking = false;

            // Remove Icon
            icon.Visible = false;
            icon.Dispose();

            Application.Exit();
        }

        private void CheckTarget(int param1, bool param2)
        {
            while (threadChecking)
            {
                // ping IP
                reply = ping.Send(address, timeout);
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
