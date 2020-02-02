using System;
using System.Collections.Generic;
using System.Linq;
using MindBoxLib.Interfaces;

namespace MindBoxLib._2dFigures.Implementation
{
    public class Figure: IFigure
    {
        private IList<XYDot> dots;

        public Figure(IEnumerable<XYDot> dots)
        {
            this.dots = dots.ToList();
        }
        public double GetArea()
        {
            double area = 0;

            for (int i = 0; i < dots.Count - 1; i++)
            {
                area += dots[i].X * dots[i + 1].Y - dots[i].Y * dots[i + 1].X;
            }

            area += dots[dots.Count - 1].X * dots[0].Y - dots[dots.Count - 1].Y * dots[0].X;

            return Math.Abs(area) / 2;
        }
    }
}