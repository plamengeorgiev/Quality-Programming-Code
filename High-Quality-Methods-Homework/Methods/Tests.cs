using System;

namespace Methods
{
    public static class Tests
    {
        static void Main()
        {
            Console.WriteLine(GeometryUtils.CalcTriangleArea(3, 4, 5));
            Console.WriteLine(PrintUtils.NumberToDigit(5));
            Console.WriteLine(MathUtils.FindMax(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine(PrintUtils.PrintNumberAsFixedPointNumber(1.3));
            Console.WriteLine(PrintUtils.PrintNumberAsPercent(0.75));
            Console.WriteLine(PrintUtils.PrintNumberAligned(2.30));
            Console.WriteLine(GeometryUtils.CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + GeometryUtils.IsLineHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Vertical? " + GeometryUtils.IsLineVertical(3, -1, 3, 2.5));

            Student peter = new Student("Peter", "Ivanov", "Sofia", "17/03/1992");
            Student stella = new Student("Stella", "Markova", "Vidin", "03/11/1993", "gamer, high results");
            Console.WriteLine("Which student is older: {0} or {1} -> {2}", peter.FirstName, stella.FirstName, StudentUtils.OlderStudentName(peter, stella));
        }
    }
}
