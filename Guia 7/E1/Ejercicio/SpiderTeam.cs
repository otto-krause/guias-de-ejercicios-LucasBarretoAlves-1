using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class SpiderTeam
    {
        protected List<Spiderman> equipo;
        public List<Spiderman> Equipo {get => equipo;}
        protected Kingpin kingpin;
        public Kingpin Kingpin {get => kingpin;}

        public SpiderTeam(List<Spiderman> equipo, Kingpin kingpin)
        {
            this.equipo = equipo;
            this.kingpin = kingpin;
        }

        public void PelearConKingpin ()
        {
            equipo.ForEach(spider => spider.Atacar(kingpin));
        }

        public void VolverACasa ()
        {
            if (kingpin.FueVencido())
            {
                
                equipo.OrderByDescending(spider => spider.Poder()).ToList();
                equipo.RemoveAt(3);
                
            }
            else
            {
                Console.WriteLine("Error\n");
            }
        }
        
        public int Fuerza()
        {
            return equipo.Sum(spider => spider.Poder());
        }
    }
}