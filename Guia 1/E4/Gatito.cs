namespace E4
{
    public class Gatito
    {
        string nombre;
        bool vacunas;
        int energia;
        public Gatito(string nombre, bool vacunas, int energia)
        {
            this.nombre=nombre;
            this.vacunas=vacunas;
            this.energia=energia;
        }

        public string Nombre()
        {
            return nombre;
        }

        public bool EstaVacunado()
        {
            return vacunas;
        }

        public void Jugar (int minutos)
        {
            if (energia>=2*minutos)
            {
                Console.Write("Se jugo exitosamente con el gatito! (afecto+2)(no realmente)");
                energia -= 2*minutos;
            }

                
            else
                Console.Write("El gatito no tuvo energia suficiente (F)");
        }

        public void Comer()
        {
            energia+=50;
            Console.Write("El gatito fue alimentado forzadamente");
        }

        public bool EstaSaludable ()
        {
            return vacunas && energia>30;
        }
    }
}