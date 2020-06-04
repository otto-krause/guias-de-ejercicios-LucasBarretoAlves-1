namespace E5
{
    public abstract class SerPensante
    {
        protected inteligencia;
        protected List<string> conocimientos;
        protected List<string> intereses;

        public SerPensante(int inteligencia)
        {
            this.inteligencia=inteligencia;
            conocimientos = new List<string>
            intereses = new List<string>
        }
        public abstract Estudiar(string tema);
        public abstract Pensar(string tema);
    }
}