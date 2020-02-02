using System;
using MindBoxLib.Interfaces;

namespace MindBoxLib._2dFigures.Implementation
{
    public class Circle : IFigure, IValid
    {
        private readonly double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double GetArea()
        {
            if (IsValid())
            {
                return Math.PI * Radius * Radius;
            }

            return -1;
        }

        public bool IsValid()
        {
            return Radius > 0;
        }
    }
}