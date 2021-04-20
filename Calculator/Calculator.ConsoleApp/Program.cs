using System;
using System.Collections.Generic;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Operation> operationList = new List<Operation>();

            while (true)
            {
                TextDisplayer.ShowInitializationText();

                string userOption = Console.ReadLine();

                if (!OptionVerifier.IsOption(userOption))
                {
                    TextDisplayer.ShowErrorText("Error: Invalid operation type! Try again with a valid option.");
                    continue;
                }

                if (OptionVerifier.IsPreviousOperationOption(userOption))
                {
                    Console.WriteLine("=-=-=-=-=- OPERATIONS -=-=-=-=-=");
                    foreach (Operation operation in operationList)
                    {
                        Console.WriteLine(operation.AttributesToString());
                    }
                    Console.ReadLine();
                    continue;
                }
                else if (OptionVerifier.IsExitOption(userOption))
                {
                    break;
                }

                Console.WriteLine("Enter the first number:");
                string numberAStr = Console.ReadLine();

                Console.WriteLine("Enter the second number:");
                string numberBStr = Console.ReadLine();

                try
                {
                    Operation currentOperation = new Operation(double.Parse(numberAStr), double.Parse(numberBStr));

                    switch (userOption)
                    {
                        case "1":
                            currentOperation.Addition();
                            break;

                        case "2":
                            currentOperation.Subtraction();
                            break;

                        case "3":
                            currentOperation.Multiplication();
                            break;

                        case "4":
                            currentOperation.Division();
                            break;

                        default:
                            continue;
                    }

                    operationList.Add(currentOperation);
                    TextDisplayer.ShowResultText(currentOperation);

                }
                catch (FormatException)
                {
                    TextDisplayer.ShowErrorText("Error: Invalid format value. Try again with a valid double value.");
                    continue;
                }

                catch (DivideByZeroException)
                {

                    TextDisplayer.ShowErrorText("Error: Division by Zero is not allowed. Perform the division with any value other than 0.");
                    continue;
                }

                continue;
            }
        }
    }
}
