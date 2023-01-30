using System;
using System.Collections.Generic;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task1();
            var t2 = LinqTasks.Task2();
            var t3 = LinqTasks.Task3();
            var t4 = LinqTasks.Task4();
            var t5 = LinqTasks.Task5();
            var t6 = LinqTasks.Task6();
            var t7 = LinqTasks.Task7();
            var t8 = LinqTasks.Task8();
            var t9 = LinqTasks.Task9();
            var t10 = LinqTasks.Task10();
            var t11 = LinqTasks.Task11();
            var t12 = LinqTasks.Task12();
            var t13 = LinqTasks.Task13(new[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 });
            var t14 = LinqTasks.Task14();


            Console.WriteLine("Task1\n");
            print(t);
            Console.WriteLine("\nTask2\n");
            print(t2);
            Console.WriteLine("\nTask3\n");
            Console.WriteLine(t3 + "\n");
            Console.WriteLine("\nTask4\n");
            print(t4);
            Console.WriteLine("\nTask5\n");
            print(t5);
            Console.WriteLine("\nTask6\n");
            print(t6);
            Console.WriteLine("\nTask7\n");
            print(t7);
            Console.WriteLine("\nTask8\n");
            Console.WriteLine(t8 + "\n");
            Console.WriteLine("\nTask9\n");
            Console.WriteLine(t9 + "\n");
            Console.WriteLine("\nTask10\n");
            print(t10);
            Console.WriteLine("\nTask11\n");
            print(t11);
            Console.WriteLine("\nTask12\n");
            print(t12);
            Console.WriteLine("\nTask13\n");
            Console.WriteLine(t13 + "\n");
            Console.WriteLine("\nTask14\n");
            print(t14);
        }

        private static void print<T>(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                Console.WriteLine("pusto :oooo");
                return;
            }

            foreach (var item in collection)
            {
                var properties = item.GetType().GetProperties();
                foreach (var prop in properties)
                {
                    Console.WriteLine(prop.Name + " = " + prop.GetValue(item));
                }
            }
            Console.WriteLine("\n");
        }
    }
}
