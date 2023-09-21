using System;
using System.Reflection.Emit;
using System.Security.AccessControl;

namespace LabWork_2
{
    internal class Program
    {
        enum Accounts
        {
            Current,
            Savings
        }
        enum University
        {
            KSU,
            KHTI,
            KAI
        }
        struct Worker
        {
            public string Name;
            public University University;
        }
        struct Acc_Bank
        {
            public long Number_account;
            public string Type;
            public double Count;
        }
        static void Main(string[] args)
        {
        Console.Write("Доступные для проверки задания: 1, 2, 3.\nДля выхода из приложение введите 'break'.\nВведите номер задания, которое хотите проверить: ");
            bool flag = true;
            while (flag)
            {
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        Accounts account1 = Accounts.Current;
                        Accounts account2 = Accounts.Savings;
                        Console.WriteLine($"Ваши текущие счета: {account1} и {account2}");
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "2":
                        Acc_Bank my_account = new Acc_Bank();
                        my_account.Number_account = 4081781057000012323;
                        my_account.Type = "Общий";
                        my_account.Count = 124212.123;
                        Console.WriteLine($"Номер счёта - {my_account.Number_account}, тип счёта - {my_account.Type}, баланс - {my_account.Count} (руб.)");

                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "3":
                        Worker worker = new Worker();
                        worker.Name = "Дмитрий";
                        worker.University = University.KSU;
                        Console.WriteLine($"{worker.Name} работник {worker.University}");
                        Console.Write("\nВведите следующий номер задания или break завершения работы: ");
                        break;
                    case "break":
                        flag = false;
                        break;
                    default:
                        Console.Write("\nДанного задания не существует, введите номер задание(1, 2, 3) или 'break' для выхода из приложения: ");
                        break;
                }
            }
        }
    }
}
