namespace E3
{
    public class PlacaDeVideo : Componente
    {
        private int precio;
        private string ranuraRequerida;
        public PlacaDeVideo (int precio, string ranuraRequerida)
        {
            this.precio = precio;
            this.ranuraRequerida = ranuraRequerida;
        }
        public int Precio ()
        {
            return precio;
        }
        public bool EsCompatible(Motherboard mother)
        {
            return (this.ranuraRequerida == mother.RanuraDeExpansion);
        }
    }
}