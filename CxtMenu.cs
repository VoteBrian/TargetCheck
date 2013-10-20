using System;
using System.Collections.Generic;
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
            BuildMenu();

            return menu;
        }

        void BuildMenu()
        {
            menu.Items.Clear();

            item = new ToolStripMenuItem();
            item.Text = "Change IP Address";
            item.Click += new EventHandler(setAddress);
            menu.Items.Add(item);

            label = new ToolStripLabel();
            label.Text = " " + IconHandler.address.ToString();
            menu.Items.Add(label);

            separator = new ToolStripSeparator();
            menu.Items.Add(separator);

            item = new ToolStripMenuItem();
            item.Text = "Set Repetition Period";
            // item.Click += new EventHandler();
            menu.Items.Add(item);

            label = new ToolStripLabel();
            label.Text = " " + IconHandler.loopPeriod.ToString() + " ms";
            menu.Items.Add(label);

            separator = new ToolStripSeparator();
            menu.Items.Add(separator);

            item = new ToolStripMenuItem();
            item.Text = "Close";
            item.Click += new EventHandler(Exit);
            menu.Items.Add(item);
        }

        void setAddress(object sender, EventArgs e)
        {
            IconHandler.address = IPAddress.Parse("208.113.228.159");
            BuildMenu();
        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
