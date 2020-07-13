using System;
using System.Collections.Generic;
namespace E5
{
    public class Persona
    {
        protected List<string> conocimientos;
        public List<string> Conocimientos{get => conocimientos;}

        public Persona()
        {
            conocimientos = new List<string>();

            conocimientos.Add("Actuación");
            conocimientos.Add("Nadación");
            conocimientos.Add("Xilofón");
            conocimientos.Add("Fueración");
            conocimientos.Add("Zeta");
            conocimientos.Add("Esperación");

        }
    }
}