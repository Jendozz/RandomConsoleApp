using System;
using System.Collections.Generic;

namespace RandomApp
{
    class Program
    {
        public static List<string> list = new List<string>();
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
        link1:
            Console.Clear();
            Console.WriteLine("Выберете действие:\n1.Добавить значение для рандома\n2.Просмотр значений для рандома\n3.Начать рандом.\n4.Выход");
            var swtch = Console.ReadLine();
            switch (swtch)
            {
                case "1":
                    {
                        Console.WriteLine("Введите значение для добавления к рандомайзеру");
                        var name = Console.ReadLine();
                        list.Add(name);
                        Console.WriteLine("Значение добавлено. Нажмите любую кнопку для возврата в главное меню.");
                        Console.ReadKey();
                        goto link1;
                    }
                case "2":
                    {
                        if (list.Count > 0)
                        {
                            foreach (var m in list)
                            {
                                Console.WriteLine($"{m}");
                            }
                            Console.ReadKey();
                            Console.WriteLine("Нажмите любую кнопку чтобы выйти в главное меню");
                            goto link1;
                        }
                        else 
                        {
                            Console.WriteLine("Вы еще не добавили значения к рандомайзеру. Нажмите любую кнопку чтобы выйти в главное меню");
                            Console.ReadKey();
                            goto link1;
                        }
                    }
                case "3":
                    {
                        if (list.Count > 0)
                        {
                            Console.WriteLine("Значения из которых будет выбрано случайное:");
                            foreach (var m in list)
                            {
                                Console.WriteLine(m);
                            }
                            Console.WriteLine("Нажмите любую кнопку для рандома");
                            Console.ReadKey();
                            var number = rnd.Next(0, list.Count);
                            Console.WriteLine();
                            Console.WriteLine($"Ваше рандомное значение:  {list[number]}");
                            Console.ReadKey();
                            goto link1;
                        }
                        else
                        {
                            Console.WriteLine("Вы еще не добавили значения к рандомайзеру. Нажмите любую кнопку чтобы выйти в главное меню");
                            Console.ReadKey();
                            goto link1;
                        }
                    }
                case "4":
                    {
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Некорректный ввод. нажмите любую клавишу для выхода в главное меню.");
                        Console.ReadKey();
                        goto link1;
                    }
            }
        }
    }
}
