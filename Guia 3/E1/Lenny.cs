namespace E1
{
    public class Lenny : Empleado
    {
        private int cervezasTomadas;
        public Lenny()
        {
            this.cervezasTomadas=3;
        }
        public void tomarCerveza()
        {
            cervezasTomadas++;
        }
        public bool estaDistraido()
        {
            return cervezasTomadas>3;
        }
    }
}