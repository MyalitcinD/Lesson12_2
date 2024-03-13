using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x,y проверяемой точки");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус R и координаты x0 yo центра окружности");
            Console.Write("R = ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.Write("x0 = ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y0 = ");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности = {0}", Circle.GetCircumference(R));
            Console.WriteLine("Площадь круга = {0}", Circle.GetArea(R));
            if(Circle.CordCheck(x, y, R, x0, y0)) {
                Console.WriteLine("Точка принадлежит кругу");
            }
            else {
                Console.WriteLine("Точка НЕ принадлежит кругу");
            }
            Console.ReadKey();




        }
    }
}
