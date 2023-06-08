using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace testClass
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AnalyzeTriangle_Input10and10and10_OutputEquilateralTriangle()
        {
            //arrange

            int sideA, sideB, sideC;
            sideA = 10;
            sideB = 10;
            sideC = 10;

            //act

            string output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);  

            //assert

            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", output);
        }


        [Test]
        public void AnalyzeTriangle_Input10and10and9_OutputIsocelesTriangle()
        {
            //arrange

            int sideA, sideB, sideC;
            sideA = 10;
            sideB = 10;
            sideC = 9;

            //act

            string output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //assert

            Assert.AreEqual("The triangle is valid and is an ISOSCELES", output);
        }

        [Test]
        public void AnalyzeTriangle_Input8and8and9_OutputIsocelesTriangle()
        {
            //arrange

            int sideA, sideB, sideC;
            sideA = 8;
            sideB = 8;
            sideC = 9;

            //act

            string output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //assert

            Assert.AreEqual("The triangle is valid and is an ISOSCELES", output);
        }

        [Test]
        public void AnalyzeTriangle_Input7and7and5_OutputIsocelesTriangle()
        {
            //arrange

            int sideA, sideB, sideC;
            sideA = 8;
            sideB = 8;
            sideC = 9;

            //act

            string output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //assert

            Assert.AreEqual("The triangle is valid and is an ISOSCELES", output);
        }


    }
}
