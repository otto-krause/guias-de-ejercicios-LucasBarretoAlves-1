using System;
using System.Linq;
using System.Collections.Generic;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {

            List <CaballeroZodiaco> caballeros = new List<CaballeroZodiaco>();
            List<string> dioses = new List<string>();
            CaballeroZodiaco pegaso = new CaballeroZodiaco("Pegaso", "messi", "Capricornio", new Armadura("Pecho Helado", "bronce"));
            CaballeroZodiaco juancarlos = new CaballeroZodiaco("Juan Carlos", "Atena", "Cáncer", new Armadura("Guarda Cosmica", "plata"));
            CaballeroZodiaco hector = new CaballeroZodiaco("Hector", "Aldearriba", "Libra", new Armadura("De Diamante", "oro"));
            caballeros.Add(pegaso);
            caballeros.Add(juancarlos);
            caballeros.Add(hector);

            Console.WriteLine("\nArmaduras de caballeros que apoyan a Atena: ");
            caballeros.Where(caballero => caballero.Dios=="Atena")
            .ToList().ForEach(caballero => Console.WriteLine(caballero.Armadura.Nombre + ", hecha de " +caballero.Armadura.Material));

            Console.WriteLine("\nNombre de todos los dioses: ");
            dioses = caballeros.Select(caballero => caballero.Dios).Distinct().ToList();
            dioses.ForEach(dios => Console.WriteLine(dios));
            
            Console.WriteLine("\nNombre de los signos que empiezan por C: ");
            caballeros.Where(caballero => caballero.Signo[0]=='C').Distinct().ToList().ForEach(signos => Console.WriteLine(signos.Signo));

        }

    }
}
