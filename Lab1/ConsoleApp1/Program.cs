using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Call the library method  Sk, S, st with ClassLibrary1.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Console.WriteLine("   Завдання 1.\nЗнаходження кiлькостi повних годин.\n");
            Console.Write("Введiть кiлькiсть секунд, скільки пройшло з початку суток: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кiлькість повних годин: " + Class1.Sk(age));
            Console.WriteLine("____________________________________________________________________________________________\n");


            Console.WriteLine("   Завдання 2.\nЗнаходження суми.\n");
            Console.Write("Введiть натуральне число n: ");
            int an = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S=" + Class1.S(an));
            Console.WriteLine("____________________________________________________________________________________________\n");

            /// <summary>
            /// Call the library method Sum with Class1
            /// </summary>
            /// <param name = 'args'></param>
            
            Console.WriteLine("   Завдання 3.\nОбчислення суми.\n");
            Console.WriteLine("Введiть значення eps:");
            double eps = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть значення х:");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть членiв ряду:");
            int n = int.Parse(Console.ReadLine());

            double st = ClassLibrary1.Class1.st(eps, n, z);
            double F = ClassLibrary1.Class1.F(eps, n, z);
            double t = ClassLibrary1.Class1.T(st, F);

            Console.WriteLine("Сума ряду = {0},\nТочне значення функцiї для z = {1},\nПомилка обчислень = {2}", st, F, t);
            Console.ReadKey();
            Console.WriteLine("____________________________________________________________________________________________\n");
        }
    }
}
