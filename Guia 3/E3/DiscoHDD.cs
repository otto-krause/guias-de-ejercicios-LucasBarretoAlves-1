namespace E3
{
    public class DiscoHDD : Componente
    {
        private int precio;
        private string conector;
        public DiscoHDD (int precio, string conector)
        {
            this.precio = precio;
            this.conector = conector;
        }

        public int Precio ()
        {
            return precio;
        }
        public bool EsCompatible (Motherboard mother)
        {
            return (this.conector == mother.CableDeInterconexion);
        }
    }
}