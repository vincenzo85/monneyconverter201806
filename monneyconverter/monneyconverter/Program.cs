﻿using System;
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


//modifica2321

            Console.Clear();

            //presentazione
            Console.WriteLine("Benvenuto in Number Conversion");
            Console.WriteLine("-----------------------");


            Console.WriteLine("Converti un numero da arabo a romano");
            Console.WriteLine("-----------------------");

            //input
            Console.WriteLine("Inserisci un numero Arabo");
            string str_input = Console.ReadLine();

            // str_roman = WriteRoman(10);
            ConvertToRoman convertToRoman = new ConvertToRoman();

            convertToRoman.InputInt = Convert.ToInt32(str_input) ;


            string str_roman = convertToRoman.Run();


            //print output
            Console.WriteLine(str_roman);


            //close window
            Console.WriteLine("Clicca un tasto per chiudere");
            Console.ReadKey();

        }
    }

    

}
