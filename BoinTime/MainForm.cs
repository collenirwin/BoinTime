using BoinTime.Properties;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BoinTime {
    public partial class MainForm : Form {

        #region Vars

        static MainForm _instance;
        public static MainForm instance {
            get {
                if (_instance == null) {
                    _instance = new MainForm();
                }

                return _instance;
            }
        }

        bool pinned;

        public static bool closeWarning;
        public static bool fadeOut;

        #region user32 Stuff

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #endregion

        #region Constructor & Form Events

        private MainForm() {
            InitializeComponent();

            setReminder();
            time();

            applySettings();

            // start global timer
            tmrMain.Start();
        }

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e) {
            if (!pinned) {
                // dragging
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnPin_Click(object sender, EventArgs e) {
            pinned = !pinned;
            btnPin.Text = (btnPin.Text == "Pin") ? "Move" : "Pin";
        }

        private void btnClose_Click(object sender, EventArgs e) {
            // toggle secondary close button if closeWarning is set
            if (Settings.Default.closeWarning) {
                btnReallyClose.Visible = !btnReallyClose.Visible;
                btnClose.Text = (btnClose.Text == "Close") ? "Cancel" : "Close";
            } else {
                this.Close();
            }
        }

        private void btnReallyClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            // save non-user-set settings
            Settings.Default.pinned = pinned;
            Settings.Default.location = this.Location;
            Settings.Default.Save();

            // clear system tray icon
            notification.Visible = false;

            // serialize reminders and save them
            Reminders.instance.save();
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            tmrMain.Stop();
            this.Hide();


            using (var settingsForm = new SettingsForm()) {
                settingsForm.ShowDialog();
            }

            applySettings(); // apply what the user just changed

            // update time and reminders before showing the form again
            setReminder();
            time();
            this.Show();
            tmrMain.Start();
        }

        private void btnManageReminders_Click(object sender, EventArgs e) {
            tmrMain.Stop();
            this.Hide();


            using (var remindersForm = new RemindersForm()) {
                remindersForm.ShowDialog();
            }

            // update time and reminders before showing the form again
            setReminder();
            time();
            this.Show();
            tmrMain.Start();
        }

        private void Form1_Resize(object sender, EventArgs e) {
            // don't allow the form to minimize
            if (this.WindowState == FormWindowState.Minimized) {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e) {
            defocus();
        }

        private void Form1_Leave(object sender, EventArgs e) {
            defocus();
        }

        #endregion

        #region Helper Methods

        private void applySettings() {
            // apply user settings
            pinned = Settings.Default.pinned;
            btnPin.Text = (pinned) ? "Move" : "Pin";

            this.Location = Settings.Default.location;

            closeWarning = Settings.Default.closeWarning;
            this.ShowInTaskbar = Settings.Default.showInTaskbar;
            lblAMPM.Visible = Settings.Default.showAMPM;
        }

        private void setReminder() {
            // no reminder available
            if (Reminders.instance.list.Count == 0) {
                this.Size = this.MinimumSize; // don't show the reminder labels
            } else { // we have reminders
                this.Size = this.MaximumSize;

                // sort reminders by their remaining time and display the next one to go off
                Reminders.instance.sort();
                lblReminder.Text     = Reminders.instance.list[0].description;
                lblReminderTime.Text = Reminders.instance.list[0].timeRemainingPrettified();
            }
        }

        private void defocus() {
            // take focus away from all controls
            btnFocus.Select();
            btnFocus.Focus();
        }

        #endregion

        #region Timer Stuff

        private void time() {
            var now = DateTime.Now;

            // set our time display
            if (Settings.Default.use24HourFormat) {
                lblMain.Text = now.ToString("H:mm", CultureInfo.InvariantCulture);
            } else {
                lblMain.Text = now.ToString("h:mm", CultureInfo.InvariantCulture);
            }
            
            // seconds
            lblSec.Text = now.Second.ToString().PadLeft(2, '0');

            // AM / PM
            lblAMPM.Text = now.ToString("tt", CultureInfo.InvariantCulture);
        }

        private void tmrMain_Tick(object sender, EventArgs e) {
            time(); // update time display
            setReminder(); // update reminder
            Reminders.instance.showNotifications(); // show notificaions if ready
            Reminders.instance.removeExpired(); // remove all expired Reminders
        }

        #endregion

        #region Context Menu Strip

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion
    }
}
