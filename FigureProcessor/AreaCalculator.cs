using FigureProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureProcessor
{
    public static class AreaCalculator
    {
        public static double GetFigureArea(IShape figure)
        {
            return figure.GetArea();
        }
        
    }
}
