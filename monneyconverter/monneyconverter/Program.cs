using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monneyconverter
{
    class Program
    {
        static void Main(string[] args)
        {

            /////////biagio2218mychange

            Console.Clear();

            //presentazione
            Console.WriteLine("Benvenuto in Number Conversion");
            Console.WriteLine("-----------------------");


            Console.WriteLine("Converti un numero da arabo a romano");
            Console.WriteLine("-----------------------");

            //input
            Console.WriteLine("Inserisci un numero Arabo");
            string str_input = Console.ReadLine();

            string str_roman = "";

            //str_roman = ConvertToRoman(10);
            str_roman = NumberCOnverter.ConvertToRoman(10);


            //print output
            Console.WriteLine("-----------------------");
            //Console.WriteLine("Formato Romano");
            Console.WriteLine("Formato Romano {0}", str_roman);


            //close window
            Console.WriteLine("Clicca un tasto per chiudere");
            Console.ReadKey();

        }

    }

    public static class NumberCOnverter
    {

        public static string ConvertToRoman(int num)
        {
            return "MCLV";
        }


    }
}
