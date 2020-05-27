namespace E1
{
    public abstract class Animal
    {
        protected int energia;
        public Animal(int energia)
        {
            this.energia=energia;
        }

        public abstract void Jugar();
        public abstract void Comer();

        public void Dormir(int energia)
        {
            this.energia+=energia;
        }

        public int Energia()
        {
            return energia;
        }
    }
}