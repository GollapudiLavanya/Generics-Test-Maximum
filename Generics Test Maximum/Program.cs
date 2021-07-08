using System;

namespace Generics_Test_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Test Maximum");
            FindMaximum find = new FindMaximum();
            float max = find.MaximumValue(21.5f, 11.5f, 18.5f);
            Console.WriteLine("Maximum Integer Number : " + max);
        }
    }
}
