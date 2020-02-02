using System;
using MindBoxLib.Interfaces;

namespace MindBoxLib._2dFigures.Implementation
{
    public class Triangle : IFigure, IValid
    {
        private readonly double SideA;
        private readonly double SideB;
        private readonly double SideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            if (IsValid())
            {
                var halfP = GetPerimeter()/2;
                return Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));
            }

            return -1;
        }

        private double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public bool IsValid()
        {
            var validateSideC = SideA + SideB > SideC;
            var validateSideB = SideC + SideA > SideB;
            var validateSideA = SideC + SideB > SideA;

            return validateSideA && validateSideB && validateSideC;
        }

        public bool IsRightTriangle()
        {
            var epsilon = 0.000001;
            var validateSideC = Math.Abs(SideC - Math.Sqrt(SideA * SideA + SideB * SideB)) < epsilon;
            var validateSideB = Math.Abs(SideB - Math.Sqrt(SideA * SideA + SideC * SideC)) < epsilon;
            var validateSideA = Math.Abs(SideA - Math.Sqrt(SideB * SideB + SideC * SideC)) < epsilon;

            return validateSideA || validateSideB || validateSideC;
        }
    }
}