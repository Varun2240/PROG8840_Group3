namespace Calculator
{
    public class Reciprocal
    {
        public static float Eval(float number)
        {
            if (number == 0)
            {
                throw new DivideByZeroException("Cannot find the reciprocal of zero.");
            }
            return 1 / number;
        }
    }
}
