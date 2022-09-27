using System;
using System.Data;

namespace Data_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new datatable
            using (DataTable dt = new DataTable("Test"))
            {
                //Add columns to datatable
                dt.Columns.Add("ID", typeof(int));
                dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };
                dt.Columns.Add("osztalyzat", typeof(int));
                dt.Columns.Add("targy", typeof(string));
                dt.Columns.Add("nev", typeof(string));
                dt.Columns.Add("datum", typeof(DateTime));
                //adatok betöltése
                dt.Rows.Add(1, 1, "Magyar", "David", DateTime.Now);
                dt.Rows.Add(2, 2, "Matek", "Szabolcs", DateTime.Now);
                dt.Rows.Add(4, 3, "Tesi", "Viktória", DateTime.Now);
                dt.Rows.Add(7, 4, "Történelem", "Dávid", DateTime.Now);
                dt.Rows.Add(8, 5, "Matek", "Melánia", DateTime.Now);
                // adatok olvasása 
                foreach (DataRow dr in dt.Rows)
                {
                    Console.WriteLine("ID = {4} Osztályzat = {0}, Tárgy = {1}, Név = {2}, Dátum = {3}", dr["osztalyzat"], dr["targy"], dr["nev"], dr["datum"], dr["ID"]);
                }
            }
            Console.ReadKey();
        }
    }
}
