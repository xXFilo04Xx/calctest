using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLibrary;

namespace CalcLibrary_Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void SommaPositiva()
        {
            int num1 = 3;
            int num2 = 4;
            int expected = 7;
            int somma = Calc.Somma(num2, num1);
            Assert.AreEqual(expected, somma);
        }
        [TestMethod]
        public void SommaNegativa()
        {
            int num1 = -3;
            int num2 = -5;
            int expected = -8;
            int somma = Calc.Somma(num2, num1);
            Assert.AreEqual(expected, somma);
        }
            
        
    }
}
