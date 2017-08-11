using BoinTime.Properties;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BoinTime {
    public partial class MainForm : Form {

        #region Vars

        const int EXPANDED_HEIGHT  = 158;
        const int COLLAPSED_HEIGHT = 121;
        
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

        public MainForm() {
            InitializeComponent();
            Reminders.init();
            checkForNoReminders();
            time();

            // load settings
            pinned = Settings.Default.pinned;
            btnPin.Text = (pinned) ? "Move" : "Pin";
            this.Location = Settings.Default.location;
            closeWarning = Settings.Default.closeWarning;
            fadeOut = Settings.Default.fadeOut;
            this.ShowInTaskbar = Settings.Default.showInTaskbar;
        }

        private void checkForNoReminders() {
            if (Reminders.list.Count == 0) {
                txtReminder.Text = "No reminders set";
                txtReminder.SelectAll();
                txtReminder.SelectionAlignment = HorizontalAlignment.Center;
                txtReminder.SelectionLength = 0;
                defocus();
            }
        }

        private void defocus() {
            // take focus away from all controls
            btnFocus.Select();
            btnFocus.Focus();
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

        private void btnSettings_Click(object sender, EventArgs e) {
            // TODO: open settings form
        }

        private void btnManageReminders_Click(object sender, EventArgs e) {
            tmrMain.Stop();
            this.Hide();

            using (var remindersForm = new RemindersForm()) {
                remindersForm.ShowDialog();
            }

            checkForNoReminders();
            time(); // update time and reminders before showing the form again
            this.Show();
            tmrMain.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            // save non-user-set settings
            Settings.Default.pinned = pinned;
            Settings.Default.location = this.Location;
            Settings.Default.Save();
        }

        private void Form1_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e) {
            this.Opacity = 1.0;
        }

        private void Form1_MouseLeave(object sender, EventArgs e) {
            if (fadeOut && !this.Bounds.Contains(Cursor.Position)) {
                try {
                    this.Opacity = 0.7;
                } catch { } // should only error out if the Form is closing
            }
        }

        private void Form1_Leave(object sender, EventArgs e) {
            defocus();
        }

        #endregion

        #region Timer Stuff

        private void time() {
            var now = DateTime.Now;

            // set our time display
            lblMain.Text = now.ToString("h:mm tt", CultureInfo.InvariantCulture);
            lblSec.Text = now.Second.ToString().PadLeft(2, '0');

            // update our reminder
            // TODO: center text in box, bold the remaining time
            if (Reminders.list.Count > 0) {

            }
        }

        private void tmrMain_Tick(object sender, EventArgs e) {
            time();
        }

        #endregion
    }
}
