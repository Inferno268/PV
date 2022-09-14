using System;
namespace Second_Project
{
    public class Primka
    {

        int start = 1;
        int end = 14;


        //int[] Numbers = {};
        

        public void Draw()
        {
            for(int i =0; i< end; i++)
            {
                Console.Write("-");
            }
        }
       public String Length()
        {
            return "Vaše přímka je dlouhá: " + end + " centimetrů";

        }

    }
}

