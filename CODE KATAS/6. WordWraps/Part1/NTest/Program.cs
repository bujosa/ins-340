
using CodeKatas;
using NUnit.Framework;

namespace NTest
{
    [TestFixture]
    class Program
    {
        [Test]
        public void OneWords()
        {
            Wrapper test1 = new Wrapper();
            string expected = "ho la";
            string Push = "hola";
            int x = 2;
            Assert.AreEqual(expected, test1.WrapWords(Push, x));
        }
        [Test]
        public void ThreeWords()
        {
            Wrapper test1 = new Wrapper();
            string expected = "hola vict or quer ido";
            string Push = "hola victor querido";
            int x = 4; // Representa maximo de letras unidas a una palabra 
            Assert.AreEqual(expected, test1.WrapWords(Push, x));
        }
        [Test]
        public void SeparetedLines()
        {
            Wrapper test1 = new Wrapper();
            string expected = "hola victor querido amigo\n mio.";
            string Push = "hola victor querido amigo mio.";
            int x = 4; // Columna en una linea de texto maximo.
            Assert.AreEqual(expected, test1.WrapLines(Push, x));
        }



    }
}
