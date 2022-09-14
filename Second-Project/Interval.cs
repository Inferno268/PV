using System;
using System.Collections.Generic;
using System.Linq;

namespace Second_Project
{
    public class Interval
    {
            int start = 1;
            int end = 10;
            int start2 = 5;
            int end2 = 20;

        
        public List<int> Pen()
         {
            var Num = new List<int> {1,2,3,4};
            var Num2 = new List<int> {3,4};
            var FinalNum= new List<int> {};
            int[] arr = {1,2,3,4};
           
            foreach (int element in Num)
            {
              int lol = Array.Find(Num,element =>  element == Num2);
                FinalNum.Add(lol);  
            }
            return FinalNum;
        }


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
}
}

