using BoinMsgNS;
using System;
using System.Windows.Forms;

namespace BoinTime {
    public partial class ReminderDisplay : UserControl {

        public event EventHandler<ReminderEventArgs> edit;
        public Reminder reminder { get; private set; }

        public ReminderDisplay(Reminder reminder) {
            InitializeComponent();
            this.reminder = reminder;

            lblReminderTime.Text = reminder.timeRemainingPrettified();
            lblReminder.Text = reminder.description;
        }

        // needed so that we can use the designer for this class
        [Obsolete("For designer use only", true)]
        public ReminderDisplay() {
            InitializeComponent();
        }

        public void updateTime() {
            lblReminderTime.Text = reminder.timeRemainingPrettified();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var result = BoinMsg.show("Delete this reminder?", "BoinTime", true);
            if (result == DialogResult.OK) {
                Reminders.instance.list.Remove(reminder); // remove our reminder from the list
                this.Dispose(); // close the control
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            // trigger edit event
            edit(this, new ReminderEventArgs(reminder));
        }
    }
}
