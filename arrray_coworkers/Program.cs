using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrray_coworkers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Odett: Tömb létrehozása
            int[] tomb = { 1, 2, 3, 4, 5 };
            //Patrik: Tömb adatainak összeadása
            int eredmeny = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                eredmeny += tomb[i];
            }
            //Máté: Eredmények kiírása
        }
    }
}
