namespace Ejercicio
{
    public class Tecnología
    {
        protected string nombre;
        protected int potencia;
        protected int cantidadDeUsos;

        public Tecnología(string nombre, int potencia, int cantidadDeUsos)
        {
            this.nombre = nombre;
            this.potencia = potencia;
            this.cantidadDeUsos = cantidadDeUsos;
        }

        public int Poder()
        {
            return potencia / cantidadDeUsos;
        }
    }
}