using System;

namespace Calculator
{
    public class CurrencyConverter
    {
        
        private static readonly float USD_to_EUR = 0.88f;

        public static float ConvertFromUSDToEUR(float amount)
        {
            return amount * USD_to_EUR;
        }
    }
}
