using System;
using System.Collections.Generic;
using System.Text;

namespace XEProgrammingExercise.Terminal
{
    public class ProductsOfTerminal : IProductsOfTerminal
    {
        #region properties or variables
        private List<IProduct> _products = new List<IProduct>();
        private bool disposed = false;
        public List<IProduct> Product
        {
            get
            {
                return _products;
            }
        }
        #endregion

        #region methods
        /// <summary>
        /// Insert new product which has single price into List
        /// </summary>
        /// <param name="productCode"></param>
        /// <param name="signlePrice"></param>
        public void InsertProduct(string productCode, decimal signlePrice)
        {
            IPriceCalculator priceCalculator = new OnlySinglePriceCalculator(signlePrice);
            AddProduct(productCode, priceCalculator);
        }
        
        /// <summary>
        /// Insert a new product which has multi price into List
        /// </summary>
        /// <param name="productCode"></param>
        /// <param name="signlePrice"></param>
        /// <param name="packPrice">Price for whole sale</param>
        /// <param name="numberPerPack">Number of whole sale</param>
        public void InsertProduct(string productCode, decimal signlePrice, decimal packPrice, int numberPerPack)
        {
            IPriceCalculator priceCalculator = new PackPlusSinglePriceCalculator(signlePrice, packPrice, numberPerPack);
            AddProduct(productCode, priceCalculator);
        }
        
        /// <summary>
        /// Add product object into List
        /// </summary>
        /// <param name="productCode"></param>
        /// <param name="priceCalculator"></param>
        private void AddProduct(string productCode, IPriceCalculator priceCalculator)
        {
            IProduct product = new Product(productCode, priceCalculator);
            _products.Add(product);
        }
       
        /// <summary>
        /// search product list by product code
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        public IProduct GetProductByProductCode(string productCode)
        {
            foreach(var item in _products)
                if(item.ProductCode == productCode)
                    return item;

            return null;
        }
        #endregion

        #region dispose
        /// <summary>
        /// Implementation for interface of Disposable
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if(disposing)
            {
                _products = null;
            }

            disposed = true;
        }
        #endregion
    }
}
