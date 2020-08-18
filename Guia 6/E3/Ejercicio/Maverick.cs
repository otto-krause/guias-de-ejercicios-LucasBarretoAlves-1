using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Maverick
    {
        protected int destreza;
        protected Arma arma;
        public Maverick(int destreza, Arma arma)
        {
            this.destreza = destreza;
            this.arma = arma;
        }

        public int Fuerza()
        {
            return destreza + arma.Poder();
        }

        public bool EsDebil()
        {
            return this.Fuerza() <= 200;
        }
    }
}