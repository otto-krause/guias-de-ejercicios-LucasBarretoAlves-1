using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Receta
    {
        protected List<string> pasos;
        protected List<Ingrediente> ingredientes;
        public Receta(List<string> pasos, List<Ingrediente> ingredientes)
        {
            this.pasos = pasos;
            this.ingredientes = ingredientes;
        }

        public int CantidadDePasos()
        {
            return pasos.Count();
        }

        public int CantidadDeIngredientes()
        {
            return ingredientes.Count();
        }

        public bool EsDeGordo()
        {
            return ingredientes.Sum(ingrediente => ingrediente.Calorias) > 2000;
        }

        public bool EsRapida()
        {
            return CantidadDeIngredientes() / CantidadDePasos() > 1;
        }
    }
}