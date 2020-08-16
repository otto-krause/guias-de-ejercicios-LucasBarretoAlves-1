using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Raven : Titan
    {
        protected List<string> pensamientos;
        protected int cantidadp;
        int felicidad;
        public Raven() 
        {
            this.felicidad = 2;
            this.cantidadp = 4;
            pensamientos = new List<string>();
            pensamientos.Add("Extraño a mi papi");
            pensamientos.Add("Me quedé sin MANTECA");
            pensamientos.Add("Perdí a Pipo");
            pensamientos.Add("Voy a comprar pilas para Robocop");
            pensamientos.Add("¿Donde está Pipo?");
        }


        public override bool EstaTriste()
        {
            return CantidadNegativos() >= 5  &&  felicidad == 10;
        }
        public override void ComerPizza()
        {
            felicidad += 2*cantidadp;
        }

        public override int Poder()
        {
            return CantidadNegativos();
        }

        public override void LlorarPorRobocop()
        {
            pensamientos.RemoveAt(0);
        }
        protected int CantidadNegativos()
        {
            int cont=0;

            cont=pensamientos.Where(pensamiento => pensamiento.Contains("papi") ||
            pensamiento.Contains("perrito") ||
            pensamiento.Contains("Robocop") ||
            pensamiento.Contains("Pipo") ||
            pensamiento.Contains("MANTECA")).ToList().Count();

            return cont;
        }

    }
}