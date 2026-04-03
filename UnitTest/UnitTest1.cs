using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Fizika.Function;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Massa1()
        {
            double a = Massa("1", "1", "1", 6000);
            double b = 6000;
            Assert.AreEqual(a,b,b*0.001);
        }
        [TestMethod]
        public void TestMethod_Massa2()
        {
            double a = Massa("1", "1", "1", Lead);
            double b = 11300;
            Assert.AreEqual(a, b, b * 0.001);
        }
        [TestMethod]
        public void TestMethod_Massa3()
        {
            double a = Massa("1", "1", "1", Ice);
            double b = 900;
            Assert.AreEqual(a, b, b * 0.001);
        }
        [TestMethod]
        public void TestMethod_Massa4()
        {
            double a = Massa("1", "1", "1", Iron);
            double b = 7800;
            Assert.AreEqual(a, b, b * 0.001);
        }
        [TestMethod]
        public void TestMethod_Massa5()
        {
            double a = Massa("1", "1", "1", Tin);
            double b = 7300;
            Assert.AreEqual(a, b, b * 0.001);
        }
        [TestMethod]
        public void TestMethod_Massa6()
        {
            double a = Massa("0,1", "0,1", "0,1", Iron);
            double b = 7.8;
            Assert.AreEqual(a, b, b * 0.001);
        }
        [TestMethod]
        public void TestMethod_Fields1()
        {
            Assert.IsTrue(fields("0,1", "0,1", "0,1"));
        }
        [TestMethod]
        public void TestMethod_Fields2()
        {
            Assert.IsTrue(fields("1", "1", "1"));
        }
        [TestMethod]
        public void TestMethod_Fields3()
        {
            Assert.IsTrue(fields("-1", "-1", "-1"));
        }
        [TestMethod]
        public void TestMethod_Fields4()
        {
            Assert.IsFalse(fields("a", "a", "a"));
        }
        [TestMethod]
        public void TestMethod_Fields5()
        {
            Assert.IsFalse(fields("1", "1", "a"));
        }
        [TestMethod]
        public void TestMethod_Fields6()
        {
            Assert.IsFalse(fields("a", "1", "1"));
        }
        [TestMethod]
        public void TestMethod_Fields7()
        {
            Assert.IsFalse(fields("1", "a", "1"));
        }
        [TestMethod]
        public void TestMethod_Fields8()
        {
            Assert.IsFalse(fields("", "", ""));
        }
        [TestMethod]
        public void TestMethod_Fields9()
        {
            Assert.IsFalse(fields(" ", " ", " "));
        }
        [TestMethod]
        public void TestMethod_Fields_Massa()
        {
            double a = Massa("1", "1", " ", Tin);
            double b = 0;
            Assert.AreEqual(a, b, b * 0.001);
        }
        [TestMethod]
        public void TestMethod_Fields_Massa2()
        {
            double a = Massa("1", "1", "-1", Tin);
            double b = 0;
            Assert.AreEqual(a, b, b * 0.001);
        }
    }
}
