using System;
using System.Collections.Generic;
using System.Text;

namespace XEProgrammingExercise.Terminal
{
    public interface IProduct
    {
        string ProductCode { get; }
        IPriceCalculator PriceCalculator { get; }
    }
}
