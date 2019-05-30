using System;
using System.Collections.Generic;
using System.Text;

namespace XEProgrammingExercise.Terminal
{
    public class Product : IProduct
    {
        #region properties or variables
        public string ProductCode { get; private set; }
        public IPriceCalculator PriceCalculator { get; private set; }
        #endregion

        #region constructors
        public Product(string productCode, IPriceCalculator priceCalculator)
        {
            ProductCode = productCode;
            PriceCalculator = priceCalculator;
        }
        #endregion
    }
}
