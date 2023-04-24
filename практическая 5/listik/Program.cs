using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listik
{
    internal class Program
    {
        static void Main(string[] args)
            {
                List<int> numbers = new List<int>();
                FullList(numbers, 100, 0, 100); 
                Console.WriteLine("Список чисел:");
                PrintList(numbers); 
                RemoveRange(numbers, 26, 49); 
                Console.WriteLine("Список чисел после удаления:");
                PrintList(numbers);
            Console.ReadKey();
            }

            static void FullList(List<int> list, int count, int min, int max)
            {
                Random rnd = new Random();
                for (int i = 0; i < count; i++)
                {
                    list.Add(rnd.Next(min, max + 1));
                }
            }

       static void PrintList(List<int> list)
            {
            foreach (int number in list)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

       static void RemoveRange(List<int> list, int from, int to)
            {
            list.RemoveAll(number => number > from && number < to);           
            }
    }

}
