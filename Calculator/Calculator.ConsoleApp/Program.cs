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
                Console.WriteLine("=-=-=-=-=- CALCULADORA -=-=-=-=-=");
                Console.WriteLine("Digita o tipo da operação desejada:");
                Console.WriteLine("  1 - Adição");
                Console.WriteLine("  2 - Subtração");
                Console.WriteLine("  3 - Multiplicação");
                Console.WriteLine("  4 - Divisão");
                Console.WriteLine("  5 - Mostrar operações anteriores");
                Console.WriteLine("  6 - Sair");
                Console.WriteLine("=-=-=-=-=- =-=-=-=-=-= -=-=-=-=-=");

                string opcaoUsuario = Console.ReadLine();

                if(opcaoUsuario != "1" && opcaoUsuario != "2" && opcaoUsuario != "3" 
                    && opcaoUsuario != "4" && opcaoUsuario != "5" && opcaoUsuario != "6")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Tipo de operação inválida! Tente novamente");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if(opcaoUsuario == "5")
                {
                    Console.WriteLine("=-=-=-=-=- HISTÓRICO -=-=-=-=-=");
                    foreach (string operation in operationList)
                    {
                        Console.WriteLine(operation);
                    }
                    Console.ReadLine();
                    continue;
                }
                else if (opcaoUsuario == "6")
                {
                    break;
                }

                Console.WriteLine("Digite o primeiro número:");
                string numero1 = Console.ReadLine();

                Console.WriteLine("Digite o segundo número:");
                string numero2 = Console.ReadLine();

                double resultado = 0;
                string simboloOperacao = "";

                try
                {
                    switch (opcaoUsuario)
                    {
                        case "1":
                            resultado = double.Parse(numero1) + double.Parse(numero2);
                            simboloOperacao = "+";
                            break;

                        case "2":
                            resultado = double.Parse(numero1) - double.Parse(numero2);
                            simboloOperacao = "-";
                            break;

                        case "3":
                            resultado = double.Parse(numero1) * double.Parse(numero2);
                            simboloOperacao = "*";
                            break;

                        case "4":
                            if(numero2 == "0")
                                throw new DivideByZeroException();

                            resultado = double.Parse(numero1) / double.Parse(numero2);
                            simboloOperacao = "/";
                            break;

                        default:

                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Valor inválido. Digite um valor double válido para o calculo.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                catch (DivideByZeroException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Divisão com Zero não é permitida. Realize a divisão com qualquer valor diferente de 0.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadLine();
                    continue;
                }

                string operacaoRealizada = numero1.ToString() + " " + simboloOperacao + " " + numero2.ToString() + " = " + resultado.ToString();
                operationList.Add(operacaoRealizada);

                Console.WriteLine("Resultado:" + resultado);
                Console.WriteLine("=-=-=-=-=- =-=-=-=-=-= -=-=-=-=-=");
                Console.WriteLine(operacaoRealizada);
                Console.ReadLine();
                continue;
            }
        }
    }
}
