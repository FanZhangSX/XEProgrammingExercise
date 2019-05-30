using System;
using System.Collections.Generic;
using System.Text;

namespace XEProgrammingExercise.Terminal
{
    public class PackPlusSinglePriceCalculator : IPriceCalculator
    {
        #region properties or variables
        private readonly decimal _singlePirce;
        private readonly decimal _packPrice;
        private readonly int _numberPerPack;
        #endregion

        #region constructors
        public PackPlusSinglePriceCalculator(decimal singlePrice, decimal packPrice, int numberPerPack)
        {
            _singlePirce = singlePrice;
            _packPrice = packPrice;
            _numberPerPack = numberPerPack;
        }
        #endregion

        #region methods
        public decimal Calculator(int num)
        {
            return (num / _numberPerPack) * _packPrice + (num % _numberPerPack) * _singlePirce;
        }

        #endregion
    }
}
