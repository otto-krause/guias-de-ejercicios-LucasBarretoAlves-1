namespace E7
{
    public class Camara
    {
        int megapixeles;
        int cantidadfotos;
        public Camara(int megapixeles, int cantidadfotos)
        {
            this.megapixeles=megapixeles;
            this.cantidadfotos=cantidadfotos;
        }
        public int pesoPorFoto()
        {
            return megapixeles*3;
        }
        public int PesoTotalDeFotos()
        {
            return this.pesoPorFoto()*cantidadfotos;
        }
    }
}