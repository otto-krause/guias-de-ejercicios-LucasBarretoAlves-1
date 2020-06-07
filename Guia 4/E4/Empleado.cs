namespace E4
{
    public abstract class Empleado
    {
        protected int cajaBancaria;
        public Empleado(int cajaBancaria)
        {
            this.cajaBancaria=cajaBancaria;
        }

        public void Extraccion(int cantidad)
        {
            if (cantidad <= cajaBancaria)
                cajaBancaria -= cantidad;
        }

        public abstract void Deposito();
    }
}