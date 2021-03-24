using System;
using System.Collections.Generic;
using System.Text;

namespace totoOOP
{
    class Adatok
    {
        int ev;
        int het;
        int fordulo;
        int t13p1;
        int ny13p1;
        string eredmeny;
        public Adatok(int ev, int het, int fordulo, int t13p1, int ny13p1, string eredmeny )
        {
            this.ev= ev;
            this.het=het;
            this.fordulo=fordulo;
            this.T13p1=t13p1;
            this.ny13p1=ny13p1;
            this.eredmeny=eredmeny;

        }

        public int T13p1 { get => t13p1; set => t13p1 = value; }
        public long kifizetve(){ return (long)t13p1 * ny13p1; }
    }
}
