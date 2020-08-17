using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Mago
    {
        protected Varita varita;
        protected List<Receta> recetasConocidas;
        public List<Receta> RecetasConocidas {get => recetasConocidas;}
        public Mago()
        {
            varita = new Carpe();
            recetasConocidas= new List<Receta>();
            Receta alfajorjaguarts = new Receta(new List<string>(){"1. Mezclar el agua y el aceite",
            "2. Agregar sal",
            "3. Comprar el alfajor en el kiosco mas cercano"},
            new List<Ingrediente>(){new Ingrediente(400), new Ingrediente(400), new Ingrediente(400)});

            Receta arrozjaguarts = new Receta (new List<string>(){"1. Hervir el arroz 33 minutos",
            "2. Retirar del fuego y servir",
            "3. Aplicar hechizo de sabor clase III"},
            new List<Ingrediente>(){new Ingrediente(400), new Ingrediente(400), new Ingrediente(400)});

            recetasConocidas.Add(alfajorjaguarts);
            recetasConocidas.Add(arrozjaguarts);
        }

        public bool EsUnLento()
        {
            return varita.TiempoReceta(recetasConocidas.First(receta => receta.EsRapida()).CantidadDePasos()) > 30;
        }

        public bool NoSeCuida()
        {
            return recetasConocidas.Where(receta => receta.EsDeGordo()).ToList().Count() > recetasConocidas.Count() / 2;
        }
    }
}