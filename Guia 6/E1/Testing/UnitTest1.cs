using NUnit.Framework;
using Ejercicio;

namespace Testing
{
    public class Tests
    {
        Titan robin;
        Titan hulkjr;
        Titan raven;
        [SetUp]
        public void Setup()
        {
            robin = new Robin();
            hulkjr = new ChicoBestia();
            raven = new Raven();
        }

        [Test]
        public void RavenCome4PorcionesdePizzaEstaTriste()
        {
            raven.ComerPizza();
            Assert.AreEqual(true, raven.EstaTriste());
        }

        [Test]
        public void ChicoBestiaComePizzaConocerPoder()
        {
            hulkjr.ComerPizza();
            Assert.AreEqual(871, hulkjr.Poder());
        }

        [Test]
        public void PoderDelBastonDeMetalEs620()
        {
            Assert.AreEqual(620, robin.Poder() + 10);
        }

        [Test]
        public void ChicoBestiaComePizzaEsRavenMayor()
        {
            hulkjr.ComerPizza();
            Assert.AreEqual(false, (raven.Poder()>robin.Poder() && raven.Poder() > hulkjr.Poder()));
        }

        [Test]
        public void ChicoBestiaLloraPorRobocopConocerTristeza()
        {
            hulkjr.LlorarPorRobocop();
            Assert.AreEqual(0, hulkjr.Tristeza);
        }

        [Test]
        public void RobinLloraDosVecesPorRobocopConocerPoder()
        {
            robin.LlorarPorRobocop();
            robin.LlorarPorRobocop();
            Assert.AreEqual(598, robin.Poder());

        }

        [Test]
        public void RavenLloraPorRobocopEstaTriste()
        {
            raven.LlorarPorRobocop();
            Assert.AreEqual(false, raven.EstaTriste());
        }
    }
}