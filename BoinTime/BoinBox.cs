using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BoinBoxNS {

    [ToolboxItem(true)]
    public partial class BoinBox : Button {

        Timer t = new Timer();

        Color mouseOverForeColor = Color.FromArgb(255, 250, 250, 250);
        Color mouseDownForeColor = Color.FromArgb(255, 250, 250, 250);

        public Color storedForeColor = Color.FromArgb(255, 250, 250, 250);

        bool antiAliased  = false;
        bool fakeDisabled = false;

        public int BorderSize {
            get { return  FlatAppearance.BorderSize; }
            set { FlatAppearance.BorderSize = value; }
        }

        public Color BorderColor {
            get { return  FlatAppearance.BorderColor; }
            set { FlatAppearance.BorderColor = value; }
        }

        public Color MouseOverForeColor {
            get { return  mouseOverForeColor; }
            set { mouseOverForeColor = value; }
        }

        public Color MouseOverBackColor {
            get { return  FlatAppearance.MouseOverBackColor; }
            set { FlatAppearance.MouseOverBackColor = value; }
        }

        public Color MouseDownForeColor {
            get { return  mouseDownForeColor; }
            set { mouseDownForeColor = value; }
        }

        public Color MouseDownBackColor {
            get { return  FlatAppearance.MouseDownBackColor; }
            set { FlatAppearance.MouseDownBackColor = value; }
        }

        public bool AntiAliased {
            get { return  antiAliased; }
            set { antiAliased = value; }
        }

        public bool FakeDisabled {
            get { return  fakeDisabled; }
            set { fakeDisabled = value; }
        }

        public BoinBox() : base() {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            BackColor = Color.FromArgb(255, 45, 45, 45);
            ForeColor = Color.FromArgb(255, 250, 250, 250);

            mouseOverForeColor = ForeColor;
            mouseDownForeColor = ForeColor;
            storedForeColor    = ForeColor;

            t.Tick += new EventHandler(t_Tick);
            t.Interval = 100;

            Font = new Font("Calibri", 9, FontStyle.Regular);
        }

        protected override void OnPaint(PaintEventArgs e) {
            if (AntiAliased) {
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            }

            base.OnPaint(e);
        }

        protected override void OnMouseEnter(EventArgs e) {
            if (!FakeDisabled) {
                storedForeColor = ForeColor;

                base.OnMouseEnter(e);
                ForeColor = mouseOverForeColor;
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent) {
            if (!FakeDisabled) {
                base.OnMouseDown(mevent);
                ForeColor = mouseDownForeColor;
            }
        }

        protected override void OnMouseLeave(EventArgs e) {
            if (!FakeDisabled) {
                base.OnMouseLeave(e);
                ForeColor = storedForeColor;
                t.Enabled  = true;
            }
        }

        private void t_Tick(object sender, EventArgs e) {
            ForeColor = storedForeColor;
            t.Enabled = false;
        }
    }
}
