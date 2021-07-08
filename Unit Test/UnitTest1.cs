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
            //Max String at 1st Position
            string firstValue = "Peach", secondValue = "Banana", thirdValue = "Apple";
            string expected = "Peach";
            FindMaximum find = new FindMaximum();
            string actual = find.MaximumValue(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Max String at 2nd Position
            string firstValue = "Banana", secondValue = "Peach", thirdValue = "Apple";
            string expected = "Peach";
            FindMaximum find = new FindMaximum();
            string actual = find.MaximumValue(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Max String at 3rd Position
            string firstValue = "Apple", secondValue = "Banana", thirdValue = "Peach";
            string expected = "Peach";
            FindMaximum find = new FindMaximum();
            string actual = find.MaximumValue(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }


    }
}