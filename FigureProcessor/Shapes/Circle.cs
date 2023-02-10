using FigureProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProcessor.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; private set; }

        public bool IsValid { get; set; } = false;

        public Circle(double radius) 
        {
            if (radius > 0)
            {
                IsValid = true;
            }

            Radius = radius;
        }

        public double GetArea()
        {
            if (!IsValid)
            {
                return 0;
            }

            return Math.PI * Math.Pow(Radius,2);
        }
    }
}
