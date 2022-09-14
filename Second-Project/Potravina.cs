using System;
namespace Second_Project
{
    public class Potravina
    {
        
            int Hmotnost;
            double Cal;
            String Nazev;
            int Full = 1470;

            public Potravina(String Nazev, int Hmotnost, Double Cal) {
            this.Cal1 = Cal;
            this.Nazev1 = Nazev;
            this.Hmotnost1 = Hmotnost;

            }

        public int Hmotnost1 { get => Hmotnost; set => Hmotnost = value; }
        public double Cal1 { get => Cal; set => Cal = value; }
        public string Nazev1 { get => Nazev; set => Nazev = value; }


        public Double Prevod()
        {
            double x = Cal *1000;
            return x;
        }
        public String Procenta()
        {
            double x = Cal / Full * 100;
            return "Banan tvori: " + x + " procent vaseho prijmu kalorii";
                }
    }
    }


