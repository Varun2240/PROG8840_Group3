namespace Calculator
{
    public class LogarithmicFunction
    {
        public static float Eval(float number, float baseValue)
        {
            return (float)Math.Log(number, baseValue);
        }
    }
}