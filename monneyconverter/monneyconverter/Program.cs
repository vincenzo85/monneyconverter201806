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

            Console.Clear();

            //presentazione
            Console.WriteLine("Benvenuto in Number Conversion");
            Console.WriteLine("-----------------------");


            Console.WriteLine("Converti un numero da arabo a romano");
            Console.WriteLine("-----------------------");

            //input
            Console.WriteLine("Inserisci un numero Arabo");
            string str_input = Console.ReadLine();

            ConvertToRoman convertToRoman = new ConvertToRoman();

            int InputNum = Convert.ToInt32(str_input);

            string str_roman = convertToRoman.Run(InputNum);

            //print output
            Console.WriteLine(str_roman);

            //close window
            Console.WriteLine("Clicca un tasto per chiudere");
            Console.ReadKey();

        }
    }

    

}
