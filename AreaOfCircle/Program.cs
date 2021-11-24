using System;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius:");
            string input = Console.ReadLine();
            double radius = double.Parse(input);
            double circumference = Circle.Circumference(radius);
            Console.WriteLine("Please enter miles per gallon");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("It will take " + circumference/miles + "gallons of gas to go around circles");


        }
    }
}
