using System;

namespace Tymakov7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 7.1: Создать класс счет в банке и вывести информацию о нем");
            Bankex1 BankAccount1 = new Bankex1(234, 456321, Type.current);
            Console.WriteLine($"{BankAccount1.AccountType} под номером {BankAccount1.AccountNumber} содержит {BankAccount1.AccountBalance}");



            Console.WriteLine("Упр 7.2: В Упр 7.1 добавить генерацию номера счета");
            Bankex2 BankAccount2 = new Bankex2(143212, Type.savings);
            Bankex2 BankAccount3 = new Bankex2(2322112, Type.current);
            Console.WriteLine($"{BankAccount2.AccountType} под номером {BankAccount2.AccountNumber} содержит {BankAccount2.AccountBalance}");
            Console.WriteLine($"{BankAccount3.AccountType} под номером {BankAccount3.AccountNumber} содержит {BankAccount3.AccountBalance}");



            Console.WriteLine("Упр 7.3: В Упр 7.2 добавить снятие и пополнение баланса");
            Bankex3 BankAccount4=new Bankex3(Type.current);
            Console.WriteLine($"{BankAccount4.AccountType} под номером {BankAccount4.AccountNumber} содержит {BankAccount4.AccountBalance}");
            BankAccount4.DepositMoney(123213);
            Console.WriteLine($"{BankAccount4.AccountType} под номером {BankAccount4.AccountNumber} содержит {BankAccount4.AccountBalance}");
            BankAccount4.WithdrawMoney(10000);



            Console.WriteLine("Д/З 7.1: Создать описание здания");
            Builder building = new Builder(100, 30, 60, 5);
            Console.WriteLine($"Здание под номером {building.IdBuilding} высотой {building.Height} м , {building.Countfloors} этажей, {building.CountEntrance} подъезов и {building.CountFlats} квартир");
            Console.WriteLine($"Колличество квартир в одном подъезде - {building.CalculateCountFlatsinEntrance()}");
            Console.WriteLine($"Колличество квартир на одном этаже - {building.CalculateCountFlatsonFloor()}");
        }
    }
}
