using System.Drawing.Text;
using System.Windows.Forms;

namespace BoinTime {
    public partial class LabelAA : Label {

        protected override void OnPaint(PaintEventArgs e) {
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            base.OnPaint(e);
        }
    }
}
