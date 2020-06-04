namespace E2
{
    public class Peligroso : Monstruo
    {
        public Peligroso (int respeto, string nombre) : base (respeto, nombre)
        {

        }

        public override void Asustar ()
        {
            this.respeto += 5;
        }

        public override void HacerReir ()
        {
            this.respeto -= 2;
        }
    }
}