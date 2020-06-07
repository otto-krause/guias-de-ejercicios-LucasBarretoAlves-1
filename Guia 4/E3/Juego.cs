namespace E3
{
    public class Juego
    {
        private string nombre;
        public string Nombre { get => nombre; }
        private int anioDeLanzamiento;
        private string consolaCompatible;
        public string ConsolaCompatible { get => consolaCompatible; }

        public Juego(string nombre, int anioDeLanzamiento, string consolaCompatible)
        {
            this.nombre=nombre;
            this.anioDeLanzamiento=anioDeLanzamiento;
            this.consolaCompatible=consolaCompatible;
        }

    }
}