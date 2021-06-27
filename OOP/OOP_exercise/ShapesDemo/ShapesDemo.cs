using System;
using Exercise.Shapes;

namespace Exercise
{
    static class ShapesDemo
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Circle(5, 10, 14, "Красный"),
                new Rectangle(10, 10, "Черный"),
                new Circle(4, 4, 10, "Желтый"),
                new Rectangle(7, 14, "Зеленый")
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
                
                Console.WriteLine();
            }
        }
    }
}

/* Результаты роботы программы:
 
Красный круг с радиусом 14 см. 
Расположен в координатах X: 5, Y: 10

Черный прямоугольник с координатами точек Х: 10, Y: 10

Желтый круг с радиусом 10 см. 
Расположен в координатах X: 4, Y: 4

Зеленый прямоугольник с координатами точек Х: 7, Y: 14

 */

