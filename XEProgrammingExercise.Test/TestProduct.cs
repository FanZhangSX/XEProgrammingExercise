using NUnit.Framework;
using XEProgrammingExercise.Terminal;

namespace XEProgrammingExercise.Test
{
    public class TestProduct
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("A", 1.00)]
        [TestCase("", 1.00)]
        [TestCase(null, 1.00)]
        public void TestProductConstructors(string productCode, decimal price)
        {
            IPriceCalculator priceCalculator = new OnlySinglePriceCalculator(price);
            Product product = new Product(productCode, priceCalculator);

            Assert.AreSame(product.ProductCode, productCode);
            Assert.AreSame(product.PriceCalculator, priceCalculator);
        }
    }
}