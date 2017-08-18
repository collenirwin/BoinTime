using BoinTime.Properties;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace BoinTime {
    public partial class SettingsForm : Form {

        public SettingsForm() {
            InitializeComponent();

            // set checkboxes to reflect user settings
            chkShowAMPM.Checked = Settings.Default.showAMPM;
            chk24Hour.Checked = Settings.Default.use24HourFormat;
            chkCloseWarning.Checked = !Settings.Default.closeWarning;
            chkShowInTaskbar.Checked = Settings.Default.showInTaskbar;

            // get version number
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // remove the revision section of the version number for display
            lblVersion.Text = lblVersion.Tag.ToString() +
                version.Substring(0, version.LastIndexOf('.'));
        }

        private void tmrMain_Tick(object sender, EventArgs e) {
            // We still need to keep track of reminders while we're in the settings form
            Reminders.instance.showNotifications();
            Reminders.instance.removeExpired();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            // save all settings and close
            Settings.Default.showAMPM = chkShowAMPM.Checked;
            Settings.Default.showInTaskbar = chkShowInTaskbar.Checked;
            Settings.Default.closeWarning = !chkCloseWarning.Checked;
            Settings.Default.use24HourFormat = chk24Hour.Checked;
            Settings.Default.Save();

            this.Close();
        }

        private void chk24Hour_CheckedChanged(object sender, EventArgs e) {
            // showAMPM can't be enabled if we're using 24 hour time
            chkShowAMPM.Enabled = !chk24Hour.Checked;
            if (chk24Hour.Checked) {
                chkShowAMPM.Checked = false;
            }
        }
    }
}
