namespace E3
{
    public class Figurita
    {
        string nombre;
        public string Nombre { get => nombre; }
        string posicion;
        public string Posicion { get => posicion; }
        string pais;
        public string Pais { get => pais; }
        int numero;
        public int Numero { get => numero; }
        public Figurita (string nombre, string posicion, string pais, int numero)
        {
            this.nombre = nombre;
            this.posicion = posicion;
            this.pais = pais;
            this.numero = numero;
        }
    }
}