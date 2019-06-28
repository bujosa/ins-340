
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
            string expected = "Pala bra";
            string push = "Palabra";
            int x = 4;
            Assert.AreEqual(expected, test1.WrapWords(push, x));
        }
        [Test]
        public void OneWordsLess()
        {

            Wrapper test1 = new Wrapper();
            string expected = "Palabra";
            string push = "Palabra";
            int x = 8;
            Assert.AreEqual(expected, test1.WrapWords(push, x));
        }
        [Test]
        public void TwoWords()
        {

            Wrapper test1 = new Wrapper();
            string expected = "Pal abr a Lov es";
            string push = "Palabra Loves";
            int x = 3; // Cantidad de letras por palabra
            Assert.AreEqual(expected, test1.WrapWords(push, x));
        }
        [Test]
        public void JumpLines()
        {

            Wrapper test1 = new Wrapper();
            string expected = "Palabra Loves dios\n padre";
            string push = "Palabra Loves dios padre";
            int x = 3; // Cantidad de columna en una linea
            Assert.AreEqual(expected, test1.WrapLines(push, x));
        }
        [Test]
        public void JumpTwoLines()
        {

            Wrapper test1 = new Wrapper();
            string expected = "Palabra Loves\n dios padre\n amado";
            string push = "Palabra Loves dios padre amado";
            int x = 2; // Cantidad de columna en una linea
            Assert.AreEqual(expected, test1.WrapLines(push, x));
        }



    }
}
