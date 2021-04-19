using System;
using System.Collections.Generic;
 
namespace ConsoleDrafts4
{
    class Program
    {
        delegate void Message();
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Message message;
 
                if(Console.ReadLine().ToLower() == "hello")
                {
                    message = Hello;
                }
                else
                {
                    message = Goodbay;
                }
                message = Hello;
 
                message();
 
                Console.ReadKey();
            }
 
        static void Hello()
            {
                Console.WriteLine("Hello!");
            }
        static void Goodbye()
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
 
}
