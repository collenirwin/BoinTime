using BoinBoxNS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoinMsgNS {

    public partial class BoinMsg : Form {
        int cancelX = 214;

        public static Color foreColor = Color.FromArgb(255, 250, 250, 250);
        public static Color backColor = Color.FromArgb(255, 74, 74, 74);

        public static Color buttonForeColor = Color.FromArgb(255, 250, 250, 250);
        public static Color buttonBackColor = Color.FromArgb(255, 45, 45, 45);

        /// <summary>
        /// Shows a message box with the specified message
        /// </summary>
        /// <param name="message">Message to display</param>
        /// <param name="title">Title to be displayed in the title bar</param>
        /// <param name="canCancel">Whether to show a Cancel button</param>
        /// <returns>OK or Cancel (only possible if canCancel is true)</returns>
        public static DialogResult show(string message, string title = "", bool canCancel = false) {
            DialogResult result;

            using (var form = new BoinMsg(message, title, canCancel)) {
                form.lblMessage.ForeColor = foreColor;
                form.BackColor = backColor;

                foreach (Control c in form.Controls) {
                    if (c.GetType() == typeof(BoinBox)) {
                        var button = c as BoinBox;

                        button.ForeColor = buttonForeColor;
                        button.BackColor = buttonBackColor;
                    }
                }

                result = form.ShowDialog();
            }

            return result;
        }

        public BoinMsg(string message, string title, bool cancel) {
            InitializeComponent();

            if (!cancel) {
                btnOK.Left = cancelX;
            } else {
                btnCancel.Show();
            }

            lblMessage.Text = message;
            Text = title;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (DialogResult == DialogResult.None) {
                if (btnCancel.Visible) {
                    DialogResult = DialogResult.Cancel;
                } else {
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
