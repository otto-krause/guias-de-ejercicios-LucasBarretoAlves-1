using System;
using System.Collections.Generic;
namespace E2
{
    class Program
    {
        static void Main (string[] args)
        {
            int selec = 1;
            List<Monstruo> respetables;
            MonstersInc empresa = new MonstersInc ();

            while (selec != 0)
            {
                Console.WriteLine ("\n1 - Noche de sustos\n2 - Noche de risas\n" +
                    "3 - Listar monstruos respetables\n4 - Energia de la empresa\n" +
                    "0 - Salir\n");
                selec = Int32.Parse (Console.ReadLine ());
                switch (selec)
                {
                    case 1:
                        empresa.NocheDeSustos();
                        break;
                    case 2:
                        empresa.NocheDeRisas();
                        break;
                    case 3:
                        respetables = empresa.MonstruosRespetables();
                        foreach (Monstruo respetable in respetables)
                        {
                            Console.WriteLine(respetable.Nombre);
                        }
                        break;
                    case 4:
                        Console.WriteLine("La energia de la empresa es de " + empresa.EnergiaTotal());
                        break;
                    default:
                        break;
                }
            }

        }
    }
}