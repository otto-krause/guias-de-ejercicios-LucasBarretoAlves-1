namespace E3
{
    public class LectoraDeCD : Componente
    {
        private int precio;
        private string cableRequerido;
        public LectoraDeCD (int precio, string cableRequerido)
        {
            this.precio = precio;
            this.cableRequerido = cableRequerido;
        }
        public int Precio ()
        {
            return precio;
        }
        public bool EsCompatible (Motherboard mother)
        {
            return (this.cableRequerido == mother.CableDeInterconexion);
        }
    }
}