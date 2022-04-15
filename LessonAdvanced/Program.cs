//Требуется: Создать класс с именем Rectangle.
//Lesson: 1
//В теле класса создать два поля, описывающие длины сторон double side1, side2.
//  Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
//  поля side1 и side2 инициализируются значениями аргументов.
//Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
//  прямоугольника - double PerimeterCalculator().
//Создать два свойства double Area и double Perimeter с одним методом доступа get.
//  Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
//  на экран периметр и площадь.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonAdvanced
{
    public class Rectangle
    {
        double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        double AreaCalculator()
        { 
            return side1 * side2;
        }
        double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        public double Area 
        {
            get
            { 
            return this.AreaCalculator();
            }
        }
        public double Perimeter 
        {
            get 
            {
                return this.PerimeterCalculator();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 5);
            Console.WriteLine(rectangle.Area);
            Console.WriteLine(rectangle.Perimeter);
            Console.ReadKey();
        }
    }
}
