using System;
using System.Numerics;

namespace Calculator_forBig_Framework
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите первое число:");
                BigInteger numberA = BigInteger.Parse(Console.ReadLine());

                Console.WriteLine("Введите знак желаемого действия (+, -, *, /)");
                string action = Console.ReadLine();

                Console.WriteLine("Введите второе число:");
                BigInteger numberB = BigInteger.Parse(Console.ReadLine());

                string result = "";

                switch (action)
                {
                    case "+":
                        result = Convert.ToString(numberA + numberB);
                        break;
                    case "-":
                        result = Convert.ToString(numberA - numberB);
                        break;
                    case "*":
                        result = Convert.ToString(numberA * numberB);
                        break;
                    case "/":
                        result = Convert.ToString(numberA / numberB);
                        result += Convert.ToString("\nостаток от деления:"+numberA % numberB);
                        break;
                    default:
                        Console.WriteLine("Что-то пошло не так");
                        break;
                }
                Console.WriteLine("\nРезультат:");
                Console.WriteLine(result + "\n");
                Console.WriteLine("нажмите Enter чтобы выполнить новое действие");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
