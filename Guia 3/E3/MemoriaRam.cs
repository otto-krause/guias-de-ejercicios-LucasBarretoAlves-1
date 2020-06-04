namespace E3
{
    public class MemoriaRam : Componente
    {
        private int precio;
        private string modeloRam;
        private int tamanio;
        private string arquitecturaDeMemoria;
        private int frecuenciaDeMemoria;
        public MemoriaRam (int precio, string modeloRam, int tamanio, string arquitecturaDeMemoria, int frecuenciaDeMemoria)
        {
            this.precio = precio;
            this.modeloRam = modeloRam;
            this.tamanio = tamanio;
            this.arquitecturaDeMemoria = arquitecturaDeMemoria;
            this.frecuenciaDeMemoria=frecuenciaDeMemoria;
        }
        public int Precio ()
        {
            return precio;
        }
        public bool EsCompatible (Motherboard mother)
        {
            return (this.modeloRam == mother.ModeloRam &&
                    this.tamanio <= mother.RamSoportada &&
            this. arquitecturaDeMemoria == mother.ArquitecturaDeMemoria &&
            (frecuenciaDeMemoria<=mother.Maximofrecuencia && 
            frecuenciaDeMemoria>=mother.Minimofrecuencia));
        }
    }
}