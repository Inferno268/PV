using System;

namespace Second_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Potravina p = new Potravina("Banan",20 , 1430);
            Console.WriteLine("Vase kalorie prevedeny na kilokalorie: " + p.Prevod());
            Console.WriteLine(p.Procenta());

            Interval i = new Interval();
            Console.WriteLine(i.Checker(3));
            //Console.WriteLine(i.Inrervals(2));

            Primka pr = new Primka();
            pr.Draw();
            Console.WriteLine();
            Console.WriteLine(pr.Length());
        }
    }
}

