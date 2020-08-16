using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Robin : Titan
    {
        List<Arma> arsenal;
        public List<Arma> Arsenal {get => arsenal;}
        public Robin() 
        {
            this.tristeza = 10;
            this.arsenal = new List<Arma>();
            Arma bastonMetal = new Arma(15, 10);
            Arma bombasDeHumo = new Arma (14, 89);

            arsenal.Add(bastonMetal);
            arsenal.Add(bombasDeHumo);
        }
        public override void LlorarPorRobocop()
        {
            tristeza += 6;
        }

        public override void ComerPizza()
        {
            tristeza-=1;
        }
        
        public override bool EstaTriste()
        {
            return arsenal.Max(Arma => Arma.Fuerza()) < 100 && tristeza > 25;
        }

        public override int Poder()
        {
            return arsenal.Max(Arma => Arma.Fuerza()) - tristeza;
        }
    }
}