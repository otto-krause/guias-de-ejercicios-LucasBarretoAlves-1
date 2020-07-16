namespace E10
{
    public class ExAlumno
    {
        double sueldo = 0;
        int visitas = 0;
        int idiomasEstudiados = 0;

        public ExAlumno (double sueldo, int visitas, int idiomasEstudiados)
        {
            this.sueldo = sueldo;
            this.visitas = visitas;
            this.idiomasEstudiados = idiomasEstudiados;
        }
        public double Sueldo { get => sueldo; }
        public int Visitas { get => visitas; }
        public int IdiomasEstudiados { get => idiomasEstudiados; }
    }
}