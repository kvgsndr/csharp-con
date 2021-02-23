using System;
using System.Collections.Generic;
using System.Text;

namespace Szamitogép_11d
{
    class Szamitogep
    {
        double memoria;//MB
        bool bekapcsolva;//igaz, hamis

        public Szamitogep(double mem, bool kapcs)
        {
            memoria = mem;
            bekapcsolva = kapcs;
        }
        public Szamitogep()
        {
            memoria = 1024;
            bekapcsolva = false;
        }

        public void kapcsol()
        {
            bekapcsolva = !bekapcsolva;

            //if (bekapcsolva) bekapcsolva = false;
            //else bekapcsolva = true;
        }

        public bool progMasol(double meret)
        {
            if (bekapcsolva && memoria >= meret)
            {
                memoria -= meret;
                return true;
            }
            else
                return false;
        }
        public void toString()
        {
            Console.WriteLine($"Mem: {memoria}\nBekapcsolva: {bekapcsolva}");
        }
    }
}
