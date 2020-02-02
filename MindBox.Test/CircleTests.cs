using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxLib._2dFigures.Implementation;

namespace MindBox.Test
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void IsValid_NegativeRadius_False()
        {
            var circle = new Circle(-1);

            Assert.IsFalse(circle.IsValid());
        }

        [TestMethod]
        public void GetArea_NegativeRadius_NegativeOne()
        {
            var circle = new Circle(-1);

            var area = circle.GetArea();

            Assert.AreEqual(-1, area);
        }

        [TestMethod]
        public void GetArea_ValidRadius_CorrectArea()
        {
            const int r = 10;
            var circle = new Circle(r);

            var area = circle.GetArea();

            Assert.AreEqual(r*r*Math.PI, area);
        }
    }
}
