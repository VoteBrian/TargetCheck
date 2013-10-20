using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargetCheck
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            TXT_ADDRESS.Text = IconHandler.address.ToString();
            TXT_PERIOD.Text = IconHandler.loopPeriod.ToString();
            TXT_TIMEOUT.Text = IconHandler.timeout.ToString();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // nothing
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            // TODO: Add error checking to all these.
            IconHandler.address = IPAddress.Parse(TXT_ADDRESS.Text.ToString());
            IconHandler.loopPeriod = int.Parse(TXT_PERIOD.Text);
            IconHandler.timeout = int.Parse(TXT_TIMEOUT.Text);

            this.Close();
        }
    }
}
