using System;
using System.Collections.Generic;
using System.Drawing;

namespace HomeWork3.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fractions:");
            var fract1 = new Fractions(10, 1045);
            Console.WriteLine($"fract1 = {fract1}");
            var fract2 = new Fractions(24, 9890);
            Console.WriteLine($"fract2 = {fract2}");
            var fract3 = new Fractions(5, 50);
            Console.WriteLine($"fract3 = {fract3}");
            Console.WriteLine();

            Console.WriteLine($"{fract1} + {fract2} = {fract1 + fract2}");
            Console.WriteLine($"{fract2} - {fract3} = {fract2 - fract3}");
            Console.WriteLine($"{fract1} * {fract3} = {fract1 * fract3}");
            Console.WriteLine($"{fract2} / {fract3} = {fract2 / fract3}");
            Console.WriteLine($"{fract1} > {fract2} - {fract1 > fract2}");
            Console.WriteLine($"{fract3} <= {fract2} - {fract3 <= fract2}");
            Console.WriteLine($"{fract1} != {fract2} - {fract1 != fract2}");
            Console.WriteLine();

            Console.WriteLine("Money:");
            var money1 = new Money(40, 45);
            Console.WriteLine($"money1 = {money1}");
            var money2 = new Money(13, 7);
            Console.WriteLine($"money2 = {money2}");
            var money3 = new Money(98, 97);
            Console.WriteLine($"money3 = {money3}");
            var money4 = new Money(98, 97);
            Console.WriteLine($"money4 = {money4}");
            Console.WriteLine();

            Console.WriteLine($"{money1} + {money2} = {money1 + money2}");
            Console.WriteLine($"{money3} - {money1} = {money3 - money1}");
            Console.WriteLine($"{money2} / {money1} = {money2 / money1}");
            Console.WriteLine($"{money3} / {fract2} = {money3 / fract2}");
            Console.WriteLine($"{money1} * {money2} = {money1 * money2}");
            Console.WriteLine($"{money2} * {fract3} = {money2 * fract3}");
            Console.WriteLine($"{money1} > {money2} - {money1 > money2}");
            Console.WriteLine($"{money3} <= {money2} - {money3 <= money2}");
            Console.WriteLine($"{money3} == {money4} - {money3 == money4}");
            Console.WriteLine();

            Console.WriteLine("Trapezoids:");
            List<IsoscelesTrapezoid> list = new List<IsoscelesTrapezoid>();
            var trapezoid1 = new IsoscelesTrapezoid(new Point(0, 0), new Point(1, 4), new Point(6, 4), new Point(7, 0));
            if (trapezoid1.IsIsosceles())
            {
                list.Add(trapezoid1);
                trapezoid1.PrintSideLenghts();
                trapezoid1.PrintPerimeter();
                trapezoid1.PrintSquare();
            }
            var trapezoid2 = new IsoscelesTrapezoid(new Point(1, 2), new Point(3, 6), new Point(9, 6), new Point(11, 2));
            if (trapezoid2.IsIsosceles())
            {
                list.Add(trapezoid2);
                trapezoid2.PrintSideLenghts();
                trapezoid2.PrintPerimeter();
                trapezoid2.PrintSquare();
            }
            var trapezoid3 = new IsoscelesTrapezoid(new Point(0, 0), new Point(2, 4), new Point(6, 4), new Point(10, 0));
            if (trapezoid3.IsIsosceles())
            {
                list.Add(trapezoid3);
                trapezoid3.PrintSideLenghts();
                trapezoid3.PrintPerimeter();
                trapezoid3.PrintSquare();
            }
            var trapezoid4 = new IsoscelesTrapezoid(new Point(0, 0), new Point(3, 6), new Point(6, 6), new Point(9, 0));
            if (trapezoid4.IsIsosceles())
            {
                list.Add(trapezoid4);
                trapezoid4.PrintSideLenghts();
                trapezoid4.PrintPerimeter();
                trapezoid4.PrintSquare();
            }
            Console.WriteLine();

            var count = 0;
            var sumSquare = 0d;

            foreach(var trapezoid in list)
            {
                sumSquare += trapezoid.GetSquare();
            }

            var averageSquare = sumSquare / list.Count;
            Console.WriteLine($"Average square = {averageSquare:F3}");
            
            foreach(var trapezoid in list)
            {
                if (trapezoid.GetSquare() > averageSquare)
                {
                    count++;
                }
            }

            Console.WriteLine($"A number of trapezoids with square > average square = {count}");
            Console.WriteLine();

            Console.WriteLine("Trapezoids with your coordinates:");
            list = new List<IsoscelesTrapezoid>();
            Console.WriteLine("Enter N (number of trapezoids:");
            var n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter coordinates for PointA:");
                var pointA = GetPoint();
                Console.WriteLine("Enter coordinates for PointB:");
                var pointB = GetPoint();
                Console.WriteLine("Enter coordinates for PointC:");
                var pointC = GetPoint();
                Console.WriteLine("Enter coordinates for PointD:");
                var pointD = GetPoint();

                var trapezoid = new IsoscelesTrapezoid(pointA, pointB, pointC, pointD);
                if (trapezoid.IsIsosceles())
                {
                    list.Add(trapezoid);
                    trapezoid.PrintSideLenghts();
                    trapezoid.PrintPerimeter();
                    trapezoid.PrintSquare();
                }
            }
            Console.WriteLine();

            count = 0;
            sumSquare = 0d;

            foreach (var trapezoid in list)
            {
                sumSquare += trapezoid.GetSquare();
            }

            averageSquare = sumSquare / list.Count;
            Console.WriteLine($"Average square = {averageSquare:F3}");

            foreach (var trapezoid in list)
            {
                if (trapezoid.GetSquare() > averageSquare)
                {
                    count++;
                }
            }

            Console.WriteLine($"A number of trapezoids with square > average square = {count}");
            Console.WriteLine();
        }

        public static Point GetPoint()
        {
            var point = new Point();
            Console.WriteLine("Enter X coordinate:");
            point.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate:");
            point.Y = Convert.ToInt32(Console.ReadLine());
            return point;
        }
    }
}