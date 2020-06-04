namespace E5
{
    public class Robot : SerPensante
    {
        public Robot(int inteligencia) : base(inteligencia)
        {
            
        }
        public override void Pensar(string tema)
        {
            inteligencia+=conocimientos.Count;
        }
        
        public override void Estudiar(string tema)
        {
            this.conocimientos.Add(tema);
        }
    }
}