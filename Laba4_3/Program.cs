using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Laba4_3
{
    class Program
    {
        /* Успішність
 студентів
 Прізвище, номер
 групи, оцінки з
 трьох предметів
 Прізвище Номер групи*/


        static void Main(string[] args)
        {

            var S = new List<Students>()
            {

                new Students(){Secondname = "Glekkkk",group = "IK-11",firstmark= "50"},
                new Students(){ Secondname = "Gl", group = "IT-11", firstmark = "51" },
                new Students(){ Secondname = "Gle", group = "IK-11", firstmark = "52" },
            };

            while (true)
            {
                Console.Write(" Введіть дію" + " \n");
                Console.WriteLine("додати дані нажми 'A'");
                Console.WriteLine("шукати дані нажми 'B'");
                Console.WriteLine("показати всі дані нажми 'C'");
                Console.WriteLine("Сортування 'F'");
                Console.WriteLine("Видалення 'D'");
                Console.WriteLine("Почистити конколь 'Enter'/Назад");
                Console.WriteLine();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.F:

                        S.Sort(delegate (Students st1, Students st2)   // sort
                        {
                            return st1.Secondname.CompareTo(st2.Secondname);
                        });
                        foreach (Students el in S)
                        {
                            Console.WriteLine(el.Secondname + "\t" + el.group + "\t" + el.firstmark);
                        }
                        
                        break;
                    case ConsoleKey.D: // delete

                        Console.WriteLine("Введить елемент який хочете видалити");
                        int s = int.Parse(Console.ReadLine());
                        S.RemoveAt(s);
                        foreach (Students el in S)
                        {
                            Console.WriteLine(el.Secondname + "\t" + el.group + "\t" + el.firstmark);
                        }
                        break;
                    case ConsoleKey.Enter:// Clear

                        Console.Clear();
                        break;

                    case ConsoleKey.B: // Find
                        Console.WriteLine("Введіть групу для пошуку");
                        string s1 = Console.ReadLine();
                        var found = S.Find(item => item.group == s1);
                        Console.WriteLine("GROUP=" + found.group + " " + found.Secondname);
                        break;
                    case ConsoleKey.A: //add

                        Console.WriteLine("Введіть дані");
                        Console.WriteLine("Введіть прізвище");
                        string SecondName = Console.ReadLine();
                        Console.WriteLine("Введіть group");
                        string Group = Console.ReadLine();
                        Console.WriteLine("Введіть firstmark");
                        string Firstmark = Console.ReadLine();
                        if (SecondName != null && Group != null && Firstmark != null)
                            S.Add(new Students { Secondname = SecondName, group = Group, firstmark = Firstmark });
                        else
                        { 
                            Console.WriteLine("Заповніть всі поля");
                        }

                        Console.Clear();
                        break;
                    case ConsoleKey.C:
                        Console.Write("all");
                        foreach (Students el in S)
                        {
                            Console.WriteLine(el.Secondname + "\t" + el.group + "\t" + el.firstmark);
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);

                        break;
                }


            }

        }
    }
}
