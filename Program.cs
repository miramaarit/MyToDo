using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        static List<string> toDoList = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Todo-lista:");
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {toDoList[i]}");
                }
                Console.WriteLine("\nVad vill du göra?");
                Console.WriteLine("1. Lägg till uppgift");
                Console.WriteLine("2. Ta bort uppgift");
                Console.WriteLine("3. För att avsluta");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddTodo();
                        break;
                    case "2":
                        RemoveTodo();
                        break;
                    case"3":
                         return;
                    default:
                        Console.WriteLine("Gör ett val, försök igen");
                        break;

                }
                static void AddTodo()
                {
                    Console.Write("Skriv in en ny uppgift: ");
                    var todo = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(todo))
                    {
                        toDoList.Add(todo);
                    }
                }

                static void RemoveTodo()
                {
                    Console.Write("Ange numret på uppgiften du vill ta bort: ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= toDoList.Count)
                    {
                        toDoList.RemoveAt(index - 1);
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt nummer, tryck på valfri knapp för att fortsätta.");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
