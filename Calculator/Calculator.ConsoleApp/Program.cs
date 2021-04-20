using System;
using System.Collections.Generic;

namespace Calculator.ConsoleApp
{
    class Program
    {
        private static bool IsExitOption(string option)
        {
            return option == "6";
        }

        private static bool IsPreviousOperationOption(string option)
        {
            return option == "5";
        }

        private static bool IsOption(string option)
        {
            return option == "1" || option == "2" || option == "3" || option == "4" || option == "5" || option == "6";
        }

        static void Main(string[] args)
        {
            List<Operation> operationList = new List<Operation>();

            while (true)
            {
                TextDisplayer.ShowInitializationText();

                string userOption = Console.ReadLine();

                if (!IsOption(userOption))
                {
                    TextDisplayer.ShowErrorText("Error: Invalid operation type! Try again with a valid option.");
                    continue;
                }

                if (IsPreviousOperationOption(userOption))
                {
                    Console.WriteLine("=-=-=-=-=- OPERATIONS -=-=-=-=-=");
                    foreach (Operation operation in operationList)
                    {
                        Console.WriteLine(operation.AttributesToString());
                    }
                    Console.ReadLine();
                    continue;
                }
                else if (IsExitOption(userOption))
                {
                    break;
                }

                Console.WriteLine("Enter the first number:");
                string numberAStr = Console.ReadLine();

                Console.WriteLine("Enter the second number:");
                string numberBStr = Console.ReadLine();

                double numberA;
                double numberB;
                string operationSymbol;
                double operationResult;
                
                try
                {
                    numberA = double.Parse(numberAStr);
                    numberB = double.Parse(numberBStr);

                    switch (userOption)
                    {
                        case "1":
                            operationResult = numberA + numberB;
                            operationSymbol = "+";
                            break;

                        case "2":
                            operationResult = numberA - numberB;
                            operationSymbol = "-";
                            break;

                        case "3":
                            operationResult = numberA * numberB;
                            operationSymbol = "*";
                            break;

                        case "4":
                            if (numberBStr == "0")
                                throw new DivideByZeroException();

                            operationResult = numberA / numberB;
                            operationSymbol = "/";
                            break;

                        default:
                            continue;
                    }
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

                Operation sucessfullOperation = new Operation(numberA, numberB, operationSymbol, operationResult);
                operationList.Add(sucessfullOperation);

                TextDisplayer.ShowResultText(operationResult, sucessfullOperation.AttributesToString());
                continue;
            }
        }
    }
}
