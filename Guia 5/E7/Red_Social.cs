using System;
using System.Collections.Generic;
using System.Linq;
namespace E7
{
    public class Red_Social
    {
        Cuenta maria;
        Cuenta viviana;
        Cuenta pedro;
        Foto foto1;
        Foto foto2;
        Foto foto3;
        Foto foto4;
        List<string> amigos;
        List<string> publicaciones;
        List<string> publicacionesTotales;
        List<Foto> albumDeFotos;
        List<Foto> fotosTotal;
        List<Cuenta> personasTotal;
        public Red_Social ()
        {

            foto1 = new Foto ("F:/almacenamiento/DCIM", "22-11-2002", new List<string> { "Joaquín Medina", "Kevin Bruno", "Rafael Díaz" });
            foto2 = new Foto ("F:/almacenamiento/DCIM", "16-07-2020", new List<string> { "Joaquín Medina", "Kevin Bruno" });
            foto3 = new Foto ("F:/almacenamiento/DCIM", "10-09-2020", new List<string> { "Rafael Díaz", "Joaquín Medina" });
            foto4 = new Foto ("F:/almacenamiento/DCIM", "20-03-2006", new List<string> { "Rafael Díaz", "Kevin Bruno" });

            fotosTotal = new List<Foto> { foto1, foto2, foto3, foto4 };

            publicaciones = new List<string> { "De tu envidia nace mi fama", "Otro día con vida" };
            albumDeFotos = new List<Foto> { foto1, foto3, foto4 };
            amigos = new List<string> { "Joaquín Medina", "Kevin Bruno" };
            maria = new Cuenta ("Rafael Díaz", amigos, publicaciones, albumDeFotos);

            publicaciones = new List<string> { "Acá con la bandaaaaaaa", "Soy de la calle" };
            albumDeFotos = new List<Foto> { foto1, foto2, foto3 };
            amigos = new List<string> { "Rafael Díaz", "Kevin Bruno" };
            viviana = new Cuenta ("Joaquín Medina", amigos, publicaciones, albumDeFotos);

            publicaciones = new List<string> { "Te doy/ te daba", "Agradecido con el de arriba" };
            albumDeFotos = new List<Foto> { foto1, foto2, foto4 };
            amigos = new List<string> { "Rafael Díaz", "Joaquín Medina" };
            pedro = new Cuenta ("Kevin Bruno", amigos, publicaciones, albumDeFotos);

            personasTotal = new List<Cuenta> { maria, viviana, pedro };
            publicacionesTotales = new List<string>
            {
                "De tu envidia nace mi fama",
                "Otro día con vida",
                "Acá con la bandaaaaaaa",
                "Soy de la calle",
                "Te doy/ te daba",
                "Agradecido con el de arriba"
            };
        }
        public List<Foto> fotosUltimoAño (string persona)
        {
            List<Foto> fotoAux = new List<Foto> ();
            fotoAux = fotosTotal.Where (foto => foto.PersonasEtiquetadas.Contains (persona) &&
                    foto.FechaDeCreacion.Contains ("2020"))
                .ToList ();
            return fotoAux = fotoAux.Count () > 0 ? fotoAux : null;
        }

        public List<Foto> fotosEtiquetadas (string persona1, string persona2)
        {
            List<Foto> fotoAux1 = new List<Foto> ();
            fotoAux1 = fotosTotal.Where (foto => foto.PersonasEtiquetadas.Contains (persona1) && foto.PersonasEtiquetadas.Contains (persona2)).ToList ();
            return fotoAux1 = fotoAux1.Count () > 0 ? fotoAux1 : null;
        }
        public List<string> publicacionesDeMas300Caracteres ()
        {
            List<string> publicacionesAux = new List<string> ();
            publicacionesAux = publicacionesTotales.Where (publicacion => publicacion.Count () > 300).ToList ();
            return publicacionesAux = publicacionesAux.Count () > 0 ? publicacionesAux : null;
        }
    }
}