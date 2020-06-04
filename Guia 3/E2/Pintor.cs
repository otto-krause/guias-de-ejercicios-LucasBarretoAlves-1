namespace E2
{
    public class Pintor : Contratista
    {   
        private int precioHora;
        private int horas;
        public Pintor()
        {
            this.precioHora=150;
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