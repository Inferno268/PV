using System;
namespace Second_Project
{
    public class Trojuhelnik
    {
        int a;
        int b;
        int c;

        public Trojuhelnik(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public String Create()
        {
            if( a + b >= c && a + c >= b && b + c >= a)
            {
                return "Trojúhelník splňuje trojúhelníkovou nerovnost";
            }
            return "Trojúhelník nesplňuje trojúhelníkovou nerovnost";
        }

    }
}

