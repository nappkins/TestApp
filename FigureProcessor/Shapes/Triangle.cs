using FigureProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FigureProcessor.Shapes
{
    public class Triangle : IShape
    {   
        public double SideA { get; private set; }

        public double SideB { get; private set; }

        public double SideC { get; private set; }

        public bool IsValid { get; private set; } = false;

        public Triangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0 
                && a + b > c && a + c > b && b + c > a)
            {
                IsValid = true;
            }

            SideA = a;
            SideB = b;
            SideC = c;
        }

        public double GetArea()
        {
            if (!IsValid)
            {
                return 0;
            }

            double p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRight()
        {
            if (!IsValid)
            {
                return false;
            }

            var sides = new List<double> { SideA, SideB, SideC };
            var poweredSides = sides.Select(s => Math.Pow(s, 2)).ToList();
            var largest  = poweredSides.Max();
            poweredSides.Remove(largest);

            return largest == poweredSides.Sum();
        }
    }
}
