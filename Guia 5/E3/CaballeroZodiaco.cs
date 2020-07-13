namespace E3
{
    public class CaballeroZodiaco
    {
        private string nombre;
        private string dios;
        public string Dios{get => dios;}
        private string signo;
        public string Signo{get => signo;}
        private Armadura armadura;
        public Armadura Armadura{get => armadura;}

        public CaballeroZodiaco(string nombre, string dios, string signo, Armadura armadura)
        {
            this.nombre=nombre;
            this.dios=dios;
            this.signo=signo;
            this.armadura=armadura;
        }
    }
}