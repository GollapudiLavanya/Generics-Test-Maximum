using System;

namespace Generics_Test_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Generics Test Maximum \n");

            int[] intArray = { 534, 733, 832, 747, 638 };
            float[] floatArray = { 19.2f, 54.4f, 9.32f, 45.5f, 8.78f };
            string[] stringArray = { "Apple", "Peach", "Banana", "Strawberry", "Blueberrie" };

            FindMaximum<int> find1 = new FindMaximum<int>(intArray);
            FindMaximum<float> find2 = new FindMaximum<float>(floatArray);
            FindMaximum<string> find3 = new FindMaximum<string>(stringArray);

            Console.WriteLine("Maximum Integer Number : " + find1.FindMaxValue());
            Console.WriteLine("Maximum Float Number : " + find2.FindMaxValue());
            Console.WriteLine("Maximum String : " + find3.FindMaxValue());
        }
    }
}
