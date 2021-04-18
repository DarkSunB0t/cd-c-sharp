using System;
using System.Collections.Generic;

namespace ConsoleDrafts
{
    class Program
    {
        static void Main(string[] args)
            {
            End A1 = new End(10, 34, "kek"); // создание дочерних объектов за счёт преднастройки метода внизу
            End A2 = new End(10, 34, "kek"); // creating child based classes via method down below
            End A3 = new End(10, 34, "kek");
            string a1 = string.Join(",", A1._years, A1._height, A1._name); // Заготовка. Показ наших объектов за счёт текстового String в строку консоли
            string a2 = string.Join(",", A2._years, A2._height, A2._name); // Billet. Show our objects via text String in console line
            string a3 = string.Join(",", A3._years, A3._height, A3._name);

            Console.WriteLine("Press any key to continue!"); // Приказ Console написать текст - Command to Console to show our text
            Console.ReadKey(); // Блокировка прогресса - привычка чтобы не позволять проге автоматически закрываться после достижения результата - Block programm progress - old habbit for stop letting programm auto-close after job is done
            Console.WriteLine("Write from 1 to 3");

            if (Console.ReadLine() == "1") // Создание условия Если-if Console прочтёт что мы напечатали после нажатия enter - Creating a condition If for Console reading what we typed after pressing enter
                {
                Console.WriteLine(a1); // Показ заготовки с нашими объектами и их свойствами - Show billet with objects and they properties
                }
            if (Console.ReadLine() == "2")
                {
                Console.WriteLine(a2);
                }
            if (Console.ReadLine() == "3")
                {
                Console.WriteLine(a3);
                }
            }
            public class End // Наш класс и присваивание метода свойств через конструктор - Our class with assignment method properties via constructor
            {
                public int _years;
                public int _height;
                public string _name;

                public End()
                {
                    _years = 1;
                    _height = 1;
                    _name = "piss";
                }
                
                public End(int years, int height, string name)
                {
                _years = years;
                _height = height;
                _name = name;
                }
            }
        }
    }
