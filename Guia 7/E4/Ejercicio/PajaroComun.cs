namespace Ejercicio
{
    public class PajaroComun : Pajaro
    {
        public PajaroComun(int ira)
        {
            this.ira = ira;
        }
        
        public override void SeEnoja()
        {
            this.ira *= 2;
        }
        
        public override int Fuerza()
        {
            return ira*2;
        }

        
    }
}