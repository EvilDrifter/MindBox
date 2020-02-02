using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxLib._2dFigures;
using MindBoxLib._2dFigures.Implementation;

namespace MindBox.Test
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void GetArea_ValidTriangle_CorrectArea()
        {
            //square S=>a^2
            var dots = new List<XYDot>
            {
                new XYDot(0, 0),
                new XYDot(0, 2),
                new XYDot(2, 2),
                new XYDot(2, 0)
            };

            var figure = new Figure(dots);

            var area = figure.GetArea();

            Assert.AreEqual(4, area);
        }
    }
}