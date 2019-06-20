
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
            string Anagram = null;
            string Expected = null;
            string Words = null;

            Anagrams test1 = new Anagrams();

            Assert.AreEqual(Expected, test1.Find(Anagram,Words));
        
        }
        [Test]
        public void OneWords()
        {
            string Expected = "hola olah";
            string Anagram = "hola";  //  Anagrama
            string Words = "olah"; //  Conjunto de palabras 

            Anagrams test2 = new Anagrams();

            Assert.AreEqual(Expected, test2.Find(Anagram,Words));

        }
        [Test]
        public void TwoWords()
        {
            string Expected = "hola olah hlao";
            string Anagram = "hola";  //  Anagrama
            string Words = "olah hlao"; //  Conjunto de palabras 

            Anagrams test2 = new Anagrams();

            Assert.AreEqual(Expected, test2.Find(Anagram, Words));

        }
        [Test]
        public void ThreeWords()
        {
            string Expected = "hola olah hlao";
            string Anagram = "hola";  //  Anagrama
            string Words = "olah hlao vizco"; //  Conjunto de palabras 

            Anagrams test3 = new Anagrams();

            Assert.AreEqual(Expected, test3.Find(Anagram, Words));

        }
        [Test]
        public void FiveWords()
        {
            string Expected = "hola hlao";
            string Anagram = "hola";  //  Anagrama
            string Words = "camicasegrande barbaro budo hlao vizco"; //  Conjunto de palabras 

            Anagrams test2 = new Anagrams();

            Assert.AreEqual(Expected, test2.Find(Anagram, Words));

        }
        [Test]
        public void TestWords()
        {
            string Expected = "crepitus cuprites pictures piecrust";
            string Anagram = "crepitus";  //  Anagrama
            string Words = "hamilton cuprites pictures piecrust"; //  Conjunto de palabras 

            Anagrams test2 = new Anagrams();

            Assert.AreEqual(Expected, test2.Find(Anagram, Words));

        }



    }
}
