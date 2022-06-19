using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP
{
    public class IsoscelesTrapezoid
    {
        private Point PointA;
        private Point PointB;
        private Point PointC;
        private Point PointD;

        public IsoscelesTrapezoid(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            PointA = pointA;
            PointB = pointB;
            PointC = pointC;
            PointD = pointD;

            if (!IsIsosceles())
            {
                Console.WriteLine("Trapezoid is not isosceles");
            }
        }

        public bool IsIsosceles()
        {
            if ((GetSideLenght(PointB, PointA) == GetSideLenght(PointC, PointD)) && ((PointB.Y - PointA.Y) == (PointC.Y - PointD.Y)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintSideLenghts()
        {
            Console.WriteLine($"Side A - B = {GetSideLenght(PointA, PointB):F3}");
            Console.WriteLine($"Side B - C = {GetSideLenght(PointB, PointC):F3}");
            Console.WriteLine($"Side C - D = {GetSideLenght(PointC, PointD):F3}");
            Console.WriteLine($"Side A - D = {GetSideLenght(PointD, PointA):F3}");
        }

        public double GetPerimeter()
        {
            return GetSideLenght(PointB, PointA) * 2 + GetSideLenght(PointC, PointB) + GetSideLenght(PointD, PointA);
        }

        public void PrintPerimeter()
        {
            Console.WriteLine($"Perimeter = {GetPerimeter():F3}");
        }

        public double GetSquare()
        {
            return ((PointB.Y - PointA.Y) / 2) * (GetSideLenght(PointC, PointB) + GetSideLenght(PointD, PointA));
        }

        public void PrintSquare()
        {
            Console.WriteLine($"Square = {GetSquare():F3}");
        }

        public double GetSideLenght(Point x, Point y)
        {
            return Math.Sqrt(Math.Pow((x.X - y.X), 2) + Math.Pow((x.Y - y.Y), 2));
        }
    }
}
