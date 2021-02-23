using System;
using System.Collections.Generic;
using System.Text;

namespace Szamitogep_11a
{
    class Szamitogep
    {
        double memoria;
        bool bekapcsolva;

        public Szamitogep(double mem, bool stat)
        {
            memoria = mem;
            bekapcsolva = stat;
        }

        public Szamitogep()
        {
            memoria = 1024;
            bekapcsolva = false;
        }
        public void kapcsol()
        {
            bekapcsolva = !bekapcsolva;
        }

        public bool programMasol(int meret)
        {
            if (meret <= memoria)
            {
                memoria -= meret;
                return true;
            }
            else
                return false;
        }
        public void toString()
        {
            Console.WriteLine($"Memória: {memoria} Bekapcsolva: {bekapcsolva}");
        }

    }
}
