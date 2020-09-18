namespace Ejercicio
{
    public class Chuck : Pajaro
    {
        protected int velocidadActual;
        public Chuck(int ira, int velocidadActual)
        {
            this.ira = ira;
            this.velocidadActual = velocidadActual;
        }

        public override int Fuerza()
        {
            return velocidadActual <= 80 ? 150 : (velocidadActual-80)*5 + 150;
        }

        public override void SeEnoja()
        {
            this.velocidadActual *= 2;
        }


    }
}