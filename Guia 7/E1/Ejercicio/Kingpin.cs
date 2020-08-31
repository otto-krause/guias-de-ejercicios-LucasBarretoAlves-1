namespace Ejercicio
{
    public class Kingpin
    {
        protected int vida;
        public int Vida {get => vida;}

        public Kingpin()
        {
            this.vida = 800;
        }

        public void EsAtacado(int poder)
        {
            this.vida -= poder;
        }
        public bool FueVencido()
        {
            return vida<0;
        }

    }
}