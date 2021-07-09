using System;

namespace Generics_Test_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Generics Test Maximum \n");

            int[] intArray = { 926, 233, 172, 457, 123 };
            float[] floatArray = { 21.5f, 11.5f, 18.23f, 07.61f, 99.23f };
            string[] stringArray = { "Apple", "Peach", "Banana", "Grapes", "Guava" };

            FindMaximum<int> find1 = new FindMaximum<int>(intArray);
            FindMaximum<float> find2 = new FindMaximum<float>(floatArray);
            FindMaximum<string> find3 = new FindMaximum<string>(stringArray);

            find1.PrintMaxValue();
            find2.PrintMaxValue();
            find3.PrintMaxValue();

        }
    }
}