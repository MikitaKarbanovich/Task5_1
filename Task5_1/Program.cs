using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 2;
            point.Y = 3;
            Console.WriteLine(point.Equals(point));
        }
    }
}
