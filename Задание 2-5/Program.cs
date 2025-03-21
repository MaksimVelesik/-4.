using System;

class Program
{
    static void RectPS(double x1, double y1, double x2, double y2, out double P, out double S)
    {
        double length = Math.Abs(x2 - x1);
        double width = Math.Abs(y2 - y1);

        P = 2 * (length + width);
        S = length * width;
    }

    static void Main()
    {
        (double x1, double y1, double x2, double y2)[] rectangles = new (double, double, double, double)[3]
        {
            (1, 2, 4, 5),
            (0, 0, 3, 3),
            (2, 1, 5, 4)
        };

        double perimeter, area;

        for (int i = 0; i < rectangles.Length; i++)
        {
            RectPS(rectangles[i].x1, rectangles[i].y1, rectangles[i].x2, rectangles[i].y2, out perimeter, out area);
            Console.WriteLine($"Прямоугольник {i + 1}: Периметр = {perimeter}, Площадь = {area}");
        }
    }
}