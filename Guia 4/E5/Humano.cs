namespace E5
{
    public class Humano : SerPensante
    {
        public Humano(int inteligencia) : base(inteligencia)
        {
            
        }
        public override void Pensar(string tema)
        {
            int cuenta=0;
            foreach (string conocimiento in this.conocimientos)
            {
                if (cuenta<5 && tema==conocimiento)
                    this.inteligencia+=5;
                cuenta++;
            }
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