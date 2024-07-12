namespace Calculator
{
    public class SquareRoot
    {
        public static float Eval(float number)
        {
            if (number < 0)
            {
                throw new System.ArithmeticException("Square root of a negative number is not possible.");
            }

            return (float)Math.Sqrt(number);
        }
    }
}