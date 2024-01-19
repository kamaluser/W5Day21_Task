﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5Day21_Task
{
    internal class Rectangle:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
