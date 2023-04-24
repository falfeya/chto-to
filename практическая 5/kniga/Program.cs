using System;
using System.Xml.Linq;

namespace kniga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные о контакте:");
            Console.Write("ФИО: ");
            string name = Console.ReadLine();
            Console.Write("Улица: ");
            string street = Console.ReadLine();
            Console.Write("Номер дома: ");
            string houseNumber = Console.ReadLine();
            Console.Write("Номер квартиры: ");
            string flatNumber = Console.ReadLine();
            Console.Write("Мобильный телефон: ");
            string mobilePhone = Console.ReadLine();
            Console.Write("Домашний телефон: ");
            string flatPhone = Console.ReadLine();

            XElement contact = new XElement("Person",
            new XAttribute("name", name),
            new XElement("Address",
            new XElement("Street", street),
            new XElement("HouseNumber", houseNumber),
            new XElement("FlatNumber", flatNumber)),
            new XElement("Phones",
            new XElement("MobilePhone", mobilePhone),
            new XElement("FlatPhone", flatPhone)));

            contact.Save("contact.xml");
            Console.WriteLine("Файл contact.xml успешно создан.");
            Console.ReadKey();
        }
    }
}
