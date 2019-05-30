using System;
using System.Collections.Generic;
using System.Text;

namespace XEProgrammingExercise.Terminal
{
    public class OnlySinglePriceCalculator : IPriceCalculator
    {
        #region properties or variables
        private readonly decimal _singlePrice;
        #endregion

        #region constructors
        public OnlySinglePriceCalculator(decimal singlePrice)
        {
            _singlePrice = singlePrice;
        }
        #endregion

        #region methods
        public decimal Calculator(int num)
        {
            if(num < 0)
            {
                return 0.00m;
            }
            return _singlePrice * num;
        }
        #endregion

    }
}
