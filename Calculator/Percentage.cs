namespace Calculator
{
    public class Percentage
    {
        public static float CalculatePercentageOf(float percentage, float number)
        {
            // Calculate percentage of a number: (Percentage / 100) * Number
            float result = (percentage / 100) * number;
            return result;
        }
    }
}
