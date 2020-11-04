using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzemanyag1
{
    class Valtozas
    {
        public int ev;
        public int honap;
        public int nap;
        public int benzinar;
        public int gazolajar;

        public int Kulonbseg
        {
            get //get átadja az értéket
            {
                return Math.Abs(benzinar - gazolajar);
            }
        }
        public bool szokonape
        {
            get 
            {
                return (ev % 4 == 0 && honap == 2 && nap == 24);
            }
        }
        public Valtozas(string sor) //konstruktor
        {
            string[] darabok = sor.Split(';');
            ev = Convert.ToInt32(darabok[0].Split('.')[0]);
            honap = Convert.ToInt32(darabok[0].Split('.')[1]);
            nap = Convert.ToInt32(darabok[0].Split('.')[2]);
            benzinar = Convert.ToInt32(darabok[1]);
            gazolajar = Convert.ToInt32(darabok[2]);
        } 
    }
}
