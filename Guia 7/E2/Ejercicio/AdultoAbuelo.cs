namespace Ejercicio
{
    public class AdultoAbuelo : Adulto
    {
        public AdultoAbuelo(int tolerancia)
        {
            this.tolerancia = tolerancia;
        }

        public override int IntentoDeSusto(int capacidad, bool masde15)
        {
            return tolerancia / 4;
        }
    }
}