namespace E4
{
    public class Libro
    {
        private string titulo;
        public string Titulo {get => titulo;}
        private string autor;
        public Libro(string titulo, string autor)
        {
            this.titulo=titulo;
            this.autor=autor;
        }
    }
}