using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 0, b = 0, c = 0;
            string expResult = "любое число";
            Class1 kv = new Class1(a, b, c);
            kv.Decision();
            string actResult = kv.ToString();
            Assert.AreEqual(expResult, actResult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 1, b = 1, c = 1;
            string expResult = "нет корней";
            Class1 kv = new Class1(a, b, c);
            kv.Decision();
            string actResult = kv.ToString();
            Assert.AreEqual(expResult, actResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 1, b = 1, c = -2;
            string expResult = "x1=1   x2=-2";
            Class1 kv = new Class1(a, b, c);
            kv.Decision();
            string actResult = kv.ToString();
            Assert.AreEqual(expResult, actResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double a = 0, b = 1, c = -1;
            string expResult = "x=1";
            Class1 kv = new Class1(a, b, c);
            kv.Decision();
            string actResult = kv.ToString();
            Assert.AreEqual(expResult, actResult);
        }
    }
}
