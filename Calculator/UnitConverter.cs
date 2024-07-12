using System;

namespace Calculator
{
    public class UnitConverter
    {
        private const float KgToLbFactor = 2.20462f;

        public static float ConvertFromKgToLb(float kilograms)
        {
            return kilograms * KgToLbFactor;
        }
    }
}
