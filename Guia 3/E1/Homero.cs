namespace E1
{
    public class Homero : Empleado
    {
        private int donas;
        public Homero()
        {
            this.donas=2;
        }
        public void comprarDonas()
        {
            donas+=12;
        }
        public void comerDona()
        {
            donas--;
        }
        public bool estaDistraido()
        {
            return donas<2;
        }
    }
}