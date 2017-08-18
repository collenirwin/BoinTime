using System;

namespace BoinTime {
    public class ReminderEventArgs : EventArgs {
        public Reminder reminder { get; private set; }
        public bool isNew { get; private set; }

        public ReminderEventArgs(Reminder reminder, bool isNew = false) {
            this.reminder = reminder;
            this.isNew = isNew;
        }
    }
}
