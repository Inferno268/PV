using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dědičnost.C2
{
    internal class Postava
    {
        String Jmeno;
        int Level;
        int Sila;
        int Inteligence;
        int Obratnost;
        int Odolnost;
        int Zkusenosti;

        int Points;
        int Vyber = Convert.ToInt32(Console.ReadLine());

        public void Body()
        {
            while(Points > 0) { 
                switch (Vyber)
            {
                case 1:
                    Sila++;
                    Console.WriteLine("Pridali jste bod do sily, vase sila je ted: " + Sila);
                    break;
               case 2:
                    Inteligence++;
                    Console.WriteLine("Pridali jste bod do inteligence, vase inteligence je ted: " + Inteligence);
                    break;
                case 3:
                    Obratnost++;
                    Console.WriteLine("Pridali jste bod do obratnosti, vase obratnosti je ted: " + Obratnost);
                    break;
                case 4:
                    Odolnost++;
                    Console.WriteLine("Pridali jste bod do odolnosti, vase odolnost je ted: " + Odolnost);
                    break;
            }}
            
            
            
        }
    }
}
