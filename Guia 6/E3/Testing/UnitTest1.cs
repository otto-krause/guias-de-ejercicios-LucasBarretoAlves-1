using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;
namespace Testing
{
    public class Tests
    {
        Zero zero;
        List<Arma> armasZero;
        Arma SableDeLuz;
        Arma BlasterGastado;
        Arma Katana;

        List<Maverick> mavericks;
        Maverick Roberto;
        Maverick Carlos;

        [SetUp]
        public void Setup()
        {
            SableDeLuz = new Sable(100, 1);
            BlasterGastado = new Blaster (300, 70);
            Katana = new Sable (55, 2);

            Roberto = new Maverick (20, SableDeLuz);
            Carlos = new Maverick (100, Katana);

            armasZero = new List<Arma>();
            armasZero.Add(SableDeLuz);
            armasZero.Add(BlasterGastado);
            armasZero.Add(Katana);

            zero = new Zero(armasZero);

            mavericks = new List<Maverick>();
            mavericks.Add(Roberto);
            mavericks.Add(Carlos);
        }

        [Test]
        public void SableDeLuzConPoder200()
        {
            Assert.AreEqual(200, SableDeLuz.Poder());
        }

        [Test]
        public void BlasterGastadoConPoder230()
        {
            Assert.AreEqual(230, BlasterGastado.Poder());
        }

        [Test]
        public void KatanaConPoder220()
        {
            Assert.AreEqual(220, Katana.Poder());
        }

        [Test]
        public void ArmaMasPoderosaEsBlasterGastadoYPoderDeZeroEs230()
        {
            Assert.AreEqual(230, zero.LaMasPolentosa().Poder());
        }

        [Test]
        public void ZeroPuedeVencerARoberto()
        {
            Assert.AreEqual(true, zero.LoPuedeVencer(Roberto));
        }

        [Test]
        public void ZeroPuedeVencerACarlos()
        {
            Assert.AreEqual(false, zero.LoPuedeVencer(Carlos));
        }
        [Test]
        public void ZeroLosPuedeVencer()
        {
            Assert.AreEqual(false, zero.LosPuedeVencer(mavericks));
        }
    }
}