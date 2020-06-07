namespace E3
{
    public class Jugador
    {
        private string nombre;
        private List<Consola> listaDeConsolas;

        public Jugador (string nombre, Consola consola1, Consola consola2)
        {
            this.nombre = nombre;
            this.listaDeConsolas = new List<Consola> ();

            this.listaDeConsolas.Add (consola1);
            this.listaDeConsolas.Add (consola2);
        }

        public void AdquirirJuego(Juego juego)
        {
            foreach (Consola consola in listaDeConsolas)
            {
                if (consola.Nombre == juego.ConsolaCompatible)
                    listaDeConsolas.Add(juego);
            }
        }

        public string LaMasUsada()
        {
            int puntos = 0;
            string masUsada;

            foreach (Consola consola in listaDeConsolas)
            {
                if (consola.RevisarPuntaje()>puntos)
                {
                    puntos=consola.RevisarPuntaje();
                    masUsada=consola.Nombre;
                }
            }
            return masUsada;
        }
    }
}