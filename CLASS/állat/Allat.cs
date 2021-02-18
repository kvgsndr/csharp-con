using System;
using System.Collections.Generic;
using System.Text;

namespace állat
{
    class Allat
    {
        static int n = 0;
        string nev = "Állat";
        int ehseg;
        int szomj;

        public Allat()
        {
            Ehseg = 40;
            Szomj = 40;
            n++;
            nev = "Állat" + n.ToString();
        }

        public Allat(string nev, int szomj, int ehseg)
        {
            this.szomj = szomj;
            this.Ehseg = ehseg;
            n++;
            this.nev = nev + n.ToString();
        }

        public int Szomj   // properties
        {
            get // get method
            {
                return szomj; 
            }   
            set// set method
            {  
                if(value>0)
                  szomj = value; 
            }  
        }

        public int Ehseg { get => ehseg; set => ehseg = value; }  //properities
       
        

        public void eszik()
        {
            Ehseg--;
        }
        public void iszik()
        {
            szomj--;
        }
        public void jatszik()
        {
            Ehseg++;
            szomj++;
        }

        public void kiir()
        {
            Console.WriteLine($"{nev} szomj={szomj}   Éhség={Ehseg} sorszám={n}");
        }

    }
}
