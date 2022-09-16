using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dědičnost.C1
{
    internal class Clovek
    {
        private string jmeno;
        Random rd = new Random();

        public Clovek(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public string Jmeno { get => jmeno; set => jmeno = value; }

        public virtual bool Lez()
        {
            int x = rd.Next(0, 2);
            if (x == 0)
            {
                return false;
            }
            else
            {

                return true;
            }
        }


    }
}
