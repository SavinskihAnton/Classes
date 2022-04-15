//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать классы Point и Figure.
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
//аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
//аргументов типа Point.
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
//стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
//многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(1, 1, "One"), new Point(1, 2, "Two"), new Point(1, 3, "Three"));
            Console.Write(figure.Type);
            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
