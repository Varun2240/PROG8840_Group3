namespace Calculator{
    public class Evaluator{
        public static float Eval(string Operator, params float[] Operands){
            float result;
            switch(Operator){
                case "+":
                    result = Add.Eval(Operands[0], Operands[1]);
                    break;
                case "*":
                    result = Multiply.Eval(Operands[0], Operands[1]);
                    break;
                case "-":
                    result = Subtract.Eval(Operands[0], Operands[1]);
                    break;
                case "sqrt":
                    result = SquareRoot.Eval(Operands[0]);
                    break;
                case "^":
                    result = Exponentiation.Eval(Operands[0], Operands[1]);
                    break;
                case "log":
                    result = LogarithmicFunction.Eval(Operands[0], Operands[1]);
                    break;
                case "%":
                    result = Percentage.CalculatePercentageOf(Operands[0], Operands[1]);
                    break;
                case "!":
                    result = Factorial.Calculate((int)Operands[0]);
                    break;
                case "simpleInterest":
                    result = InterestCalculator.CalculateSimpleInterest(Operands[0], Operands[1], (int)Operands[2]);
                    break;
                case "kgToLb":
                    result = UnitConverter.ConvertFromKgToLb(Operands[0]);
                    break;
                case "usdToEur":
                    result = CurrencyConverter.ConvertFromUSDToEUR(Operands[0]);
                    break;
               /* case "japanToCanada":
                    result = TimeZoneConverter.ConvertJapanToCanada(DateTime.UtcNow).Ticks;
                    break;*/

                default:
                    throw new Exception("unimplemented");
            }
            return result;
        }
    }
}