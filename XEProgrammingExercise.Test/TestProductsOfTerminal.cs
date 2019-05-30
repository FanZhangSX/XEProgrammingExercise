using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using XEProgrammingExercise.Terminal;

namespace XEProgrammingExercise.Test
{
    class TestProductsOfTerminal
    {
        ProductsOfTerminal terminal = null;
        [SetUp]
        public void Setup()
        {
            terminal = new ProductsOfTerminal();
        }

        [Test]
        public void TestInsertProduct1()
        {
            terminal.InsertProduct("A", 1.00m);

            var product = terminal.GetProductByProductCode("A");
            Assert.AreNotEqual(product, null);
            Assert.AreEqual(product.PriceCalculator.GetType(), typeof(OnlySinglePriceCalculator));
        }

        [Test]
        public void TestInsertProduct2()
        {
            terminal.InsertProduct("B", 1.25m, 3.00m, 3);

            var product = terminal.GetProductByProductCode("B");
            Assert.AreNotEqual(product, null);
            Assert.AreEqual(product.PriceCalculator.GetType(), typeof(PackPlusSinglePriceCalculator));
        }
    }
}
