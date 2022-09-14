using System;
using System.Collections.Generic;

namespace Second_Project
{
    public class Interval
    {
            int start = 1;
            int end = 10;
            int start2 = 5;
            int end2 = 20;


        var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };


        public int Start { get => start; set => start = value; }
        public int End { get => end; set => end = value; }
        public int Start2 { get => start2; set => start2 = value; }
        public int End2 { get => end2; set => end2 = value; }

        public String Checker(int x)
        {
            if(x <= start || x >= end)
            {
                return "Cislo neni v intervalu";
            }
            else
            {
                return "Cislo je v intervalu";
            }
        }
     /*   public String Inrervals(int x)
        {
            if(x <= end2 && x >= start){
                return "Cislo je v intervalu";
            }
            else
            {
                return null;
            }
        }*/

foreach (int element in Num)
{

}


}
}

