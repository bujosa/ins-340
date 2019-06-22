
using CodeKatas;
using NUnit.Framework;

namespace NTest
{
    [TestFixture]
    class Program
    {
        [Test]
        public void EmptyString()
        {
            string Anagram = null;
            string Expected = null;
            string Words = null;

            Anagrams test1 = new Anagrams();

            Assert.AreEqual(Expected, test1.Find(Anagram, Words));
        }
        [Test]
        public void OneWords()
        {
            string Anagram ="mash";
            string Expected = "mash hasm";
            string Words = "hasm";

            Anagrams test2 = new Anagrams();

            Assert.AreEqual(Expected, test2.Find(Anagram, Words));
        }
        
        [Test]
        public void TwoWords()
        {
            string Anagram = "kinship";
            string Expected = "kinship pinkish";
            string rout = @"C:\Users\David\Desktop\Anagrams.txt";
            Anagrams test3 = new Anagrams();

            Assert.AreEqual(Expected, test3.Finder(Anagram, rout));
        }
        [Test]
        public void SixWords_in_Rout()
        {
            string Anagram = "enlist";
            string Expected = "enlist elints inlets listen silent tinsel";
            string rout = @"C:\Users\David\Desktop\Anagrams.txt";
            Anagrams test4 = new Anagrams();

            Assert.AreEqual(Expected, test4.Finder(Anagram, rout));
        }
        [Test]
        public void ThreeWords_in_Rout()
        {
            string Anagram = "boaster";
            string Expected = "boaster boaters borates rebatos sorbate";
            string rout = @"C:\Users\David\Desktop\Anagrams.txt";
            Anagrams test5 = new Anagrams();

            Assert.AreEqual(Expected, test5.Finder(Anagram, rout));
        }




    }
}
