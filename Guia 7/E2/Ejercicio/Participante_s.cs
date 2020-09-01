namespace Ejercicio
{
    public abstract class Participante_s
    {
        protected int caramelos;
        public int Caramelos {get => caramelos;}

        public abstract int CapacidadDeAsustar();
        public abstract void Asustar(Adulto adulto);
        public void RecibirCaramelos(int cantidad)
        {
            caramelos += cantidad;
        }
        public bool MasDe15Caramelos()
        {
            return caramelos > 15;
        }
    }
}