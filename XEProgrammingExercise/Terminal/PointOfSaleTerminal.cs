using System;
using System.Collections.Generic;
using System.Text;

namespace XEProgrammingExercise.Terminal
{
    public class PointOfSaleTerminal : IDisposable
    {
        #region properties or variables
        private IDictionary<string, int> _numbersOfProducts = new Dictionary<string, int>();
        private readonly string _productString;
        private IProductsOfTerminal _productsOfTeminal;
        private bool disposed = false;
        #endregion

        #region constructors
        public PointOfSaleTerminal(string productString, IProductsOfTerminal productsOfTerminal)
        {
            _productsOfTeminal = productsOfTerminal;
            _productString = productString;
            foreach(var productChar in productString.ToCharArray())
            {
                if(_numbersOfProducts.ContainsKey(productChar.ToString()))
                {
                    _numbersOfProducts[productChar.ToString()]++;
                }
                else
                {
                    _numbersOfProducts.Add(productChar.ToString(), 1);
                }
            }
        }
        #endregion

        #region methods
        public decimal CalculateTotalPrice()
        {
            decimal total = 0.0m;

            foreach(var p in _numbersOfProducts)
            {
                var product = _productsOfTeminal.GetProductByProductCode(p.Key);
                if(product != null)
                {
                    total += product.PriceCalculator.Calculator(p.Value);
                }
                else
                {
                    Console.WriteLine($"{p.Key} is not found");
                }
            }

            return total;
        }


        public void OutPutMySelf()
        {
            Console.WriteLine("Original String: " + _productString);
            foreach(var rec in _numbersOfProducts)
            {
                Console.WriteLine($"{rec.Key} : {rec.Value}");
            }
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

            if (disposing)
            {
                _productsOfTeminal.Dispose();
                _productsOfTeminal = null;
                _numbersOfProducts = null;
            }

            disposed = true;
        }
        #endregion
    }
}
