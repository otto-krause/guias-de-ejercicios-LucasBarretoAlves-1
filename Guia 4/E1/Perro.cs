namespace E1
{
    public class Perro : Animal
    {
        public Perro(int energia): base(energia)
        {
            
        }
        public override void Comer()
        {
            this.energia+=15;
        }
        public override void Jugar()
        {
            this.energia-=20;
        }
    }
}