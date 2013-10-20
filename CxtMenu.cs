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
        public ContextMenuStrip Create()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator separator;

            item = new ToolStripMenuItem();
            item.Text = "Set IP Address";
            item.Click += new EventHandler(setAddress);
            menu.Items.Add(item);

            item = new ToolStripMenuItem();
            item.Text = "Set Repetition Period";
            // item.Click += new EventHandler();
            menu.Items.Add(item);

            separator = new ToolStripSeparator();
            menu.Items.Add(separator);

            item = new ToolStripMenuItem();
            item.Text = "Close";
            item.Click += new EventHandler(Exit);
            menu.Items.Add(item);

            return menu;
        }

        void setAddress(object sender, EventArgs e)
        {
            IconHandler.address = IPAddress.Parse("208.113.228.159");
        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
