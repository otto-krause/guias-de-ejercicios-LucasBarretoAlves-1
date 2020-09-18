namespace Ejercicio
{
    public class Bomb : Pajaro
    {
        protected int maximoPermitido;
        public Bomb(int ira)
        {
            this.ira = ira;
            this.maximoPermitido = 9000;
        }

        public override void SeEnoja()
        {
            this.ira = ira*2;
        }
        public override int Fuerza()
        {
            return ira * 2 >= maximoPermitido ? ira*2 : 9000; 
        }
    }
}