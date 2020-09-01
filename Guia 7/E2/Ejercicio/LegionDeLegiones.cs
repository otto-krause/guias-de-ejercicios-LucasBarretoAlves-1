using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class LegionDeLegiones : Participante_s
    {
        protected List<Participante_s> miembros;
        public LegionDeLegiones(List<Participante_s> miembros)
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