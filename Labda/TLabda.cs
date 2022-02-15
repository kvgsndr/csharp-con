using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace Labda
{
    class TLabda
    {
        int x;
        int y;
        int dx;
        int dy;
        ConsoleColor szin = ConsoleColor.DarkCyan;
        int sugar;

        public TLabda(int x,int y, int sugar )
        {
            this.x = x;
            this.y = y;
            this.sugar = sugar;

        }
        public void mozgat()
        {
            hide();
            x += dx;
            y += dy;
            show();
        }
        public void irany(int dx, int dy)
        {
            this.dx = dx;
            this.dy = dy;
        }
        public void show()
        {
            IntPtr hwnd = Process.GetCurrentProcess().MainWindowHandle;
            Graphics newGraphics = Graphics.FromHwnd(hwnd);
            newGraphics.DrawEllipse(new Pen(Color.DarkCyan, 3), x, y, 100, 100); ;
        }
        public void hide()
        {
            IntPtr hwnd = Process.GetCurrentProcess().MainWindowHandle;
            Graphics newGraphics = Graphics.FromHwnd(hwnd);
            newGraphics.DrawEllipse(new Pen(Color.Black, 3), x, y, 100, 100); ;
        }

    }
}
