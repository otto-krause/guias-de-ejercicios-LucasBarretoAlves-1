namespace E5
{
    public class ShadowArmor : Armadura
    {
        private int id;
        private int desgaste;
        public ShadowArmor ()
        {
            this.id = 1;
            this.desgaste = 1;
        }
        public void Entrenar (int valor)
        {
            desgaste += valor;
        }

        public int BonificacionDeDanio ()
        {
            return 80 / desgaste;
        }
        public int RecibirID()
        {
            return id;
        }
    }
}