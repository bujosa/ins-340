using CodeKatas;
using NUnit.Framework;

namespace NTest
{
    [TestFixture]
    class Program
    {
        [Test]
        public void Cero()
        {
            Converted Test1 = new Converted();
            string expected = "Cero";
            int data = 0;
           Assert.AreEqual(expected, Test1.Chance(data));  
        }

        [Test]
        public void One()
        {
            Converted Test1 = new Converted();
            string expected = "One ";
            int data = 1;
            Assert.AreEqual(expected, Test1.Chance(data));
        }

        [Test]
        public void Five()
        {
            Converted Test1 = new Converted();
            string expected = "Five ";
            int data = 5;
            Assert.AreEqual(expected, Test1.Chance(data));
        }
        [Test]
        public void Ten()
        {
            Converted Test1 = new Converted();
            string expected = "Ten ";
            int data = 10;
            Assert.AreEqual(expected, Test1.Chance(data));
        }
        [Test]
        public void Nineteen()
        {
            Converted Test1 = new Converted();
            string expected = "Nineteen ";
            int data = 19;
            Assert.AreEqual(expected, Test1.Chance(data));
        }
        [Test]
        public void Twenty_Eight()
        {
            Converted Test1 = new Converted();
            string expected = "Twenty Eight ";
            int data = 28;
            Assert.AreEqual(expected, Test1.Chance(data));
        }
        [Test]
        public void Fouty_Five()
        {
            Converted Test1 = new Converted();
            string expected = "Fouty Five ";
            int data = 45;
            Assert.AreEqual(expected, Test1.Chance(data));
        }
        [Test]
        public void Ninety_Nine()
        {
            Converted Test1 = new Converted();
            string expected = "Ninety Nine ";
            int data = 99;
            Assert.AreEqual(expected, Test1.Chance(data));
        }
        [Test]
        public void One_hundred()
        {
            Converted Test1 = new Converted();
            string expected = "One hundred ";
            int data = 100;
            Assert.AreEqual(expected, Test1.Chance(data));
        }
        [Test]
        public void Five_Hundred_Ninety_Nine()
        {
            Converted Test1 = new Converted();
            string expected = "Five hundred Ninety Nine ";
            int data = 599;
            Assert.AreEqual(expected, Test1.Chance(data));
        }
        [Test]
        public void One_thousand()
        {
            Converted Test1 = new Converted();
            string expected = "One thousand ";
            int data = 1000;
            Assert.AreEqual(expected, Test1.Chance(data));
        }
        [Test]
        public void Nine_hundred_Ninety_Nine_thousand_Nine_houndred_Ninety_Nine()
        {
            Converted Test1 = new Converted();
            string expected = "Nine hundred Ninety Nine thousand Nine hundred Ninety Nine ";
            int data = 999999;
            Assert.AreEqual(expected, Test1.Chance(data));
        }






    }
}
