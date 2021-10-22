using System;
using System.Collections.Generic;
using System.Text;

namespace teglalap
{
    class Teglalap
    {
        Pont[] csucsok= new Pont[4];

        public Teglalap(double magassag, double szelesseg, Pont balFelso)
        {
            csucsok[0] = balFelso;
            csucsok[1] = new Pont(balFelso.X + szelesseg, balFelso.Y);
            csucsok[2] = new Pont(balFelso.X, balFelso.Y - magassag);
            csucsok[3] = new Pont(balFelso.X + szelesseg, balFelso.Y - magassag);
        }
        public double getKerulet()
        {
            return 2 * (csucsok[1].X - csucsok[0].X) + 2 * (csucsok[0].Y - csucsok[2].Y);
        }
        public double getTerulet()
        {
            return  (csucsok[1].X - csucsok[0].X) *  (csucsok[0].Y - csucsok[2].Y);
        }
        public string toString()
        {
            return String.Format("Téglalap kerülete: {0}, területe: {1}", getKerulet(), getTerulet());
        }


    }
}
