using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoinTime {
    public partial class RemindersForm : Form {

        EditReminder editReminder;

        public RemindersForm() {
            InitializeComponent();
            listReminders();
        }

        private void listReminders() {
            tmrMain.Stop();

            // remove all controls from the panel
            foreach (Control control in panel.Controls) {
                control.Dispose();
            }

            panel.Controls.Clear();

            // stop redrawing panel
            panel.SuspendLayout();

            // add all reminders in ReminderDisplays to the panel
            foreach (var reminder in Reminders.instance.list) {
                var rd = new ReminderDisplay(reminder);
                panel.Controls.Add(rd);
                rd.Dock = DockStyle.Top;
                rd.BringToFront();
                rd.edit += new EventHandler<ReminderEventArgs>(reminderDisplay_edit);
            }

            // resume redrawing panel
            panel.ResumeLayout();
            tmrMain.Start();
        }

        private void showEditControl(Reminder reminder = null) {
            // get rid of it if it already exists
            if (editReminder != null) {
                editReminder.Dispose();
            }

            // add it to the top of panel
            editReminder = new EditReminder(reminder);
            panel.Controls.Add(editReminder);
            editReminder.Dock = DockStyle.Top;
            editReminder.SendToBack();
            editReminder.editDone += new EventHandler<ReminderEventArgs>(editReminder_editDone);

            // scroll panel to top
            panel.AutoScrollPosition = new Point(0, 0);
        }

        private void btnNew_Click(object sender, EventArgs e) {
            showEditControl();
        }

        private void editReminder_editDone(object sender, ReminderEventArgs e) {
            // if a reminder was just created, add it to the list
            if (e.isNew) {
                Reminders.instance.list.Add(e.reminder);
            }

            listReminders();
        }

        private void reminderDisplay_edit(object sender, ReminderEventArgs e) {
            showEditControl(e.reminder);
        }

        private void RemindersForm_FormClosing(object sender, FormClosingEventArgs e) {
            // write reminders to a file when closing
            Reminders.instance.save();
        }

        private void tmrMain_Tick(object sender, EventArgs e) {
            // remove all expired Reminders
            Reminders.instance.removeExpired();

            // update each ReminderDisplay's remaining time label
            // dispose ReminderDisplays for expired reminders
            foreach (var control in panel.Controls) {
                if (control is ReminderDisplay) {
                    var rd = control as ReminderDisplay;

                    rd.updateTime();
                    if (rd.reminder.expired) {
                        rd.Dispose();
                    }
                }
            }

            // show notificaions if ready
            Reminders.instance.showNotifications();
        }
    }
}
