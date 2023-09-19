using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex3
Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastaura
 (google: how to get the last digit of a number)
            */
            int numar = int.Parse(Console.ReadLine());
            int ultimaCifra = 0;

            if (numar/2 = 0)
            {

                ultimaCifra = numar % 10;
                Console.WriteLine("Ultima cifra este =" + ultimaCifra);
            }
            else
            {
                Console.WriteLine("Numarul nu este intreg" + numar);
            }
        }
    }
}
