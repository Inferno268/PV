using System;
namespace Second_Project
{
    public class Trojuhelnik
    {
        int a;
        int b;
        int c;

        int uhelA;
        int uhelB;
        int uhelC;

        bool valid = true;
        bool valid2 = true;

        public Trojuhelnik(int a, int b, int c, int alfa, int beta, int gama)
        {
            this.a = a;
            this.b = b;
            this.c = c;

           
            this.uhelA = alfa;
            this.uhelB = beta;
            this.uhelC = gama;

            Create();
            Run();
            Run2();
        }

        public void Create()
        {

            if (a + b >= c && a + c >= b && b + c >= a && uhelA + uhelB + uhelC == 180)
            {
                Console.WriteLine("Trojúhelník splňuje trojúhelníkovou nerovnost");
            }
        
            else
            {
                Console.WriteLine("Trojúhelník nesplňuje trojúhelníkovou nerovnost");
                valid = false;
            }

        }
        public void Checker()
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Rovnostranný trojúhelník");
                valid2 = false;
            }
            else if (a == b || b == c || c == a) { 
                Console.WriteLine("Rovnoramenný trojúhelník");
            valid2 = false;
        }
    }

        public void Pravouhly()
        {
            if(uhelA == 90 || uhelB == 90 || uhelC == 90)
            {
                Console.WriteLine("Pravoúhlý trojúhelník");
            }
        }
        public void Run()
        {
            if(valid)
            {
                Checker();
                
            }
        }
        public void Run2()
        {
            if (valid2)
            {
                Pravouhly();
            }
        }
    }
        
}




