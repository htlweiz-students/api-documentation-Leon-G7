using System;
using AverageCalculator;

class Program
{
    static void Main()
    {
        AverageCalculator.AverageCalculator number = new ();

        number.Add(10);
        number.Add(30);

        Console.WriteLine(number.GetElements());
    }
}
