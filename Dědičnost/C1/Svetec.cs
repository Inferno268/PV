using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dědičnost.C1
{
    internal class Svetec : Clovek
    {
        public Svetec(string jmeno) : base(jmeno)
        {
        }

        public override bool Lez()
        {
            return true;
        }
    }
}
