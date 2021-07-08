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
            float firstValue = 20.0f, secondValue = 18.5f, thirdValue = 11.0f;
            float expected = 20.0f;
            FindMaximum find = new FindMaximum();
            float actual = find.MaximumValue(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Max Number at 2nd Position
            float firstValue = 21.5f, secondValue = 15.5f, thirdValue = 11.5f;
            float expected = 21.5f;
            FindMaximum find = new FindMaximum();
            float actual = find.MaximumValue(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Max Number at 3rd Position
            float firstValue = 31.5f, secondValue = 20.5f, thirdValue = 30.5f;
            float expected = 31.5f;
            FindMaximum find = new FindMaximum();
            float actual = find.MaximumValue(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }


    }
}
