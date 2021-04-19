using System;
using System.Collections.Generic;
 
namespace ConsoleDrafts3 //собственный код для разбора, задача создать терминал с заданиями и работниками, с возможностью добавлять новую работу через терминал
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Employee Biba = new Employee("Биба", 33, 1337, "бибы.н3ть");
            Employee Boba = new Employee("Боба", 66, 1336, "б0бы.н3ть");
            Work Plotina = new Work("Поднять плотину", "Для прохожденя далее, необходимо поднять платину рычагом, что даст Ящур.", 20, "Biba");
            Work KamenB = new Work("Канал завалить", "Ящур: Канал нужно завалить камнем - камень я не дам.", 999, "Boba");
            string workers = string.Join(",", Biba.Name, Biba.Age, Biba.Sosiska, Biba.Email);
            string workers0 = string.Join(",", Boba.Name, Boba.Age, Boba.Sosiska, Boba.Email);
            string job1 = string.Join(",", Plotina.Type, Plotina.TypeDesc, Plotina.TypeTime, Plotina.TypeEmployee);
            string job2 = string.Join(",", KamenB.Type, KamenB.TypeDesc, KamenB.TypeTime, KamenB.TypeEmployee);
            ConsoleMenu cm = new ConsoleMenu(Employe, Jobs, CreateJob);
            cm.Show(false);
            void Employe()
            {
                Console.WriteLine(workers);
                Console.WriteLine(workers0);
            }
            void Jobs()
            {
                Console.WriteLine(job1);
                Console.WriteLine(job2);
            }
            static void CreateJob() { Console.WriteLine("Как писать методы с созданием классов от ввода и Список задач - метод для возвращения классов с определённым свойством для каждого рабочего"); }
 
        }
    }
 
    class ConsoleMenu
    {
        public delegate void MenuMethod();
        public List<MenuMethod> Methods;
        public ConsoleMenu(params MenuMethod[] methods)
        {
            Methods = new List<MenuMethod>();
            Methods.AddRange(methods);
            ItemColor = ConsoleColor.Yellow;
            SelectionColor = ConsoleColor.Blue;
        }
        public ConsoleColor ItemColor;
        public ConsoleColor SelectionColor;
        public int SelectedItem { get; private set; }
        private int top;//Положение первой строки меню
 
        public void Show(bool addEmptyLineBefore = true)
        {
            top = Console.CursorTop;
            if (addEmptyLineBefore)
            {
                Console.WriteLine();
                top++;
            }
            Console.ForegroundColor = ItemColor;
            for (int i = 0; i < Methods.Count; i++)
            {
                if (i == SelectedItem)
                {
                    Console.BackgroundColor = SelectionColor;
                }
                else
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ItemColor;
                }
                Console.WriteLine(Methods[i].Method.Name);
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ResetColor();
            WaitForInput();
        }
 
        private void WaitForInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.Enter:
                    Methods[SelectedItem]();
                    Show();
                    break;
            }
        }
 
        private void MoveDown()
        {
            SelectedItem = SelectedItem == Methods.Count - 1 ? 0 : SelectedItem + 1;
            Console.SetCursorPosition(0, top);
            Show(false);
        }
 
        private void MoveUp()
        {
            SelectedItem = SelectedItem == 0 ? Methods.Count - 1 : SelectedItem - 1;
            Console.SetCursorPosition(0, top);
            Show(false);
        }
 
 
    }
 
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Sosiska { get; set; }
        public string Email { get; set; }
        public Employee(string _name, int _age, int _sosiska, string _email)
        {
            Name = _name;
            Age = _age;
            Sosiska = _sosiska;
            Email = _email;
        }
    }
    public class Work
    {
        public string Type { get; set; }
        public string TypeDesc { get; set; }
        public int TypeTime { get; set; }
        public string TypeEmployee { get; set; }
        public Work(string _Type, string _TypeDesc, int _TypeTime, string _TypeEmployee)
        {
            Type = _Type;
            TypeDesc = _TypeDesc;
            TypeTime = _TypeTime;
            TypeEmployee = _TypeEmployee;
        }
    }
 
}
