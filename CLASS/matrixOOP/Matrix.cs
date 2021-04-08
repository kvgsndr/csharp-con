using System;
using System.Collections.Generic;
using System.Text;

namespace matrixOOP
{
    class Matrix
    {
        int[,] mat;
        public Matrix(int sor, int oszl)
        { Random rnd = new Random();
            mat = new int[sor, oszl];
            for (int i = 0; i < sor; i++)
                for (int j = 0; j < oszl; j++)
                    mat[i, j] = rnd.Next(1, 6);

        }
        public  int egyesSzomszed()
        {
            int egyesek = 0;
            return egyesek;
        }
    }
}
