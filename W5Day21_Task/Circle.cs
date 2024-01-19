using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5Day21_Task
{
    internal class Circle:Shape
    {
        public int Radius {  get; set; }
        public double PI => 3.14;
        public override double CalculateArea()
        {
            return PI * (Radius * Radius);
        }
    }
}
