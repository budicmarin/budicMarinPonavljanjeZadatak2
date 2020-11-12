using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace budicMarinPonavljanjeZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši niz znakova");
            string nizZnakova=Console.ReadLine();
            nizZnakova=Regex.Replace(nizZnakova," ","_");
            Console.WriteLine(nizZnakova);
            Console.ReadKey();
        }
    }
}
