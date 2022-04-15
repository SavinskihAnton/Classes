//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
//одно строковое поле и метод void Show().
//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
//содержание.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Author","Title","Content");
            book.Show();
            Console.ReadKey();
        }
    }
}
