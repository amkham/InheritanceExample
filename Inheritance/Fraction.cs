using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Fraction
    {
        /// <summary>
        /// Числитель
        /// </summary>
        private int _num;
        /// <summary>
        /// Знаменатель
        /// </summary>
        private int _dec;


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="num"></param>
        /// <param name="dec"></param>
        public Fraction(int num, int dec)
        {
            _num = num;
            _dec = dec;
        }

        public Fraction()
        { }

        public int Num { get => _num; set => _num = value; }
        public int Dec { get => _dec; set => _dec = value; }

        public override string ToString()
        {
            return _num + "/" + _dec;
        }
    }
}
