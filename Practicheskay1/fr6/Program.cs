using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///double c = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            ///Console.WriteLine(Convert.ToInt32(Math.Abs(c)));
            double c;
            c = 3.14 * Math.Pow(d, 2);
            Console.WriteLine(Math.Abs(c));

        }
    }
}
