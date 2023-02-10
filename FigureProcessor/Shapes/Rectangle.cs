using FigureProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProcessor.Shapes
{
    public class Rectangle : IShape
    {
        public double Height { get; private set; }

        public double Width { get; private set; }

        public bool IsValid { get; private set; } = false;

        public Rectangle(double height, double width)
        {
            if (height > 0 && width > 0)
            {
                IsValid = true;
            }

            Height = height;
            Width = width;
        }

        public double GetArea()
        {
            if (!IsValid)
            {
                return 0;
            }

            return Height * Width;
        }
    }
}
