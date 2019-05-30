using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using XEProgrammingExercise.Terminal;

namespace XEProgrammingExercise.Test
{
    [TestFixture]
    class TestPointOfSaleTerminal
    {
        static ProductsOfTerminal products = null;
        private PointOfSaleTerminal terminal = null;

        public void MySetup()
        {
            if(products != null)
            {
                return;
            }
            products = new ProductsOfTerminal();
            products.InsertProduct("A", 1.25m, 3, 3);
            products.InsertProduct("B", 4.25m);
            products.InsertProduct("C", 1.00m, 5, 6);
            products.InsertProduct("D", 0.75m);
        }


        [TestCase("ABCDABA", 13.25)]
        [TestCase("CCCCCCC", 6.0)]
        [TestCase("ABCD", 7.25)]
        [TestCase("", 0.00)]
        [TestCase("ABCDABAEEE", 13.25)]
        public void TestCalculateTotalPrice(string originalString, double result)
        {
            MySetup();
            terminal = new PointOfSaleTerminal(originalString, products);
            Assert.AreEqual(terminal.CalculateTotalPrice(), (decimal)result);
        }
    }
}
