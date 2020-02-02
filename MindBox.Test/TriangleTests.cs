using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxLib._2dFigures.Implementation;

namespace MindBox.Test
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void IsValid_NegativeSide_False()
        {
            var triangle = new Triangle(-1, 3, 4);

            Assert.IsFalse(triangle.IsValid());
        }

        [TestMethod]
        public void GetArea_NegativeSide_NegativeOne()
        {
            var triangle = new Triangle(-1, 3, 4);

            var area = triangle.GetArea();

            Assert.AreEqual(-1, area);
        }

        [TestMethod]
        public void GetArea_ValidTriangle_CorrectArea()
        {
            var triangle = new Triangle(5, 3, 4);

            var area = triangle.GetArea();

            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void IsRightTriangle_NotRightTriangle_False()
        {
            var triangle = new Triangle(10, 3, 4);

            Assert.IsFalse(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void IsRightTriangle_RightTriangle_True()
        {
            var triangle = new Triangle(5, 3, 4);

            Assert.IsTrue(triangle.IsRightTriangle());
        }
    }
}