using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace korlev
{
    class Program
    {
        static void Main(string[] args)
        {
            string []mnev=new string[1000];
            string[] amez = new string[1000];
            int mdb,p,i;
            string s,st;
            char c;
            StreamReader af = File.OpenText("adat.txt");
            StreamWriter w = new StreamWriter("level.txt");
            s = af.ReadLine();
            p = mdb = 0;
            st = "";
            while (p < s.Length)
            {
                if (s[p]=='\t')
                {
                    mnev[mdb++] = st;
                    p++;
                    st = "";
                }
                else
                {
                    st += s[p++];
                }
            }
            mnev[mdb++] = st;
            while (!af.EndOfStream)
            {
                s = af.ReadLine();
                i = p = 0;
                st = "";
                while (p < s.Length)
                {
                    if (s[p] == '\t')
                    {
                        amez[i++] = st;
                        p++;
                        st = "";
                    }
                    else
                    {
                        st += s[p++];
                    }
                }
                amez[i] = st;
                StreamReader tf = File.OpenText("torzs.txt");
                while (!tf.EndOfStream)
                {
                    c = (char)tf.Read();
                    if (c != '<')
                    {
                        w.Write(c);
                        Console.Write(c);
                    }
                    else
                    {
                        c = (char)tf.Read();
                        st = "";
                        while (c != '>')
                        {
                            st += c;
                            c = (char)tf.Read();
                        }
                        for (i = 0; i < mdb; i++)
                            if (st == mnev[i])
                            {
                                w.Write(amez[i]);
                                Console.Write(amez[i]);
                            }
                    }
                }
                tf.Close();
            }
            af.Close();
            w.Close();
            Console.WriteLine("KÉSZ!");
            Console.ReadKey();
        }
    }
}
