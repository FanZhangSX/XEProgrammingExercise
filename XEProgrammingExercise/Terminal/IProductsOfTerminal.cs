using System;
using System.Collections.Generic;
using System.Text;

namespace XEProgrammingExercise.Terminal
{
    public interface IProductsOfTerminal : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        IProduct GetProductByProductCode(string productCode);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productCode"></param>
        /// <param name="signlePrice"></param>
        void InsertProduct(string productCode, decimal signlePrice);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productCode"></param>
        /// <param name="signlePrice"></param>
        /// <param name="packPrice"></param>
        /// <param name="numberPerPack"></param>
        void InsertProduct(string productCode, decimal signlePrice, decimal packPrice, int numberPerPack);
    }
}
