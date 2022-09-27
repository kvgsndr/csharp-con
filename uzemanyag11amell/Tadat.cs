using System;
using System.Collections.Generic;
using System.Text;

namespace uzemanyag11amell
{
    class Tadat
    {
        public DateTime datum;
        public int benzin;
        public int gazolaj;

        public Tadat(string sor)
        {
            string[] elemek = sor.Split(';');
            benzin = int.Parse(elemek[1]);
            gazolaj= int.Parse(elemek[2]);
            string[] dat = elemek[0].Split('.');
            datum = new DateTime( int.Parse(dat[0]), int.Parse(dat[1]), int.Parse(dat[2]));
        }

        public int kulombseg()
        {
            return Math.Abs(benzin - gazolaj);
        }

        public bool szokonap()
        {
            return datum.Year % 4 == 0 && datum.Month == 2 && datum.Day == 24;
        }

        public int elteltNapok(Tadat nap2)
        {
            //Változó tömb napokSzama = { 31,28,31,30,31,30,31,31,30,31,30,31}: Egész
            int[] napokSzama = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (this.datum.Year % 4 == 0) napokSzama[1] = 29;

            if (this.datum.Month == nap2.datum.Month) //Térj vissza aktuálisVáltozásNapja -előzőVáltozásNapja
                return (nap2.datum.Day - this.datum.Day);
            else  //Térj vissza napokSzama[előzőVáltozásHónapja -1] -előzőVáltozásNapja + aktuálisVáltozásNapja
                return  napokSzama[this.datum.Month-1] - this.datum.Day + nap2.datum.Day ;
        }


    }
}
