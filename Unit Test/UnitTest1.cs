using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics_Test_Maximum;

namespace Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Max Number at 1st Position
            int firstValue = 30, secondValue = 20, thirdValue = 10;
            int expected = 30;
            FindMaximum find = new FindMaximum();
            int actual = find.MaximumValue(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Max Number at 2nd Position
            int firstValue = 20, secondValue = 30, thirdValue = 10;
            int expected = 30;
            FindMaximum find = new FindMaximum();
            int actual = find.MaximumValue(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Max Number at 3rd Position
            int firstValue = 20, secondValue = 10, thirdValue = 30;
            int expected = 30;
            FindMaximum find = new FindMaximum();
            int actual = find.MaximumValue(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }


    }
}
