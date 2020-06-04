namespace E2
{
    public abstract class Monstruo
    {
        protected int respeto;
        public int Respeto { get => respeto; }
        protected string nombre;
        public string Nombre { get => nombre; }

        public Monstruo (int respeto, string nombre)
        {
            this.respeto = respeto;
            this.nombre = nombre;
        }

        public abstract void Asustar ();
        public abstract void HacerReir ();

    }
}
