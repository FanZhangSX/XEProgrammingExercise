using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using XEProgrammingExercise.Terminal;

namespace XEProgrammingExercise.Test
{
    class TestOnlySinglePriceCalculator
    {
        OnlySinglePriceCalculator calculator = null;
        [SetUp]
        public void Setup()
        {
            calculator = new OnlySinglePriceCalculator(1.25m);
        }

        [Test]
        public void TestCalculator()
        {
            Assert.AreEqual(calculator.Calculator(3), 3.75m);
            Assert.AreEqual(calculator.Calculator(4), 5.00m);
        }
    }
}
