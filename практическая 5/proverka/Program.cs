using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proverka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();

            Console.Write("Введите число: ");
            int inputNumber = int.Parse(Console.ReadLine());

            if (numbers.Contains(inputNumber))
            {
                Console.WriteLine("Это число уже было введено ранее");
            }
            else
            {
                numbers.Add(inputNumber);
                Console.WriteLine("Число успешно сохранено");
            }
            Console.ReadLine();
        }
    }
}
