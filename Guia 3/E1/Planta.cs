namespace E1
{
    public class Planta
    {
        private int cantidadDeUranio;
        MrBurns burns;
        private Empleado empleado;
        public Planta(Empleado empleado, MrBurns burns)
        {
            this.cantidadDeUranio=10000;
            this.empleado = empleado;
            this.burns= burns;
        }
        public bool estaEnPeligro()
        {
            return (cantidadDeUranio > 10000 && empleado.estaDistraido()
                    || !burns.esMillonario());
        }
        public void cambiarEmpleado (Empleado nuevoEmpleado)
        {
            this.empleado=nuevoEmpleado;
        }
        public void recibirCargamento(int cantidad)
        {
            this.cantidadDeUranio+=cantidad;
        }
    }
}