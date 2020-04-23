namespace E2
{
    public class Medico
    {
        public string nombre;
        public string apellido;
        public string especialidad;
        public int cantidadturnos;
        public Medico(string nombre, string apellido, string especialidad, int cantidadturnos)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.especialidad=especialidad;
            this.cantidadturnos=cantidadturnos;
        }
        public bool EstaDisponible()
        {
            return cantidadturnos<50;
        }
    }
}