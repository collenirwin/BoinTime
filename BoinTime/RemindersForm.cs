using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoinMsgNS;

namespace BoinTime {
    public partial class RemindersForm : Form {

        EditReminder editReminder;

        public RemindersForm() {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e) {
            if (editReminder != null) {
                editReminder.Dispose();
            }

            editReminder = new EditReminder();
            panel.Controls.Add(editReminder);
            editReminder.Dock = DockStyle.Top;
            editReminder.BringToFront();

            editReminder.editDone += new EventHandler(editReminder_editDone);
        }

        private void editReminder_editDone(object sender, EventArgs e) {

        }
    }
}
