using System;
using System.Collections.Generic;
using System.Linq;
namespace E10
{
    public class Colegio
    {
        ExAlumno victoria, yael, natanael, carlos, pepe, julio, estanislao, adolfo;
        List<ExAlumno> exalumnos;
        public Colegio ()
        {
            victoria = new ExAlumno (200300, 21, 6);
            yael = new ExAlumno (300042, 8, 2);
            natanael = new ExAlumno (10000, 0, 2);
            carlos = new ExAlumno (350000, 3, 2);
            pepe = new ExAlumno (340000, 6, 3);
            julio = new ExAlumno (300000, 4, 2);
            estanislao = new ExAlumno (300000, 9, 6);
            adolfo = new ExAlumno (300000, 7, 3);
            exalumnos = new List<ExAlumno> { victoria, yael, natanael, carlos, pepe, julio, estanislao, adolfo };
        }
        public bool fueExitoso ()
        {
            return exalumnos.Where (exalumno => exalumno.Sueldo > 200000).ToList ().Count () > 5 &&
                exalumnos.Where (exalumno => exalumno.Visitas > 4).ToList ().Count () > 3 &&
                exalumnos.All (exalumno => exalumno.IdiomasEstudiados >= 2) &&
                exalumnos.Any (exalumno => exalumno.IdiomasEstudiados > 5);
        }
    }
}