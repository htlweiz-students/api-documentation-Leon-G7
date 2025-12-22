using System;
using AverageCalculator;

class Program
{
    static void Main()
    {
        Class1 number = new Class1();

        number.add(10);
        number.add(20);

        Console.WriteLine(number.getAverage());
    }
}
