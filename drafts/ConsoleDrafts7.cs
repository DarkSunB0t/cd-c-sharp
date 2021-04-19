using System;
using System.Collections.Generic;
 
namespace ConsoleDrafts7
{
    class Program
    {
        delegate void Delegate(); //int Square(int a);
        static void Main(string[] args)
        {
 
            Console.WriteLine(fact(5));    // факториалы и рекурсия фибоначчи
            Console.WriteLine(fib(5));
 
            //Square methodDelegate;
            Delegate methodDelegate;
            methodDelegate = () => Console.WriteLine("!!!"); //= q => q * q;
 
            methodDelegate();
            //static int Summa(int x, int y)
            //{
            //return x + y
            //}
 
            //var result = methodDelegate(5);
 
            //Console.WriteLine(result);
            Console.ReadKey();
        }
 
 
        static int fact(int p)
        {
            if (p == 0)
            {
                return 1;
            }
            else
            {
                return p * fact(p - 1);
            }
        }
 
        static int fib(int o)
        {
            return o > 1 ? fib(o - 1) + fib(o - 2) : o;
        }
 
        static int Summa(int x, int y) //анонимный лямбда метод исполняется сразу
        {
            return x + y;
        }
    }
}
