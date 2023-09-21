using Microsoft.SqlServer.Server;
using System;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace Tasks
{
    internal class Program
    {
        enum Category
        {
            Alcoholic,
            Alcoholic_lover,
            Alcoholic_holidays,
            No_alcoholic,
        }
        struct Student
        {
            public string Surname;
            public string Name;
            public int ID;
            public string Data_bithday;
            public Category Category_alco;
            public double Consumed_amount_alcoholic;
        }
        struct User
        {
            public string Town;
            public int PIN_code;
            public int Age;
            public void Print()
            {
                Console.WriteLine($"\nНовый пользователь.\nPIN-code: {PIN_code}\nВозраст: {Age}\nГород: {Town}");
            }
        }
        static void Print(Student student, double sum_alcohols)
        {
            double percent_alcohol = Math.Round(student.Consumed_amount_alcoholic / sum_alcohols * 100, 2);
            Console.WriteLine($"ID:{student.ID}.\nСтудент: {student.Surname} {student.Name}.\nДень рождения {student.Data_bithday}.\nКатегория: {student.Category_alco}\nКоличество выпитого алкоголя: {student.Consumed_amount_alcoholic}.\nПроцент выпитого алкоголя от общей массы: {percent_alcohol}%.\n");
        }

        static void Main(string[] args)
        {
            Console.Write("Доступные для проверки задания: 1, 2, 3, 4, 5, 6, 7, 8.\nДля выхода из приложение введите 'break'.\nВведите номер задания, которое хотите проверить: ");
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
                        Console.WriteLine($"byte, Min: {byte.MinValue}, Max: {byte.MaxValue};");
                        Console.WriteLine($"sbyte, Min: {sbyte.MinValue}, Max: {sbyte.MaxValue};");
                        Console.WriteLine($"short, Min: {short.MinValue}, Max: {short.MaxValue};");
                        Console.WriteLine($"ushort, Min: {ushort.MinValue}, Max: {ushort.MaxValue};");
                        Console.WriteLine($"int, Min: {int.MinValue}, Max: {int.MaxValue};");
                        Console.WriteLine($"uint, Min: {uint.MinValue}, Max: {uint.MaxValue};");
                        Console.WriteLine($"long, Min: {long.MinValue}, Max: {long.MaxValue};");
                        Console.WriteLine($"long, Min: {ulong.MinValue}, Max: {ulong.MaxValue};");
                        Console.WriteLine($"float, Min: {float.MinValue}, Max: {float.MaxValue};");
                        Console.WriteLine($"double, Min: {double.MinValue}, Max: {double.MaxValue};");
                        Console.WriteLine($"decimal, Min: {decimal.MinValue}, Max: {decimal.MaxValue};");
                        Console.WriteLine($"char, Min: {char.MinValue}, Max: {char.MaxValue};");
                        Console.WriteLine($"string, Min: N/A, Max: N/A;");
                        Console.WriteLine($"bool, Min: false, Max: true;");
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "2":
                        User new_user = new User();
                        Console.Write("Введите возраст: ");
                        new_user.Age = int.Parse(Console.ReadLine());
                        Console.Write("Введите город: ");
                        new_user.Town = Console.ReadLine();
                        Console.Write("Введите PIN_code(######): ");
                        new_user.PIN_code = int.Parse(Console.ReadLine());
                        new_user.Print();
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "3":
                        Console.Write("Введите ряд букв латинского алфавита: ");
                        string str = Console.ReadLine();
                        string result = "";
                        string str_1;
                        for (int i = 0; i < str.Length; i++)
                        {
                            str_1 = Convert.ToString(str[i]);
                            if (char.IsUpper(str, i) == true)
                            {
                                result += str_1.ToLower();
                            }
                            else
                            {
                                result += str_1.ToUpper();
                            }
                        }
                        Console.WriteLine($"Регистр букв был заменён: {result}");
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "4":
                        Console.Write("Введите первую строку: ");
                        string String = Console.ReadLine();
                        Console.Write("Введите вторую строку: ");
                        string subString = Console.ReadLine();
                        int count = 0;
                        if (String.Length > 0 & subString.Length > 0)
                        {
                            for (int x = 0; x <= String.Length - subString.Length; x++)
                            {
                                if (String.Substring(x, subString.Length) == subString)
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine($"Количество подстрок в строке: {count}");
                        }
                        else
                        {
                            Console.WriteLine($"Введены недопустимые символы.");
                        }
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "5":
                        Console.Write("Введите стандартную цену: ");
                        double normPrice = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите скидку: ");
                        double salePrice = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите стоимость отпуска: ");
                        double holidayPrice = Convert.ToDouble(Console.ReadLine());
                        if (salePrice > 0 & salePrice < 100)
                        {
                            Console.WriteLine($"Чтобы заработать на отпуск, вам нужно продать {(int)(holidayPrice / (normPrice * ((double)salePrice / 100)))} бутылок(ки) виски.");
                        }
                        else
                        {
                            Console.WriteLine("Процент долже быть от 1 до 99");
                        }
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "6":
                        Console.WriteLine("Как Вас зовут?");
                        Console.WriteLine($"Привет, {Console.ReadLine()}");
                        Console.WriteLine("Спросите, знает ли консоль что-то о тайной комнате.");
                        string secretroom = Console.ReadLine();
                        Console.WriteLine("Да");
                        Console.WriteLine("Спросите, может ли она что-то рассказать о ней.");
                        string secretroom1 = Console.ReadLine();
                        Console.WriteLine("Нет");
                        Thread.Sleep(5000);
                        Console.WriteLine("Но могу показать!");
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "7":
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "8":
                        Student student1 = new Student();
                        student1.Name = "Кирилл";
                        student1.Surname = "Смирнов";
                        student1.ID = 3220211;
                        student1.Data_bithday = "27.04.2003";
                        student1.Category_alco = Category.Alcoholic_lover;
                        student1.Consumed_amount_alcoholic = 5.3;
                        Student student2 = new Student();
                        student2.Name = "Данил";
                        student2.Surname = "Борисов";
                        student2.ID = 3220211;
                        student2.Data_bithday = "13.11.2004";
                        student2.Category_alco = Category.Alcoholic_lover;
                        student2.Consumed_amount_alcoholic = 5.1;
                        Student student3 = new Student();
                        student3.Name = "Катя";
                        student3.Surname = "Дворянцева";
                        student3.ID = 3220211;
                        student3.Data_bithday = "04.09.2005";
                        student3.Category_alco = Category.No_alcoholic;
                        student3.Consumed_amount_alcoholic = 0.1;
                        Student student4 = new Student();
                        student4.Name = "Дима";
                        student4.Surname = "Жигулин";
                        student4.ID = 3220211;
                        student4.Data_bithday = "25.06.2004";
                        student4.Category_alco = Category.Alcoholic;
                        student4.Consumed_amount_alcoholic = 20.3;
                        Student student5 = new Student();
                        student5.Name = "Тимофей";
                        student5.Surname = "Свиридов";
                        student5.ID = 3220211;
                        student5.Data_bithday = "21.02.2003";
                        student5.Category_alco = Category.Alcoholic_holidays;
                        student5.Consumed_amount_alcoholic = 1.4;
                        double sum_alcohols = student1.Consumed_amount_alcoholic + student2.Consumed_amount_alcoholic + student3.Consumed_amount_alcoholic + student4.Consumed_amount_alcoholic + student5.Consumed_amount_alcoholic;
                        Print(student1, sum_alcohols);
                        Print(student2, sum_alcohols);
                        Print(student3, sum_alcohols);
                        Print(student4, sum_alcohols);
                        Print(student5, sum_alcohols);
                        Console.WriteLine("Общее кол-во алкоголя выпитого студентами = {0}", sum_alcohols);
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    default:
                        Console.Write("\nДанного задания не существует, введите номер задание(1, 2, 3, 4, 5, 6, 7, 8) или 'break' для выхода из приложения: ");
                        break;
                }
            }
        }
    }
}
