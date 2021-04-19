using System;
using System.Collections.Generic;

namespace ConsoleDrafts5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000);
            account.Notify += DisplayMessage; //Добавляем обработчик для события Notify за счёт += в главный цикл
            account.Notify += DisplayRedMessage; //Новый обработчик для цвета !!!придумать как сделать вычитание лишь красным

            account.Take(100);
            Console.WriteLine(account.Sum);

            account.Put(120);
            Console.WriteLine(account.Sum);

            Console.ReadKey();
        }
        static void DisplayMessage(string msg) //Создание отображения изменений счёта
        {
            Console.WriteLine(msg);
        }

        static void DisplayRedMessage(string msg) //
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

    }
    class Account
    {
        public delegate void AccountHandler(string message); 
        public event AccountHandler Notify; //создание события оповещения с модификатором доступа
        public Account(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            //            Notify("");  - не подходит, так как может не работать обработчик событий
            Notify?.Invoke($"На счёт поступило {sum}"); //? - значит код справа вызывается только если изменится null, invoke - 
            // if (Notify !=null)                           - альтернативный способ записи за счёт определённого условия изменения
            //{
            //  Notify($"На счёт поступило {sum}, итого: {Sum}");
            //                  или также можно записать
            //  Notify($"На счёт поступило" +{sum}+, итого: {Sum}");
            //}
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято {sum}");
            }
            else
            {
                Notify?.Invoke($"Недостаточно средств для проведения операции {sum}");
            }
        }
    }
}
