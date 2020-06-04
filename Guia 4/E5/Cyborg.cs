namespace E5
{
    public class Cyborg : Robot
    {
        public Humano(int inteligencia) : base(inteligencia)
        {
            
        }
        public override void Estudiar(string tema)
        {
            bool estabaEnIntereses;
            this.conocimientos.Add(tema);
            
            if (intereses.Contains(tema))
                this.inteligencia+=5;
        }
    }
}