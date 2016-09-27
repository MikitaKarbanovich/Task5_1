using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"Points is: {X} and {Y}";
        } 
        public override bool Equals(System.Object obj)
        {  
                       if (obj == null)
            {
                return false;
            }

            
            Point p = obj as Point;
            if ((System.Object)p == null)
            {
                return false;
            }

            return (X == p.X) && (Y == p.Y);
        }
    }
}
