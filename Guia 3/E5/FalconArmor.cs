namespace E5
{
    public class FalconArmor : Armadura
    {
        private int id;
        public int ID { get => id; }
        private int potencia;
        private int resistencia;
        public FalconArmor ()
        {
            this.id = 0;
            this.potencia = 25;
            this.resistencia = 10;
        }
        public int BonificacionDeDanio ()
        {
            return (potencia + resistencia) / 2;
        }
        public void Entrenar (int valor)
        {
            potencia += 10;
            if (valor <= resistencia)
                resistencia -= valor;
            else
                resistencia = 0;
        }

        public int RecibirID()
        {
            return id;
        }
    }
}