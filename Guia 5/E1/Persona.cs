namespace E1
{
    public class Persona
    {
        private int edad;
        public int Edad {get => edad;}
        private string nombre;
        public string Nombre {get => nombre;}
        private string apellido;
        public string Apellido {get => apellido;}
        public Persona(int edad, string nombre, string apellido)
        {
            this.edad=edad;
            this.nombre=nombre;
            this.apellido=apellido;
        }
    }
}