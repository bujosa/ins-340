using CodeKatas;
using NUnit.Framework;

namespace NTest
{
    [TestFixture]
    class Program
    {
        [Test]
        public void EmtyString()
        {
            Calculator test1 = new Calculator();
            string expected = "0";
            Assert.AreEqual(expected, test1.Stringcalculator(""));
        
        }
        [Test]
        public void OneNumber()
        {
            Calculator test2 = new Calculator();
            string expected = "1";
            Assert.AreEqual(expected, test2.Stringcalculator("1"));
        }
        [Test]
        public void OneNumber2()
        {
            Calculator test4 = new Calculator();
            string expected = "7";
            Assert.AreEqual(expected, test4.Stringcalculator("7"));
        }
        [Test]
        public void TwoNumbers()
        {
            Calculator test3 = new Calculator();
            string expected = "3";
            Assert.AreEqual(expected, test3.Stringcalculator("1,2"));
        }
        [Test]
        public void TwoNumbersSame()
        {
            Calculator test5 = new Calculator();
            string expected = "3";
            Assert.AreEqual(expected, test5.Stringcalculator("2,1"));
        }
        [Test]
        public void ThreeNumbers()
        {
            Calculator test6 = new Calculator();
            string expected = "7";
            Assert.AreEqual(expected, test6.Stringcalculator("2,1,4"));
        }
        [Test]
        public void ThreeNumberSame()
        {
            Calculator test7 = new Calculator();
            string expected = "7";
            Assert.AreEqual(expected, test7.Stringcalculator("1,4,2"));
        }
        [Test]
        public void FourtNumbers()
        {
            Calculator test8 = new Calculator();
            string expected = "45";
            Assert.AreEqual(expected, test8.Stringcalculator("12,10,11,12"));
        }
        [Test]
        public void FourtNumberSame()
        {
            Calculator test8 = new Calculator();
            string expected = "45";
            Assert.AreEqual(expected, test8.Stringcalculator("10,11,12,12"));
        }
        [Test]
        public void DecimalOneNumber()
        {
            Calculator test8 = new Calculator();
            string expected = "1.5";
            Assert.AreEqual(expected, test8.Stringcalculator("1.5,0"));
        }
        [Test]
        public void DecimalTwoNumber()
        {
            Calculator test9 = new Calculator();
            string expected = "1.5";
            Assert.AreEqual(expected, test9.Stringcalculator("0.76,0.74"));
        }
        [Test]
        public void DecimalTwoNumberSame()
        {
            Calculator test10 = new Calculator();
            string expected = "1.5";
            Assert.AreEqual(expected, test10.Stringcalculator("0.74,0.76"));
        }
        [Test]
        public void DecimalThreeNumberSame()
        {
            Calculator test10 = new Calculator();
            string expected = "1.5";
            Assert.AreEqual(expected, test10.Stringcalculator("0.74,0.50,0.26"));
        }
        [Test]
        public void RealAndDecimalNumbers()
        {
            Calculator test11 = new Calculator();
            string expected = "1.5";
            Assert.AreEqual(expected, test11.Stringcalculator("1,0.5"));
        }
        [Test]
        public void RealAndDecimalOthers()
        {
            Calculator test13 = new Calculator();
            string expected = "55";
            Assert.AreEqual(expected, test13.Stringcalculator("10,5.25,7.75,12,15.5,4.5"));
        }
        [Test]
        public void OtherLines()
        {
            Calculator test14 = new Calculator();
            string expected = "10";
            Assert.AreEqual(expected, test14.Stringcalculator("5\n5"));
        }
        [Test]
        public void OtherLinesandcoma()
        {
            Calculator test15 = new Calculator();
            string expected = "15";
            Assert.AreEqual(expected, test15.Stringcalculator("5\n5,5"));
        }
        [Test]
        public void ValueExpected()
        {
            Calculator test16 = new Calculator();
            string expected = "Number expected but EOF found.";
            Assert.AreEqual(expected, test16.Stringcalculator("175.2,\n35"));
        }
    }
}
