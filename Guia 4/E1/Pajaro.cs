namespace E1
{
    public class Pajaro : Animal
    {
        public Pajaro(int energia): base(energia)
        {
            
        }
        public override void Comer()
        {
            this.energia+=10;
        }
        public override void Jugar()
        {
            this.energia-=5;
        }
    }
}