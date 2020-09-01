namespace Ejercicio
{
    public class AdultoComun : Adulto
    {
        protected int cantidadMasDe15;
        public AdultoComun()
        {
            this.cantidadMasDe15 = 0;
            this.tolerancia = 0;
        }

        protected int Tolerancia()
        {
            return this.tolerancia = 10 * cantidadMasDe15;
        }

        public override int IntentoDeSusto(int capacidad, bool masde15)
        {
            int caramelosDados = 0;

            caramelosDados = Tolerancia() < capacidad ? Tolerancia() / 2 : 0;
            cantidadMasDe15 = masde15 ? cantidadMasDe15 + 1 : cantidadMasDe15;

            return caramelosDados;
        }

    }
}