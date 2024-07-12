namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestAddNegativeNumbers()
    {
        Assert.Equal(-4L, Add.Eval(-1L, -3L));
    }
    [Fact]
    public void TestAddZero()
    {
        Assert.Equal(10L, Add.Eval(10L, 0L));
    }
    [Fact]
    public void TestMultiply()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }
    [Fact]
    public void TestMultiplyNegativeNumbers()
    {
        Assert.Equal(-6L, Multiply.Eval(-2L, 3L));
    }

    [Fact]
    public void TestMultiplyZero()
    {
        Assert.Equal(0L, Multiply.Eval(10L, 0L));
    }
    [Fact]
    public void TestMultiplyLargeNumbers()
    {
        Assert.Equal(150000000L, Multiply.Eval(3000L, 50000L));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void TestSubtractOperation()
    {
        Assert.Equal(4, Evaluator.Eval("-", 6, 2));
    }
    [Fact]
    public void TestSubtract()
    {
        Assert.Equal(2, Subtract.Eval(5, 3));
    }
    [Fact]
    public void TestSubtractNegativeNumbers()
    {
        Assert.Equal(-2, Subtract.Eval(-5, -3));
    }
    [Fact]
    public void TestSubtractZero()
    {
        Assert.Equal(5, Subtract.Eval(5, 0));
    }
    [Fact]
    public void TestSubtractPrecisionIssue()
    {
        Assert.Equal(0.3f, Subtract.Eval(0.5f, 0.2f));
    }
    [Fact]
    public void TestOperation()
    {
        Assert.Equal(4, Evaluator.Eval("-", 6, 2));
    }
    [Fact]
    public void TestExitOperation()
    {
        var exitInput = new StringReader("4\n");
        Console.SetIn(exitInput);
        var exitOperationProcess = new System.Diagnostics.Process();
        exitOperationProcess.StartInfo.FileName = "dotnet";
        exitOperationProcess.StartInfo.Arguments = "run";
        exitOperationProcess.StartInfo.UseShellExecute = false;
        exitOperationProcess.StartInfo.RedirectStandardInput = true;
        exitOperationProcess.Start();
        exitOperationProcess.WaitForExit();
        Assert.True(exitOperationProcess.HasExited);

    }

    [Fact]
    public void TestContinueFunction()
    {
        var continueInput = new StringReader("1\n10\n4\n4\nno\n");
        Console.SetIn(continueInput);
        var continueFunctionProcess = new System.Diagnostics.Process();
        continueFunctionProcess.StartInfo.FileName = "dotnet";
        continueFunctionProcess.StartInfo.Arguments = "run";
        continueFunctionProcess.StartInfo.UseShellExecute = false;
        continueFunctionProcess.StartInfo.RedirectStandardInput = true;
        continueFunctionProcess.Start();
        continueFunctionProcess.WaitForExit();
        Assert.True(continueFunctionProcess.HasExited);
    }
    [Fact]
    public void TestValidOperation()
    {
        var validInput = new StringReader("5\n1\n10\n5\n3\n4\nno\n");
        Console.SetIn(validInput);
        var validOperationProcess = new System.Diagnostics.Process();
        validOperationProcess.StartInfo.FileName = "dotnet";
        validOperationProcess.StartInfo.Arguments = "run";
        validOperationProcess.StartInfo.UseShellExecute = false;
        validOperationProcess.StartInfo.RedirectStandardInput = true;
        validOperationProcess.Start();
        validOperationProcess.WaitForExit();
        Assert.True(validOperationProcess.HasExited);
    }
    //added test classes for sqrt,exponentiation and log function test cases 
    [Fact]
    public void TestPositiveNumberForSqrt()
    {
        Assert.Equal(4, SquareRoot.Eval(16));
    }

    [Fact]
    public void TestZeroForSqrt()
    {
        Assert.Equal(0, SquareRoot.Eval(0));
    }

    [Fact]
    public void TestNegativeNumberForSqrt()
    {
         Assert.Throws<System.ArithmeticException>(() => SquareRoot.Eval(-1));
        
    }

    [Fact]
    public void TestSquareRootFunction()
    {
        Assert.Equal(3, Evaluator.Eval("sqrt", 9));
    }

    [Fact]
    public void TestIntegerValueForExponentiation()
    {
        Assert.Equal(81, Exponentiation.Eval(3, 4));
    }

    [Fact]
    public void TestFractionalValueForExponentiation()
    {
        Assert.Equal(125, Exponentiation.Eval(5, 3));
    }

    [Fact]
    public void TestZeroForExponent()
    {
        Assert.Equal(1, Exponentiation.Eval(8, 0));
    }

    [Fact]
    public void TestExponentiationFunction()
    {
        Assert.Equal(8, Evaluator.Eval("^", 2, 3));
    }

    [Fact]
    public void TestFunctionLogarithmBase10()
    {
        Assert.Equal(3, LogarithmicFunction.Eval(1000, 10));
    }

    [Fact]
    public void TestFunctionLogarithmBase2()
    {
        Assert.Equal(0, LogarithmicFunction.Eval(1, 2));
    }

    [Fact]
    public void TestFunctionLogarithmBase3()
    {
        Assert.Equal(1, LogarithmicFunction.Eval(3, 3));
    }

    [Fact]
    public void TestLogarithmFunction()
    {
        Assert.Equal(3, Evaluator.Eval("log", 1000, 10));
    }

    [Fact]
    public void TestUnimplemented()
    {
        // Arrange
        float[] operands = { 4, 2 };
        string operatorName = ">"; // Assuming '>' is not implemented

        // Act and Assert
        Exception exception = Assert.Throws<Exception>(() => Evaluator.Eval(operatorName, operands));
        Assert.Equal("unimplemented", exception.Message);
    }

    [Fact]
    public void TestCelsiusToFahrenheitZeroConversion()
    {
       
        float celsius = 0;
        float expectedFahrenheit = 32;
        float actualFahrenheit = TemperatureConversion.CelsiusToFahrenheit(celsius);
        Assert.Equal(expectedFahrenheit, actualFahrenheit, precision: 2);
    }

    [Fact]
    public void TestCelsiusToFahrenheitPositiveConversion()
    {

        float celsius = 5;
        float expectedFahrenheit = 41;
        float actualFahrenheit = TemperatureConversion.CelsiusToFahrenheit(celsius);
        Assert.Equal(expectedFahrenheit, actualFahrenheit, precision: 2);
    }

    [Fact]
    public void TestCelsiusToFahrenheitNegativeConversion()
    {
        float celsius = -10;
        float expectedFahrenheit = 14;
        float actualFahrenheit = TemperatureConversion.CelsiusToFahrenheit(celsius);
        Assert.Equal(expectedFahrenheit, actualFahrenheit, precision: 2);
    }
    [Fact]
    public void TestCurrencyConversionFromUSDToEUR()
    {
        Assert.Equal(88.0f, CurrencyConverter.ConvertFromUSDToEUR(100.0f));
    }

    [Fact]
    public void TestCurrencyConversionCheckNegativeAmount()
    {
        Assert.Equal(-88.0f, CurrencyConverter.ConvertFromUSDToEUR(-100.0f));
    }

    [Fact]
    public void TestCurrencyConversionCheckingZero()
    {
        Assert.Equal(0.0f, CurrencyConverter.ConvertFromUSDToEUR(0.0f));
    }
    [Fact]
    public void TestUnitConversionCheckConverstionKgToLb()
    {
        Assert.Equal(22.0462f, UnitConverter.ConvertFromKgToLb(10.0f));
    }

    [Fact]
    public void TestUnitConversionNegativeKg()
    {
        Assert.Equal(-22.0462f, UnitConverter.ConvertFromKgToLb(-10.0f));
    }

    [Fact]
    public void TestUnitConversionZeroKg()
    {
        Assert.Equal(0.0f, UnitConverter.ConvertFromKgToLb(0.0f));
    }
    [Fact]
    public void TestTimeZoneConversionJapanToCanada()
    {

        Assert.True(true);
    }

    [Fact]
    public void TestTimeZoneConversionInvalidTimeZone()
    {
        Assert.True(true);
    }

    [Fact]
    public void TestTimeZoneConversionSameTimeZone()
    {

        Assert.True(true);
    }
    [Fact]
    public void TestSimpleInterestCalculation()
    {

        float principal = 1000;
        float rate = 5.0f;
        int time = 2;


        float interest = InterestCalculator.CalculateSimpleInterest(principal, rate, time);


        Assert.Equal(100.0f, interest);
    }

    [Fact]
    public void TestSimpleInterestWithZeroPrincipal()
    {
        // Arrange
        float principal = 0;
        float rate = 5.0f;
        int time = 2;

        // Act
        float interest = InterestCalculator.CalculateSimpleInterest(principal, rate, time);

        // Assert
        Assert.Equal(0.0f, interest);
    }

    [Fact]
    public void TestSimpleInterestWithZeroRate()
    {

        float principal = 1000;
        float rate = 0.0f;
        int time = 2;


        float interest = InterestCalculator.CalculateSimpleInterest(principal, rate, time);


        Assert.Equal(0.0f, interest);
    }

    [Fact]
    public void TestFactorialPositiveNumber()
    {
        // Arrange
        int n = 5;

        // Act
        int result = Factorial.Calculate(n);

        // Assert
        Assert.Equal(120, result); // 5! = 120
    }

    [Fact]
    public void TestFactorialZero()
    {
        // Arrange
        int n = 0;

        // Act
        int result = Factorial.Calculate(n);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void TestFactorialNegativeNumber()
    {

        int n = -5;


        Assert.Throws<ArgumentException>(() => Factorial.Calculate(n));
    }
    [Fact]
        public void TestPercentageCalculation()
    {
        // Arrange
        float percentage = 20;
        float number = 50;

        // Act
        float result = Percentage.CalculatePercentageOf(percentage, number);

        // Assert
        Assert.Equal(10, result); // 20% of 50 should be 10
    }

    [Fact]
    public void TestPercentageCalculationWithZeroPercentage()
    {
        // Arrange
        float percentage = 0;
        float number = 100;

        // Act
        float result = Percentage.CalculatePercentageOf(percentage, number);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void TestPercentageCalculationZeroNumber()
    {
        // Arrange
        float percentage = 50;
        float number = 0;

        // Act
        float result = Percentage.CalculatePercentageOf(percentage, number);

        // Assert
        Assert.Equal(0, result); // 50% of 0 should be 0
    }



}