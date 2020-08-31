using NUnit.Framework;
using System;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        Arma cuchillo;
        Arma nuevemm;
        Arma dagas;
        Arma subfusil;
        List<Arma> armasg;
        List<Arma> armasnoir;
        List<Spiderman> elequipo;
        SpiderTeam spiderTeam;
        Kingpin kingpin;
        Spiderman peterparker;
        Spiderman spidernoir;
        Spiderman spidergwen;
        Spiderman milesmorales;
        Traje generico;
        Traje depeter;
        Traje denoir;
        [SetUp]
        public void Setup()
        {
            cuchillo = new Arma("Tramontina", 0);
            nuevemm = new Arma ("Fiat", 15);
            dagas= new Arma("Daguimax", 0);
            subfusil = new Arma ("Ametrallamigo", 30);

            armasg = new List<Arma>(){cuchillo, nuevemm};
            armasnoir = new List<Arma>(){cuchillo, nuevemm, dagas, subfusil};

            kingpin = new Kingpin();

            generico = new Traje(10, armasg);
            depeter = new Traje (13, armasg);
            denoir = new Traje (11, armasnoir);

            peterparker = new PeterParker(depeter, 15); // fuerza 28
            spidernoir = new SpiderNoir(denoir, 10); // fuerza 25
            spidergwen = new SpiderGwen(generico, 9, 3); // fuerza 12
            milesmorales = new MilesMorales(generico, 8, 7); // fuerza 15

            elequipo = new List<Spiderman>(){peterparker, spidernoir, spidergwen, milesmorales};
            spiderTeam = new SpiderTeam(elequipo, kingpin);
        }

        [Test]
        public void PelearConKingPinYQueLaVidaQuedeEn720() // fuerza total del spiderteam = 80 // 800 - 80 = 720
        {
            spiderTeam.PelearConKingpin();
            Assert.AreEqual(720, kingpin.Vida);
        }

        [Test]
        public void DerrotarAKingPinYVuelveACasaGwen()
        {
            for (int i = 0; i < 11; i++) // Kingpin es debidamente molido a palos 11 veces, así tiene menos de 0 de vida
            {
                spiderTeam.PelearConKingpin(); 
            }
            kingpin = spiderTeam.Kingpin;
            spiderTeam.VolverACasa();
            spiderTeam.Equipo.OrderBy(spider => spider.Poder());
            Assert.AreEqual(15, spiderTeam.Equipo.First().Poder()); // se comprueba que el de 
            //menor fuerza es ahora Miles Morales con 15
        }
    }
}