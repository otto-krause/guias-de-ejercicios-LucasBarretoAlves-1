namespace E5
{
    public class XBuster 
    {
        private int danio;
        public XBuster ()
        {
            this.danio = 10;
        }

        public void Entrenar (int valor)
        {
            danio += 2 * valor;
        }

        public int BonificacionDeDanio ()
        {
            return danio;
        }
    }
}