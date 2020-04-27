namespace E2
{
    public class Medico
    {
        string nombre;
        public string Nombre { get => nombre; }
        string apellido;
        string especialidad;
        
        int cantidadturnos;
        public Medico (string nombre, string apellido, string especialidad, int cantidadturnos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.cantidadturnos = cantidadturnos;
        }
        public bool EstaDisponibleYCumpleEspecialidad (string especialidad)
        {
            return cantidadturnos < 50 && this.especialidad==especialidad;
        }
        public void asignarTurno()
        {
            cantidadturnos++;
        }
    }
}