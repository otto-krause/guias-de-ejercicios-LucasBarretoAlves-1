namespace E2
{
    public class Albanil : Contratista
    {
        private int precioHora;
        public int PrecioHora {get => precioHora;}
        private int horas;
        private bool esMMO;
        private int edad;
        public Albanil(int edad, bool esMMO)
        {
            this.edad=edad;
            this.esMMO=esMMO;
            
            if (edad>20&&edad<31)
                this.precioHora=50;
            else
            {
                if (edad<50)
                    this.precioHora=90;
                else
                    this.precioHora=120; 
            }

            if (esMMO)
                this.precioHora+=50;
            
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