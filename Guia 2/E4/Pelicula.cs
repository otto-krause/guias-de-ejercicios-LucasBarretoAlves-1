namespace E4
{
    public class Pelicula
    {
        public string nombre;
        public string genero;
        public int anio;
        public string director;
        public Pelicula (string nombre, string genero, int anio, string director)
        {
            this.nombre=nombre;
            this.genero=genero;
            this.anio=anio;
            this.director=director;
        }
    }
}