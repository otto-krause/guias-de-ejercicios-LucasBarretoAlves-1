namespace Ejercicio
{
    public abstract class Titan
    {
        protected int tristeza;
        public int Tristeza {get => tristeza;}
        public abstract void ComerPizza();
        public abstract void LlorarPorRobocop();
        public abstract bool EstaTriste();
        public abstract int Poder();
    }
}