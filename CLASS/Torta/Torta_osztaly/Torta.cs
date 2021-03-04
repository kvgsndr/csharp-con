using System;
using System.Collections.Generic;
using System.Text;

namespace Torta_osztaly
{
    class Torta
    {
        int emeletek;
        bool krem;

        public Torta()
        {
            emeletek = 1;
            krem = false;
        }
        public Torta(int emelet, bool krem)
        {
            emeletek = emelet;
            this.krem = krem;
        
        }

        public void ujEmelet()
        {
            emeletek++;
        }
        public bool kremmelMegken()
        {
            if (!krem)
            {
                krem = true;
                return true;
            }
            return false;
        }

        public int mennnyiKaloria()
        {
            if (krem) 
                return emeletek * 1000*2;
            else
                return emeletek * 1000;
        }

        public void toString()
        {
            Console.WriteLine($"Emeletek: {emeletek} Krém: {krem} Kalória: {mennnyiKaloria()}");
        }

    }
}
