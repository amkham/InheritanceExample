using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class MixedFraction : Fraction
    {
        private int _part;

        public MixedFraction(int num, int dec) : base(num, dec)
        {
         
        }
        public MixedFraction() : base()
        {

        }

        public MixedFraction(int part, int num, int dec): base(num, dec)
        {
            _part = part;
        }

        public int Part { get => _part; set => _part = value; }
    }
}
