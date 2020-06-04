namespace E4
{
    public class Pelicula
    {
        string nombre;
        public string Nombre {get => nombre;}
        string genero;
        public string Genero {get => genero;}
        int anio;
        public int Anio {get => anio;}
        string director;
        public string Director {get => director;}
        public Pelicula (string nombre, string genero, int anio, string director)
        {
            this.nombre=nombre;
            this.genero=genero;
            this.anio=anio;
            this.director=director;
        }
    }
}