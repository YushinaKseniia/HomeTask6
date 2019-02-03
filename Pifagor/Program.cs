using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            do
            {

                Console.WriteLine("\nEnter the type of numerical system: __\b\b");
                int sys_is = Convert.ToInt32(Console.ReadLine());//Система исчисления
                Console.WriteLine("\nEnter the size of Table: __\b\b");
                int num = Convert.ToInt32(Console.ReadLine());//Размер матрицы

                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine();
                    for (int j = 1; j <= num; j++)
                    {
                        Console.Write("{0,8}", Convert.ToString(i * j, sys_is));
                    }
                }
                
                Console.WriteLine("\nDo you want to go on? (any key/n):__\b\b");
                key = Console.ReadKey().Key;
            } while (key != ConsoleKey.N);
            Console.ReadKey();
        }//static void Main(string[] args)
    }//class Program
}
