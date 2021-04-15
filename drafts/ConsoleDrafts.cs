using System;
using System.Collections.Generic;

namespace ConsoleDrafts
{
    class Program
    {
        static void Main(string[] args)
            {
            End A1 = new End(10, 34, "kek");
            End A2 = new End(10, 34, "kek");
            End A3 = new End(10, 34, "kek");
            string a1 = string.Join(",", A1._years, A1._height, A1._name);
            string a2 = string.Join(",", A2._years, A2._height, A2._name);
            string a3 = string.Join(",", A3._years, A3._height, A3._name);

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
            Console.WriteLine("Write from 1 to 3");

            if (Console.ReadLine() == "1")
                {
                Console.WriteLine(a1);
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
            public class End
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
