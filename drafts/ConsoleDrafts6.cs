using System;
using System.Collections.Generic;

namespace ConsoleDrafts6
{
    // привязка через Nuget в зависимостях пкм - Telegram.Bot и словарь
    class Program
    {
        private static Telegram.Bot.TelegramBotClient _bot;

        static Dictionary<int, string> dict = new Dictionary<int, string>(); //создание словаря

        static void Main(string[] args)
        {
            dict.Add(-1, "Тест"); //добавление к словару по цифре вызова
            dict.Add(0, "Ураган");
            dict.Add(1, "Извержение вулкана");
            dict.Add(2, "Падение метеорита");
            dict.Add(3, "Потоп");
            dict.Add(4, "Нашествие саранчи");
            dict.Add(5, "Землетрясение");

            dict.Remove(-1); //удаление из словаря
            
            if (dict.TryGetValue(3, out string value))
            {
                Console.WriteLine(value);
            }    

            _bot = new Telegram.Bot.TelegramBotClient("Наш токен от Botfather");
            _bot.OnMessage += _bot_OnMessage;
            _bot.StartReceiving();

            Console.ReadKey();
        }


        private static void _bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var chatId = e.Message.Chat.Id;
            var message = e.Message.Text;

            Random rand = new Random();
            var r1 = rand.Next(0, 5); // от нуля до 4

            _bot.SendTextMessageAsync(chatId, $"{dict[r1]}");

        }
    }
}
