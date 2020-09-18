namespace Ejercicio
{
    public class Terence : Pajaro
    {
        protected int cantidadDeEnojos;
        protected int multiplicador;
        public Terence(int ira, int cantidadDeEnojos, int multiplicador)
        {
            this.ira = ira;
            this. cantidadDeEnojos = cantidadDeEnojos;
            this.multiplicador = multiplicador;
        }

        public override void SeEnoja()
        {
            this.ira *= 2;
            this.cantidadDeEnojos += 1;
        }
        public override int Fuerza()
        {
            return ira * cantidadDeEnojos * multiplicador;
        }
    }
}