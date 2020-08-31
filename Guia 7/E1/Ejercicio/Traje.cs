using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Traje
    {
        protected int resistencia;
        public int Resistencia {get => resistencia;}
        protected List<Arma> armas;

        public Traje(int resistencia, List<Arma> arsenal)
        {
            this.resistencia = resistencia;
            this.armas = arsenal;
        }

        public int CantidadDeArmas()
        {
            return armas.Count();
        }
    }
}