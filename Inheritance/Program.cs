using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Inheritance
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Fraction f = new Fraction(4, 5);
            Console.WriteLine(f.ToString());

          

            MixedFraction mixedFraction = new MixedFraction(2, 3, 4);

            Console.WriteLine(mixedFraction.ToString());

            Console.ReadKey();

        }
    }
}
