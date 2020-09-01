using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Legion : Participante_s
    {
        protected List<Niño> miembros;

        public Legion(List<Niño> miembros)
        {
            this.miembros = miembros;
            this.caramelos = miembros.Sum(miembro => miembro.Caramelos);
        }


        public override int CapacidadDeAsustar()
        {
            return miembros.Sum(miembro => miembro.CapacidadDeAsustar());
        }

        public override void Asustar(Adulto adulto)
        {
            miembros.OrderByDescending(miembro => miembro.CapacidadDeAsustar()).First().RecibirCaramelos(adulto.IntentoDeSusto(CapacidadDeAsustar(), MasDe15Caramelos()));
        }


    }
}