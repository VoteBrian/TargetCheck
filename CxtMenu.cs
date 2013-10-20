using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace TargetCheck
{
    class CxtMenu
    {
        ContextMenuStrip menu = new ContextMenuStrip();
        ToolStripMenuItem item = new ToolStripMenuItem();
        ToolStripSeparator separator = new ToolStripSeparator();
        ToolStripLabel label = new ToolStripLabel();

        public ContextMenuStrip Create()
        {
            return BuildMenu();
        }

        private ContextMenuStrip BuildMenu()
        {
            menu.Items.Clear();

            // Settings Menu
            item = new ToolStripMenuItem();
            item.Text = "Settings:";
            item.ForeColor = SystemColors.Highlight;
            item.Click += new EventHandler(openSettings);
            menu.Items.Add(item);

            // Current Address
            label = new ToolStripLabel();
            label.Text = "[" + IconHandler.address.ToString() + "]";
            label.ForeColor = SystemColors.ControlDark;
            menu.Items.Add(label);

            // Current Period
            label = new ToolStripLabel();
            label.Text = "Period: " + IconHandler.loopPeriod.ToString() + " ms";
            label.ForeColor = SystemColors.ControlDark;
            menu.Items.Add(label);

            // Current Timeout
            label = new ToolStripLabel();
            label.Text = "Timeout: " + IconHandler.timeout.ToString() + " ms";
            label.ForeColor = SystemColors.ControlDark;
            menu.Items.Add(label);

            separator = new ToolStripSeparator();
            menu.Items.Add(separator);

            // Close
            item = new ToolStripMenuItem();
            item.Text = "Close";
            item.Click += new EventHandler(Exit);
            menu.Items.Add(item);

            return menu;
        }

        void openSettings(Object sender, EventArgs e)
        {
            // Open Settings Form and wait for close
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();

            // Update context menu with new values
            BuildMenu();
        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
