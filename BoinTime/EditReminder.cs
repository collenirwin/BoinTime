using BoinMsgNS;
using System;
using System.Windows.Forms;

namespace BoinTime {
    public partial class EditReminder : UserControl {

        public event EventHandler<ReminderEventArgs> editDone;

        public Reminder reminder { get; private set; }

        public EditReminder(Reminder reminder = null) {
            InitializeComponent();
            dtpStarting.MinDate = DateTime.Now;

            this.reminder = reminder;

            if (reminder != null) { // set all controls to reflect the value of the reminder
                lblTitle.Text = "Edit Reminder";
                txtDescription.Text = reminder.description;
                cboType.SelectedIndex = (int)reminder.type;
                txtEvery.Value = reminder.customValue;
                cboEvery.SelectedIndex = (int)reminder.customType;
                chkNotification.Checked = reminder.showNotification;
                txtNotification.Value = reminder.notificationMins;
                dtpStarting.Value = reminder.date;

            } else { // no reminder passed; we're creating one
                lblTitle.Text = "New Reminder";
                cboType.SelectedIndex = 0;
                dtpStarting.Value = DateTime.Now;
                txtEvery.Value = 45;
                cboEvery.SelectedIndex = 0;
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e) {
            // if 'every' is selected, show the textbox and combobox corresponding with it
            // ex: [every v] [30] [minutes v]
            bool every = cboType.SelectedItem.ToString() == "every";
            txtEvery.Visible = every;
            cboEvery.Visible = every;
        }

        private void chkNotification_CheckedChanged(object sender, EventArgs e) {
            txtNotification.Enabled = chkNotification.Checked;
        }

        private void btnDone_Click(object sender, EventArgs e) {
            if (dtpStarting.Value > DateTime.Now) {

                if (txtDescription.Text.Trim() != "") {
                    // set all properties of this.reminder to reflect the user's input
                    if (reminder == null) {
                        reminder = new Reminder(
                            txtDescription.Text,
                            (ReminderType)cboType.SelectedIndex,
                            dtpStarting.Value,
                            (CustomType)cboEvery.SelectedIndex,
                            (int)txtEvery.Value,
                            chkNotification.Checked,
                            (int)txtNotification.Value
                        );

                        // trigger editDone event (new)
                        editDone(this, new ReminderEventArgs(reminder, true));

                    } else {
                        reminder.description = txtDescription.Text;
                        reminder.type = (ReminderType)cboType.SelectedIndex;
                        reminder.date = dtpStarting.Value;
                        reminder.customType = (CustomType)cboEvery.SelectedIndex;
                        reminder.customValue = (int)txtEvery.Value;
                        reminder.showNotification = chkNotification.Checked;
                        reminder.notificationMins = (int)txtNotification.Value;
                        reminder.notificationShown = false;

                        // trigger editDone event (not new)
                        editDone(this, new ReminderEventArgs(reminder, false));
                    }

                    // close the control
                    this.Dispose();

                } else { // no description entered
                    BoinMsg.show("Please provide a description for this reminder", "BoinTime");
                    txtDescription.Focus();
                }

            } else { // selected date has passed
                BoinMsg.show("Your selected date for this reminder must be in the future", "BoinTime");
                dtpStarting.Focus();
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
