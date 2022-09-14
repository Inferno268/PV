using System;
using System.Collections.Generic;
using System.Linq;

namespace Second_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Potravina
            Potravina p = new Potravina("Banan",20 , 1430);
            Console.WriteLine("Vase kalorie prevedeny na kilokalorie: " + p.Prevod());
            Console.WriteLine(p.Procenta());

            //Interval
            Interval i = new Interval();
            Console.WriteLine(i.Checker(3));
            //Třetí úkol se mi ne podařilo vymyslet
            
            //Přímka
            Primka pr = new Primka();
            pr.StartDraw();
            pr.EndDraw();
            Console.WriteLine();
            Console.WriteLine(pr.Length());


            //Trohúhelník
            Trojuhelnik tr = new Trojuhelnik(3,4,1,40,50,90);

           
        }
    }
}

