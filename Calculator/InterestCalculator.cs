using System;

namespace Calculator
{
    public class InterestCalculator
    {
        public static float CalculateSimpleInterest(float principal, float rate, float time)
        {
            // Simple interest formula: I = P * r * t / 100
            return principal * rate * time / 100f;
        }
    }
}
