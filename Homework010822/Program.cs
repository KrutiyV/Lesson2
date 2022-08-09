using System;

class Homework
{
    public static void Main(string[] args) 
    {
        // -6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15

        int x = 7;

        double ex1 = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
        Console.WriteLine($"Answer is: {ex1}");

        // abs(x)*sin(x)

        int xx = 10;

        double ex2 = Math.Abs(xx) * Math.Sin(xx);
        Console.WriteLine($"Answer is: {ex2}");

        // 2*pi*x

        int xxx = 6;

        double ex3 = 2 * Math.PI * xxx;
        Console.WriteLine($"Answer is: {ex3}");

        // max(x, y)

        int z = 10;
        int y = 5;

        int ex4 = Math.Max(z, y);
        Console.WriteLine($"Answer is: {ex4}");


    }
}
//checked
