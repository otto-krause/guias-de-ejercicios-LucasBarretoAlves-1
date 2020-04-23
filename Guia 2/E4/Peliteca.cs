namespace E4
{
    public class Peliteca
    {
        List <Pelicula> peliteca= new List <Pelicula>();
        public Peliteca()
        {
            peliteca.Add(Pelicula lavenganza = new Pelicula("La venganza", "Accion", 2000, "Pepe Liculas"));
            peliteca.Add(Pelicula lamaldicion= new Pelicula("La maldicion", "Terror",  1994, "Lupe Liculas"));
            peliteca.Add(Pelicula labroma = new Pelicula("La broma", "Comedia",  1996, "Carlos"));
            peliteca.Add(Pelicula elfuturo = new Pelicula("El futuro", "Ciencia Ficcion",  3140, "Si"));
            peliteca.Add(Pelicula lavenganza2 = new Pelicula("La venganza 2", "Accion", 2004, "Pepe Liculas"));
            peliteca.Add(Pelicula lamaldicion2= new Pelicula("La maldicion 2", "Terror",  1997, "Lupe Liculas"));
            peliteca.Add(Pelicula labroma2 = new Pelicula("La broma 2", "Comedia",  2000, "Carlos"));
            peliteca.Add(Pelicula elfuturo2 = new Pelicula("El futuro 2", "Ciencia Ficcion",  3300, "Quizas"));
      
        }
    }
}