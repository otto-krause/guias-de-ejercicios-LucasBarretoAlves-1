using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        Mago harrypostre;
        [SetUp]
        public void Setup()
        {
            harrypostre = new Mago();
        }

        [Test]
        public void TodasLasRecetasSonDeGordo()
        {
            Assert.AreEqual(false, harrypostre.RecetasConocidas.All(receta => receta.EsDeGordo()));
        }

        [Test]
        public void AlgunaRecetaEsRapida()
        {
            Assert.AreEqual(false, harrypostre.RecetasConocidas.Any(receta => receta.EsRapida()));
        }

        [Test]
        public void SaberSiHarryEsUnLento()
        {
            Assert.AreEqual(false, harrypostre.EsUnLento());
        }

        [Test]
        public void SaberSiHarryNoSeCuida()
        {
            Assert.AreEqual(false, harrypostre.NoSeCuida());
        }
    }
}