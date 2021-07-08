using System;

namespace Generics_Test_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Test Maximum");
            FindMaximum find = new FindMaximum();
            string max = find.MaximumValue("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum String : " + max);
        }
    }
}
