namespace E2
{
    public class Plomero : Contratista
    {
        private int precioHora;
        public int PrecioHora {get => precioHora;}
        private int horas;
        public Plomero()
        {
            this.precioHora=80;
        }
        public void Trabajar(int horas)
        {
            this.horas=horas;
        }
        public int Cobrar()
        {
            return horas*precioHora;
        }
    }
}