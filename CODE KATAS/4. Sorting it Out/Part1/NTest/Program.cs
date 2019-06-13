
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
            int[] Expected = {  };
            int[] Push = {  };
            Sorting data = new Sorting();
            Assert.AreEqual(Expected, data.Sorted(Push));
        }
        [Test]
        public void OneSorted()
        {
            int[] Expected = {25 };
            int[] Push = { 25};
            Sorting data = new Sorting();
            Assert.AreEqual(Expected, data.Sorted(Push));
        }
        [Test]
        public void TwoSorted()
        {
            int[] Expected = { 25, 35 };
            int[] Push = { 35, 25 };
            Sorting data = new Sorting();
            Assert.AreEqual(Expected, data.Sorted(Push));
        }
        [Test]
        public void ThreeSorted()
        {
            int[] Expected = { 1, 25, 35 };
            int[] Push = { 35, 25, 1 };
            Sorting data = new Sorting();
            Assert.AreEqual(Expected, data.Sorted(Push));
        }
        [Test]
        public void TwentySorted()
        {
            int[] Expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] Push = { 20, 5, 1, 4, 3, 2, 7, 19, 6, 17, 16, 8, 10, 9, 11, 15, 13, 12, 14, 18 };
            Sorting data = new Sorting();
            Assert.AreEqual(Expected, data.Sorted(Push));
        }
        [Test]
        public void Sorted()
        {
            int[] Expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] Push = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Sorting data = new Sorting();
            Assert.AreEqual(Expected, data.Sorted(Push));
        }


    }
}
