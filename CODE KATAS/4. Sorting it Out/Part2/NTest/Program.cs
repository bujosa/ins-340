
using CodeKatas;
using NUnit.Framework;

namespace NTest
{
    [TestFixture]
    class Program
    {
        [Test]
        public void EmtyNumber()
        {
            int[] Expected = { };
            int[] Push = { };

            Sorting test = new Sorting();
            Assert.AreEqual(Expected, test.Sort(Push));
        }
        [Test]
        public void OneNumber()
        {
            int[] Expected = {25 };
            int[] Push = { 25};

            Sorting test = new Sorting();
            Assert.AreEqual(Expected, test.Sort(Push));
        }
        [Test]
        public void TwoNumbers()
        {
            int[] Expected = { 25, 35 };
            int[] Push = { 35, 25 };

            Sorting test = new Sorting();
            Assert.AreEqual(Expected, test.Sort(Push));
        }
        [Test]
        public void ThreeNumbers()
        {
            int[] Expected = { 25, 35, 45 };
            int[] Push = { 35, 25, 45 };

            Sorting test = new Sorting();
            Assert.AreEqual(Expected, test.Sort(Push));
        }

        [Test]
        public void FourtNumbers()
        {
            int[] Expected = { 1, 25, 35, 45 };
            int[] Push = { 35, 25, 45, 1 };

            Sorting test = new Sorting();
            Assert.AreEqual(Expected, test.Sort(Push));
        }


        [Test]
        public void TwentyNumbers()
        {
            int[] Expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 ,16 ,17 ,18 ,19, 20 };
            int[] Push = { 20, 10, 19, 9, 8, 18, 17, 7, 16, 6, 14, 13, 12, 11, 2, 3, 4, 5, 15, 1 };

            Sorting test = new Sorting();
            Assert.AreEqual(Expected, test.Sort(Push));
        }

        [Test]
        public void TwentyNumbersSorted()
        {
            int[] Expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] Push = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Sorting test = new Sorting();
            Assert.AreEqual(Expected, test.Sort(Push));
        }
        [Test]
        public void OneWords()
        {
            string Expected = "ABCDEF";
            string Push = "FECDAB";
            Sorting test = new Sorting();
            Assert.AreEqual(Expected, test.Sort(Push));
        }
    
    [Test]
    public void OneWordsTwo()
    {
        string Expected = "ABCDEFGHI";
        string Push = "FECDAB IGH";
        Sorting test = new Sorting();
        Assert.AreEqual(Expected, test.Sort(Push));
    }
    [Test]
    public void TwoWords()
    {
            string Expected = "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy";
            string Push = "when not studying nuclear physics, bambi likes to play beach volleyball.";
            Sorting test = new Sorting();
            Assert.AreEqual(Expected, test.Sort(Push));
    }





    }
}
