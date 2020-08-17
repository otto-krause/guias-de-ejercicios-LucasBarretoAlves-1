namespace Ejercicio
{
    public class Carpe : Varita
    {
        public Carpe()
        {
            this.potencia = 5; 
        }
        public override int TiempoReceta(int cantidad)
        {
            return cantidad/potencia;
        }
    }
}