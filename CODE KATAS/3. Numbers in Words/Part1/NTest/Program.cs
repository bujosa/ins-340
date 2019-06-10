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
           string Expected = "Cero";
            int data = 0;
            Converted test1 = new Converted();
           Assert.AreEqual(Expected, test1.Chance(data));  
        }
        [Test]
        public void One()
        {
            string Expected = "One ";
            int data = 1;
            Converted test1 = new Converted();
            Assert.AreEqual(Expected, test1.Chance(data));

        }
        [Test]
        public void Two()
        {
            string Expected = "Two ";
            int data = 2;
            Converted test1 = new Converted();
            Assert.AreEqual(Expected, test1.Chance(data));
        }
        [Test]
        public void Ten()
        {
            string Expected = "Ten ";
            int data = 10;
            Converted test1 = new Converted();
            Assert.AreEqual(Expected, test1.Chance(data));
        }
        [Test]
        public void Eleven()
        { 
            string Expected = "Eleven ";
            int data = 11;
            Converted test1 = new Converted();
            Assert.AreEqual(Expected, test1.Chance(data));
        }
        [Test]
        public void Nineteen()
        {
            string Expected = "Nineteen ";
            int data = 19;
            Converted test1 = new Converted();
            Assert.AreEqual(Expected, test1.Chance(data));
        }
        [Test]1
        public void Ninety_Five()
        {
            string Expected = "Ninety Five ";
            int data = 95;
            Converted test1 = new Converted();
            Assert.AreEqual(Expected, test1.Chance(data));
        }
        [Test]
        public void Twenty_Four()
        {
            string Expected = "Twenty Four ";
            int data = 24;
            Converted test1 = new Converted();
            Assert.AreEqual(Expected, test1.Chance(data));
        }


    }
}
