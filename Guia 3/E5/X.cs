namespace E5
{
    public class X
    {
        Armadura armadura;
        XBuster xbuster;

        public X (XBuster xbuster, Armadura armadura)
        {
            this.xbuster = xbuster;
            this.armadura = armadura;
        }

        public void Entrenamiento (int tiempo)
        {
            xbuster.Entrenar (tiempo);
            switch (armadura.RecibirID())
            {
                case 0:
                    armadura.Entrenar (tiempo);
                    break;
                case 1:
                    armadura.Entrenar (xbuster.BonificacionDeDanio ());
                    break;
                default:
                    break;
            }
        }
        public int Fuerza ()
        {
            return (xbuster.BonificacionDeDanio () + armadura.BonificacionDeDanio ());
        }
        public int Bonificacion()
        {
            return armadura.BonificacionDeDanio();
        }
        public void CambioDeArmadura (Armadura armadura)
        {
            this.armadura = armadura;
        }
    }
}