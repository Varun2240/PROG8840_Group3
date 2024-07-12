using Calculator;

Prompts.PrintWelcomeMenu();
while (true)
{
    Prompts.PrintOptions();
    Console.WriteLine("Enter operation number: ");
    string? OptionChoice = Console.ReadLine();

    //added to terminate the program
    //changed the number as added other functions
    if (OptionChoice == "7")
    {
        Console.WriteLine("Exiting calculator..");
        Environment.Exit(0);
        break; 
    }
    
    //added to select a valid operation
    if (OptionChoice != "1" && OptionChoice != "2" && OptionChoice != "3" && OptionChoice != "4" && OptionChoice != "5" && OptionChoice != "6")
    {
        Console.WriteLine("Invalid option. Please select a valid operation.");
        continue;
    }

    //added sqrt, exponentiation & log function switch cases
    if (OptionChoice == "4" || OptionChoice == "5" || OptionChoice == "6")
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