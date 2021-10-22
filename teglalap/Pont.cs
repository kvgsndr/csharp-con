using System;
using System.Collections.Generic;
using System.Text;

namespace teglalap
{
    class Pont
    {
        double x;
        double y;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }


        public Pont(double x = 0.0, double y = 0.0)
        {
            X=x;
            Y=y;
        }

    

        
    }
}
