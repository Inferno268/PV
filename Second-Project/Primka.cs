using System;
namespace Second_Project
{
    public class Primka
    {

        int start = 6;
        int end = 14;


        //int[] Numbers = {};
        
        public void StartDraw()
        {
            for (int i = 0; i < start; i++)
            {
                Console.Write(" ");
            }
        }
        public void EndDraw()
        {
            for(int i =0; i< (end - start); i++)
            {
                Console.Write("-");
            }
        }
       public String Length()
        {
            return "Vaše přímka je dlouhá: " + (end -start) + " centimetrů";

        }

    }
}

