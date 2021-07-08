using System;

namespace Generics_Test_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Test Maximum");
            FindMaximum find = new FindMaximum();
            int max = find.MaximumValue(20, 35, 55);
            Console.WriteLine("Maximum Integer Number : " + max);
        }
    }
}
