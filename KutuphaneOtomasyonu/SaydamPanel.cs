using System.Windows.Forms;
using System.Drawing;

public class SaydamPanel : Panel
{
    public SaydamPanel()
    {
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.BackColor = Color.Transparent;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        // Arka planı çizme, böylece altındaki arka plan görseli gözükür
    }
}
