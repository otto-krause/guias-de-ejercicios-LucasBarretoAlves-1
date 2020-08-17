namespace Ejercicio
{
    public class Acebo : Varita
    {
        public Acebo()
        {
            this.potencia = 3; 
        }
        public override int TiempoReceta(int cantidad)
        {
            return cantidad + potencia;
        }
    }
}