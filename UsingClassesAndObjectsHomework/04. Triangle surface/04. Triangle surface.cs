using System;

public class TriangleSurface
{
    public static void Main()
    {
        /*•	Write methods that calculate the surface of a triangle by given:
            o	Side and an altitude to it;
            o	Three sides;
            o	Two sides and an angle between them;
          •	Use System.Math.*/

        Console.WriteLine("Please choose one of the following options for calculating triangle surface: ");
        Console.WriteLine();
        Console.WriteLine("1: Side and an altitude to it");
        Console.WriteLine("2: Three sides");
        Console.WriteLine("3: Two sides and an angle between them");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Please enter the base length: ");
                int side = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height: ");
                int height = int.Parse(Console.ReadLine());

                AreaBySideAndAltitude(side, height);
                break;
            case "2":
                Console.WriteLine("Please enter the sides of the triangle: ");
                Console.WriteLine("First side = ");
                int firstSide = int.Parse(Console.ReadLine());

                Console.WriteLine("Second side = ");
                int secondSide = int.Parse(Console.ReadLine());

                Console.WriteLine("Third side = ");
                int thirdSide = int.Parse(Console.ReadLine());

                TriangleAreaByThreeSides(firstSide, secondSide, thirdSide);
                break;
            case "3":
                Console.WriteLine("First side = ");
                int sideA = int.Parse(Console.ReadLine());

                Console.WriteLine("Second side = ");
                int sideB = int.Parse(Console.ReadLine());

                Console.WriteLine("Angle between sides = ");
                int angle = int.Parse(Console.ReadLine());

                AreaByTwoSidesAndAngle(sideA, sideB, angle);
                break;
        }
    }

    public static void AreaByTwoSidesAndAngle(int sideA, int sideB, int angle)
    {
        double area = (sideA * sideB * Math.Sin(angle)) / 2.0;
        Console.WriteLine("The surface of the triangle is {0}.", area);
    }

    public static void TriangleAreaByThreeSides(int a, int b, int c)
    {

        double p = (a + b + c) / 2.0;
        double surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine("The surface of the triangle is {0}.", surface);
    }

    public static void AreaBySideAndAltitude(int side, int altitude)
    {
        double surface = (side * altitude) / 2.0;
        Console.WriteLine("The surface of the triangle is {0}.", surface);
    }
}

