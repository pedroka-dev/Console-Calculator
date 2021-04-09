using System;
using System.Collections.Generic;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> operationList = new List<string>();

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=-=-=-=-=- Calculator -=-=-=-=-=");
                Console.WriteLine("Enter the type of the desired operation:");
                Console.WriteLine("  1 - Addition");
                Console.WriteLine("  2 - Subtraction");
                Console.WriteLine("  3 - Multiplication");
                Console.WriteLine("  4 - Division");
                Console.WriteLine("  5 - Show previous operations");
                Console.WriteLine("  6 - Exit");
                Console.WriteLine("=-=-=-=-=- =-=-=-=-=-= -=-=-=-=-=");

                string userOption = Console.ReadLine();

                if(userOption != "1" && userOption != "2" && userOption != "3" 
                    && userOption != "4" && userOption != "5" && userOption != "6")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Invalid operation type! Try again with a valid option.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if(userOption == "5")
                {
                    Console.WriteLine("=-=-=-=-=- OPERATIONS -=-=-=-=-=");
                    foreach (string operation in operationList)
                    {
                        Console.WriteLine(operation);
                    }
                    Console.ReadLine();
                    continue;
                }
                else if (userOption == "6")
                {
                    break;
                }

                Console.WriteLine("Enter the first number:");
                string numberA = Console.ReadLine();

                Console.WriteLine("Enter the second number:");
                string numberB = Console.ReadLine();

                double operationResult = 0;
                string operationSymbol = "";

                try
                {
                    switch (userOption)
                    {
                        case "1":
                            operationResult = double.Parse(numberA) + double.Parse(numberB);
                            operationSymbol = "+";
                            break;

                        case "2":
                            operationResult = double.Parse(numberA) - double.Parse(numberB);
                            operationSymbol = "-";
                            break;

                        case "3":
                            operationResult = double.Parse(numberA) * double.Parse(numberB);
                            operationSymbol = "*";
                            break;

                        case "4":
                            if(numberB == "0")
                                throw new DivideByZeroException();

                            operationResult = double.Parse(numberA) / double.Parse(numberB);
                            operationSymbol = "/";
                            break;

                        default:

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Invalid format value. Try again with a valid double value.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                catch (DivideByZeroException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Division by Zero is not allowed. Perform the division with any value other than 0.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadLine();
                    continue;
                }

                string sucessfulOperation = numberA.ToString() + " " + operationSymbol + " " + numberB.ToString() + " = " + operationResult.ToString();
                operationList.Add(sucessfulOperation);

                Console.WriteLine("Result:" + operationResult);
                Console.WriteLine("=-=-=-=-=- =-=-=-=-=-= -=-=-=-=-=");
                Console.WriteLine(sucessfulOperation);
                Console.ReadLine();
                continue;
            }
        }
    }
}
