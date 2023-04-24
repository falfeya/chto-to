using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();            
            Console.WriteLine("Введите номера телефонов и ФИО их владельцев (ввод пустой строки для завершения):");
            while (true)
            {
                Console.Write("Номер телефона: ");
                string phoneNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(phoneNumber))
                {
                    break;
                }
                Console.Write("ФИО владельца: ");
                string ownerName = Console.ReadLine();
                phoneBook[phoneNumber] = ownerName;
            }           
            Console.WriteLine("Введите номер телефона для поиска владельца:");
            string searchNumber = Console.ReadLine();
            if (phoneBook.TryGetValue(searchNumber, out string owner))
            {
                Console.WriteLine($"Владелец номера {searchNumber}: {owner}");
            }
            else
            {
                Console.WriteLine($"Владелец номера {searchNumber} не найден");
            }
            Console.ReadLine();
        }
    }
}
