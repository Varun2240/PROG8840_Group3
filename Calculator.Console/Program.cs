using Calculator;
using static System.Runtime.InteropServices.JavaScript.JSType;

Prompts.PrintWelcomeMenu();
while (true)
{
    Prompts.PrintOptions();
    Console.WriteLine("Enter operation number: ");
    string? OptionChoice = Console.ReadLine();

    //added to terminate the program
    //changed the number as added other functions
    if (OptionChoice == "17")
    {
        Console.WriteLine("Exiting calculator..");
        Environment.Exit(0);
        break;
    }

    //added to select a valid operation
    if (OptionChoice != "1" && OptionChoice != "2" && OptionChoice != "3" && OptionChoice != "4" && OptionChoice != "5" && OptionChoice != "6" && OptionChoice != "7" && OptionChoice != "8" && OptionChoice != "9" && OptionChoice != "10" && OptionChoice != "11" && OptionChoice != "12" && OptionChoice != "13" && OptionChoice != "14" && OptionChoice != "15" && OptionChoice != "16")
    {
        Console.WriteLine("Invalid option. Please select a valid operation.");
        continue;
    }

    //added sqrt, exponentiation & log function switch cases
    if (OptionChoice == "13")
    {

        Console.WriteLine("Enter time in Japan (24-hour format): ");
        string? japanTimeStr = Console.ReadLine();
        DateTime japanTime = DateTime.ParseExact(japanTimeStr, "HH:mm", null);
        DateTime canadaTime = TimeZoneConverter.ConvertJapanToCanada(japanTime);
        Console.WriteLine($"Time in Canada: {canadaTime:HH:mm}");

    }

    else if (OptionChoice == "4" || OptionChoice == "5" || OptionChoice == "6" || OptionChoice == "7" || OptionChoice == "8" || OptionChoice == "9" || OptionChoice == "10" || OptionChoice == "11" || OptionChoice == "12" || OptionChoice == "14" || OptionChoice == "15")
    {
        Console.WriteLine("Enter the value: ");
        string? number1 = Console.ReadLine();

        float number1Converted = float.Parse(number1);
        float result = 0;
        switch (OptionChoice)
        {
            case "4":
                result = SquareRoot.Eval(number1Converted);
                Console.WriteLine($"Square root of {number1Converted} = {result}");
                break;
            case "5":
                Console.WriteLine("Enter the exponent: ");
                string? exponent = Console.ReadLine();
                float exponentConverted = float.Parse(exponent);
                result = Exponentiation.Eval(number1Converted, exponentConverted);
                Console.WriteLine($"{number1Converted} to the power of {exponentConverted} = {result}");
                break;
            case "6":
                Console.WriteLine("Enter the base value: ");
                string? baseValue = Console.ReadLine();
                float baseConverted = float.Parse(baseValue);
                result = LogarithmicFunction.Eval(number1Converted, baseConverted);
                Console.WriteLine($"Log base {baseConverted} of {number1Converted} = {result}");
                break;
            case "7":
                Console.WriteLine("Enter the percentage: ");
                string? percentageInput = Console.ReadLine();
                float percentage = float.Parse(percentageInput);
                result = Percentage.CalculatePercentageOf(percentage, number1Converted);
                Console.WriteLine($"{percentage}% of {number1Converted} = {result}");
                break;
            case "8":
                result = Factorial.Calculate((int)number1Converted);
                Console.WriteLine($"Factorial of {number1Converted} = {result}");
                break;
            case "9":
                result = TemperatureConversion.CelsiusToFahrenheit(number1Converted);
                Console.WriteLine($"{number1Converted}°C = {result}°F");
                break;
            case "10":
                Console.WriteLine("Enter interest rate (in %): ");
                string? interestRateStr = Console.ReadLine();
                float interestRate = float.Parse(interestRateStr);
                Console.WriteLine("Enter time period (in years): ");
                string? timePeriodStr = Console.ReadLine();
                float timePeriod = float.Parse(timePeriodStr);
                result = InterestCalculator.CalculateSimpleInterest(number1Converted, interestRate, timePeriod);
                Console.WriteLine($"Simple interest: {result}");
                break;
            case "11":
                result = UnitConverter.ConvertFromKgToLb(number1Converted);
                Console.WriteLine($"{number1Converted} kg = {result} lb");
                break;
            case "12":
                result = CurrencyConverter.ConvertFromUSDToEUR(number1Converted);
                Console.WriteLine($"{number1Converted} USD = {result} EUR");
                break;
            case "14":
                result = CubeFunction.Eval(number1Converted);
                Console.WriteLine($"Cube of {number1Converted} = {result}");
                break;
            case "15":
                result = Reciprocal.Eval(number1Converted);
                Console.WriteLine($"Reciprocal of {number1Converted} = {result}");
                break;


        }

    }

    else
    {

        Console.WriteLine("Enter number 1: ");
        string? Number1 = Console.ReadLine();
        Console.WriteLine("Enter number 2: ");
        string? Number2 = Console.ReadLine();

        float Number1Converted = float.Parse(Number1);
        float Number2Converted = float.Parse(Number2);



        switch (OptionChoice)
        {
            case "1":
                float Sum = Evaluator.Eval("+", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} + {Number2Converted} = {Sum}");
                break;
            case "2":
                float Subtract = Evaluator.Eval("-", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} - {Number2Converted} = {Subtract}");
                break;
            case "3":
                float Product = Evaluator.Eval("*", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} * {Number2Converted} = {Product}");
                break;
            case "16":
                float result = Average.Eval(Number1Converted, Number2Converted);
                Console.WriteLine($"Average of {Number1Converted} and {Number2Converted} = {result}");
                break;

        }
    }

    // Added to ask user if they want to perform another operation
    Console.WriteLine("Do you want to perform another operation? (yes/no): ");
    string? continueChoice = Console.ReadLine()?.ToLower();
    if (continueChoice != "yes")
    {
        Console.WriteLine("Exiting calculator. Goodbye!");
        return;
    }
}