using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        static List<string> toDoList = new List<string>();

        static void Main(string[] args)
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
                Console.WriteLine("3. Avsluta");
            
        }
    }
}
