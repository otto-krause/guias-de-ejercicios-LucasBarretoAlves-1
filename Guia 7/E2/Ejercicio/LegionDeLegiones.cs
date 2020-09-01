namespace Ejercicio
{
    public class LegionDeLegiones : Participante_s
    {
        protected List<Participante_s> miembros;
        public Legion(List<Participante_s> miembros)
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
            miembros.Max(miembro => miembro.CapacidadDeAsustar()).RecibirCaramelos(adulto.IntentoDeSusto(CapacidadDeAsustar(), MasDe15Caramelos()));
        }

    }
}