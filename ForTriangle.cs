using System;

namespace Triangle
{
    class ForTriangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public ForTriangle()
        {
            SideA = 0;
            SideB = 0;
            SideC = 0;
        }

        public ForTriangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public void Perimeter()
        {
            var p = SideA + SideB + SideC;
            Console.WriteLine($"Периметр треугольника = {p}");
        }

        public void Area()
        {
            var p = (SideA + SideB + SideC) / 2;  // Полупериметр
            var s = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            if (double.IsNaN(s))
            {
                Console.WriteLine("Такой треугольник не существует.");
            }
            else
            {
                Console.WriteLine($"Площадь треугольника по формуле Герона = {s}");
            }
        }
    }
}
