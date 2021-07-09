using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics_Test_Maximum;

namespace MaxUsingGenericsTest
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
        [TestMethod]
        public void TestMethod1()
        {
            //Max Integer at 1st Position
            int[] intArray = { 30, 20, 10 };
            int expected = 30;
            FindMaximum<int> find = new FindMaximum<int>(intArray);
            int actual = find.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Max float at 2nd Position
            float[] floatArray = { 10.5f, 30.5f, 20.5f };
            float expected = 30.5f;
            FindMaximum<float> find = new FindMaximum<float>(floatArray);
            float actual = find.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Max String at 3rd Position
            string[] strArray = { "Apple", "Banana", "Peach" };
            string expected = "Peach";
            FindMaximum<string> find = new FindMaximum<string>(strArray);
            string actual = find.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }


    }
}