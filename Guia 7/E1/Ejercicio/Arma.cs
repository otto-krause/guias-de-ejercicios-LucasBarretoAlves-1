namespace Ejercicio
{
    public class Arma
    {
        protected string marca;
        protected int cantidadDeBalas;

        public Arma(string marca, int cantidadDeBalas)
        {
            this.marca = marca;
            this.cantidadDeBalas = cantidadDeBalas;
        }
    }
}