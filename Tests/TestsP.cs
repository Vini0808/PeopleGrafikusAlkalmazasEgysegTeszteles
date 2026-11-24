using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleGrafikusAlkalmazasEgysegTeszteles.Tests
{
    internal class TestsP
    {
        People p = new People();

        [SetUp]
         public void SetUp()
        {
            p = new People();
            p.UjSzemely(13);
            p.UjSzemely(50);
            p.UjSzemely(70);
        }

        [Test]
        public void AtlagEletkorMukodes()
        {
            double atlag = p.AtlagEletkor(0, 99);
            double num = 13 + 50 + 70;
            Assert.That(num / 3 == atlag);
        }

        [Test]
        public void AtlagEletkorKisebbMintVart()
        {
            Assert.That(() => p.AtlagEletkor(20, 99), Throws.ArgumentException);
        }

        [Test]
        public void AtlagEletkorNagyobbMintVart()
        {
            Assert.That(() => p.AtlagEletkor(10, 60), Throws.ArgumentException);
        }

        [Test]
        public void AtlagEletkorUresLista()
        {
            p = new People();
            Assert.That(() => p.AtlagEletkor(0, 99), Throws.InvalidOperationException);
        }
    }
}
