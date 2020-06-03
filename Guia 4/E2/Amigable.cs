namespace E2
{
    public class Amigable : Monstruo
    {
        public Amigable (int respeto, string nombre) : base (respeto, nombre)
        {

        }

        public override void Asustar ()
        {
            this.respeto += 7;
        }

        public override void HacerReir ()
        {
            this.respeto += 1;
        }
    }
}