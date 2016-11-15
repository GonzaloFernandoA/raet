using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{

    [TestFixture]
    public class PalabraTest
    {
        private Palabra palabra;

        [TestFixtureSetUp]
        public void setup()
        {
            palabra = new Palabra();
        }

        [Test]
        public void emptyString()
        {
            Palabra pal = new Palabra("");
            Assert.AreEqual("", palabra.Reverse());
        }

        [Test]
        public void Blank()
        {
            Assert.AreEqual(" ", palabra.Reverse(" "));
        }


        [Test]
        public void singleWord()
        {
            Assert.AreEqual("abc", palabra.Reverse("cba"));
        }

    }
}
