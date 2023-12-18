using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zhidkova_Laboratory_work_3;

namespace Zhidkova_Laboratory_work_3_Test
{
    [TestClass]
    public class Zhidkova_Laboratory_work_3_Test
    {
        [TestMethod]
        public void Amount_2Plus3Inc1_Returned5()
        {
            var calc = new Calculator();
            double arg1 = 2;
            double arg2 = 3;
            double expected = 5;

            double result = calc.Amount(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Division_4division2_Returned2()
        {
            var calc = new Calculator();
            double arg1 = 4;
            double arg2 = 2;
            double expected = 2;

            double result = calc.Division(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Oh my god, we can't divison on zero")]
        public void Division_4division0_Exception()
        {
            var calc = new Calculator();
            double arg1 = 4;
            double arg2 = 0;

            double result = calc.Division(arg1, arg2);
        }
    }
}
