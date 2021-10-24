using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Hola! Buenas dias! Bonjour! Привет! Я калькулятор!");
            try
            {
                string A = "";
                string B = "";
                Console.Write("Введи целое число А = ");
                A = Console.ReadLine();
                double cleanA = 0;
                while (!double.TryParse(A, out cleanA))
                {
                    Console.WriteLine("Ты ввел неверно, повтори пожалуйста ввод целого числа ");
                    Console.Write("Введи целое число А = ");
                    A = Console.ReadLine();
                }
                Console.Write("Введи целое число Б =");
                B = Console.ReadLine();
                double cleanB = 0;
                while (!double.TryParse(B, out cleanB))
                {
                    Console.WriteLine("Ты ввел неверно, повтори пожалуйста ввод целого числа ");
                    Console.Write("Введи целое число B = ");
                    B = Console.ReadLine();
                }
                Console.WriteLine("Вот какие операции я могу провести с твоими числами:");
                Console.WriteLine("\t1 - сложение;\n\t2 - вычитание;\n\t3 - умножение;\n\t4 - частное;");
                Console.Write("Введи код операции:");
                int option = Convert.ToInt32(Console.ReadLine());
                while (option < 1 || option > 4)
                {
                    Console.WriteLine("Код операции введен неправильно. Введи индекс операции от 1 до 4");
                    Console.Write("Введи код операции:");
                    option = int.Parse(Console.ReadLine());
                }

                switch (option)
                {
                    case 1:
                        {
                            Console.Write("Сумма чисел А+Б = ");
                            Console.WriteLine($"{cleanA + cleanB:f2}");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Разность числе А-Б = ");
                            Console.WriteLine($"{cleanA - cleanB:f2}");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Произведение чисел А*Б = ");
                            Console.WriteLine($"{cleanA * cleanB:f2}");
                            break;
                        }
                    case 4:
                        {
                            if (cleanA != 0 && cleanB == 0)
                            {
                                Console.Write("Деление на 0");
                                break;
                            }
                            else if (cleanA == 0 && cleanB == 0)
                            {
                                Console.Write("Деление 0 на 0");
                            }
                            else
                            {
                                Console.Write("Частное чисел А/Б = " +
                                    "");
                                Console.WriteLine($"{cleanA / cleanB:f2}");
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
