using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dědičnost.C1
{
    internal class Politik : Clovek
    {
        public Politik(string jmeno) : base(jmeno)
        {

        }
        public override bool Lez()
        {
            return false;
        }

    }
}
