namespace E6
{
    public class Calificacion
    {
        int valor;
        public int Valor { get => valor; }
        string comentario;
        public Calificacion (int valor, string comentario)
        {
            this.valor = valor;
            this.comentario = comentario;
        }
    }
}