
using CodeKatas;
using NUnit.Framework;

// STRING CALCULATOR

namespace NTest
{
    [TestFixture]
    class Program
    {
        

        [Test]
        public void EmtyString()
        {
            Calculator Dato = new Calculator();
            string firstvalue = "0";
            Assert.AreEqual(firstvalue, Dato.StringCalculator(""));
        
        }
        [Test]
        public void OneNumber()
        {
            Calculator Dato2 = new Calculator();
            string secondvalue = "5";
            Assert.AreEqual(secondvalue, Dato2.StringCalculator("5"));
        }
        [Test]
        public void TwoNumbers()
        {
            Calculator Dato3 = new Calculator();
            string Value = "9";
            Assert.AreEqual(Value, Dato3.StringCalculator("7,2"));
        }
        [Test]
        public void TwoNumbersSame()
        {
            Calculator Dato4 = new Calculator();
            string Value = "9";
            Assert.AreEqual(Value, Dato4.StringCalculator("7,2"));
        }
        [Test]
        public void ThreeNumbers()
        {
            Calculator Dato5 = new Calculator();
            string Value = "9";
            Assert.AreEqual(Value, Dato5.StringCalculator("4,2,3"));
        }
        [Test]
        public void DecimalNumbers_TwoNumber()
        {
            Calculator Dato6 = new Calculator();
            string Value = "5.25";
            Assert.AreEqual(Value, Dato6.StringCalculator("3.12,2.13"));
        }
        [Test]
        public void DecimalNumbers_ThreeNumber()
        {
            Calculator Dato7 = new Calculator();
            string Value = "5.25";
            Assert.AreEqual(Value, Dato7.StringCalculator("2.06,2.13,1.06"));
        }

    }
}
