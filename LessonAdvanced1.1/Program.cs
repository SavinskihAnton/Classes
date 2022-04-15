//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс с именем Address.
//В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого
//поля, создать свойство с двумя методами доступа.
//Создать экземпляр класса Address.
//В поля экземпляра записать информацию о почтовом адресе.
//Выведите на экран значения полей, описывающих адрес.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonAdvanced1._1
{
    public class Address
    {
        int index, house, apartament;
        string country, city, street;

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index= value;
            }
        }
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int Apartament
        {
            get
            {
                return apartament;
            }
            set
            {
                apartament = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address= new Address();
            address.Country = "USA";
            address.City = "NewYork";
            address.Street = "YoltStreet";
            address.House = 29;
            address.Apartament = 120;
            address.Index = 660058;

            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartament);
            Console.WriteLine(address.Index);

            Console.ReadKey();
        }
    }
}
