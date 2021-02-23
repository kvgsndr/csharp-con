using System;
using System.IO;

namespace kivétel_file
{
    class Program
    {
        static void Main(string[] args)
        {   try
            {
                StreamReader fbe = new StreamReader("nemlétezőfájl.txt");
                var sor = fbe.ReadLine();
                while (sor != null)
                {
                    Console.WriteLine(sor);
                    sor = fbe.ReadLine();
                }


            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Nem létezik a file!!");
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Vége a programnak! Kilépéshez nyomj egy billentyűt!");
                Console.ReadKey();
            }
            
        }
    }
}
