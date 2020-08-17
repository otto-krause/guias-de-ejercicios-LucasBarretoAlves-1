namespace Ejercicio
{
    public class Ingrediente
    {
        protected int calorias;
        public int Calorias {get => calorias;}

        public Ingrediente(int calorias)
        {
            this.calorias = calorias;
        }
    }
}