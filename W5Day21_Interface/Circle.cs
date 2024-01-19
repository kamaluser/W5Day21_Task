using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5Day21_Interface
{
    internal class Circle:IShape
    {
        public double Radius { get; set; }
        public double PI => 3.14;
        public double CalculateArea()
        {
            return PI * (Radius * Radius);
        }

    }
}
