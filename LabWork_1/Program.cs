using System;

namespace LabWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Доступные для проверки задания: 1, 2, 3, 4.\nДля выхода из приложение введите 'break'.\nВведите номер задания, которое хотите проверить: ");
            bool flag = true;
            while (flag)
            {
                string number = Console.ReadLine();
                switch (number)
                {
                    case "break":
                        flag = false;
                        break;
                    case "1":
                        Console.Write("\nВведите своё имя: ");
                        string name = Console.ReadLine();
                        Console.Write($"Привет {name}\n");
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "2":
                        Console.Write("Введите первое число(целое): ");
                        int value1 = int.Parse(Console.ReadLine());
                        Console.Write("Введите первое число(целое): ");
                        int value2 = int.Parse(Console.ReadLine());
                        double result = (double)value1 / value2;
                        Console.WriteLine($"{value1} / {value2} = {result}");
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "3":
                        Console.Write("Введите букву латинского алфавита: ");
                        string str = Console.ReadLine();
                        char char_1 = Convert.ToChar(str);
                        if (str.Contains("Z") | str.Contains("z"))
                        {
                            Console.WriteLine("Это была последняя буква алфавита.");
                        }
                        else
                        {
                            Console.WriteLine((char)(char_1 + 1));
                        }
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "4":
                        Console.Write("Введите коэффициент A(Целое число): ");
                        int A = int.Parse(Console.ReadLine());
                        Console.Write("Введите коэффициент B(Целое число): ");
                        int B = int.Parse(Console.ReadLine());
                        Console.Write("Введите коэффициент C(Целое число): ");
                        int C = int.Parse(Console.ReadLine());
                        if (A == 0)
                        {
                            double root = (-C) / B;
                            Console.WriteLine("Ответ: {0}", root);
                        }
                        else
                        {
                            double D = Math.Pow(B, 2) + (-4) * A * C;
                            if (D < 0)
                            {
                                Console.WriteLine("Ответ: 'Корней нет'.");
                            }
                            else if (D == 0)
                            {
                                double root = (-B) / 2 * A;
                                Console.WriteLine("Ответ: {0}", root);
                            }
                            else
                            {
                                double root1 = ((-B) + Math.Sqrt(D)) / (2 * A);
                                double root2 = ((-B) - Math.Sqrt(D)) / (2 * A);
                                Console.WriteLine("Ответ: {0}, {1}", root1, root2);
                            }
                        }
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    default:
                        Console.Write("\nДанного задания не существует, введите номер задание(1, 2, 3, 4) или 'break' для выхода из приложения: ");
                        break;
                }
            }
        }
    }
}
