using System.Runtime.InteropServices;
using System.Windows;

namespace aadea.Extras;

public class TabControlEx : TabControl
{
    protected override void WndProc(ref Message m)
    {
        if (m.Msg == 0x1300 + 40)
        {
            RECT rc = (RECT)m.GetLParam(typeof(RECT));
            rc.Left -= 6;
            rc.Right += 6;
            rc.Top -= 6;
            rc.Bottom += 6;
            Marshal.StructureToPtr(rc, m.LParam, true);
        }
        base.WndProc(ref m);
    }
}
internal struct RECT { public int Left, Top, Right, Bottom; }