using BoinMsgNS;
using System;
using System.Windows.Forms;

namespace BoinTime {
    public partial class EditReminder : UserControl {

        public event EventHandler editDone;

        public Reminder reminder { get; private set; }
        public bool isNew { get; private set; }

        public EditReminder(Reminder reminder = null) {
            InitializeComponent();
            this.reminder = reminder;

            if (reminder != null) {
                lblTitle.Text = "Edit Reminder";
                txtDescription.Text = reminder.description;
                cboEvery.SelectedIndex = (int)reminder.type;
                txtEvery.Value = reminder.customValue;
                cboEvery.SelectedIndex = (int)reminder.customType;
                isNew = false;

            } else { // no reminder passed; we're creating one
                lblTitle.Text = "New Reminder";
                cboType.SelectedIndex = 0;
                dtpStarting.Value = DateTime.Now;
                txtEvery.Value = 45;
                cboEvery.SelectedIndex = 0;
                isNew = true;
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
            if (txtDescription.Text.Trim() != "") {
                // set all properties of this.reminder to reflect the user input
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

                } else {
                    reminder.description = txtDescription.Text;
                    reminder.type = (ReminderType)cboType.SelectedIndex;
                    reminder.date = dtpStarting.Value;
                    reminder.customType = (CustomType)cboEvery.SelectedIndex;
                    reminder.customValue = (int)txtEvery.Value;
                    reminder.showNotification = chkNotification.Checked;
                    reminder.notificationMins = (int)txtNotification.Value;
                }

                // trigger editDone event
                editDone(this, new EventArgs());

            } else {
                BoinMsg.show("Please provide a description for this reminder", "BoinTime");
                txtDescription.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
