using System;
using System.Linq;
using System.Collections.Generic;
namespace E11
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplicacion mapas = new Aplicacion("Gugol Mapas", 20,150,  new List<string>{"Acceso a cámara", "Acceso a datos personales", "Acceso a cuenta bancaria"}, 200);
            Aplicacion choqueclanes = new Aplicacion("Choqueclanes", 25, 625,  new List<string>{"Acceso a contactos", "Acceso a vida social", "Acceso a cuenta bancaria"}, 200);
            Aplicacion caralibro = new Aplicacion("Caralibro", 20, 320,  new List<string>{"Acceso a videos", "Acceso a fotos", "Acceso a cuenta bancaria"}, 400);
            List<Aplicacion> android = new List<Aplicacion>{mapas, choqueclanes, caralibro};
            
            Console.WriteLine("\nJuegos:");
            android.Where(app => app.Interaccion()==25).ToList().ForEach(app => Console.WriteLine(app.Nombre));

            Console.WriteLine("\nRedes sociales:");
            android.Where(app => app.Permisos.Contains("Acceso a fotos") && 
            app.Permisos.Contains("Acceso a videos") &&
            app.InteraccionConElTeclado()>=20).ToList().ForEach(app => Console.WriteLine(app.Nombre));
            
            Console.WriteLine("\nOtros:");
            android.Where(app => app.Interaccion()!=25 && 
            app.InteraccionConElTeclado()<20).ToList().ForEach(app => Console.WriteLine(app.Nombre));
        }
    }

        
}
