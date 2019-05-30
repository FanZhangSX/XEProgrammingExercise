using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using XEProgrammingExercise.Terminal;

namespace XEProgrammingExercise.Test
{
    class TestPackPlusSinglePriceCalculator
    {
        PackPlusSinglePriceCalculator calculator = null;
        [SetUp]
        public void Setup()
        {
            calculator = new PackPlusSinglePriceCalculator(1.25m, 4.00m, 4);
        }

        [Test]
        public void TestCalculator()
        {
            Assert.AreEqual(calculator.Calculator(3), 3.75m);
            Assert.AreEqual(calculator.Calculator(4), 4.00m);
            Assert.AreEqual(calculator.Calculator(5), 5.25m);
        }
    }
}
