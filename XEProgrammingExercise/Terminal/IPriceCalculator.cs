using System;
using System.Collections.Generic;
using System.Text;

namespace XEProgrammingExercise.Terminal
{
    public interface IPriceCalculator
    {
        /// <summary>
        /// Calculate sum price
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Sum Price</returns>
        decimal Calculator(int num);
    }
}
