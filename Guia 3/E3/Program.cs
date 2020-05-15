using System;
using System.Collections.Generic;

namespace E3
{
    class Program
    {
        static void Main (string[] args)
        {
            int precio;
            string modeloram;
            int cantidadram;
            string arquitectura;
            int frecuencia1;
            int frecuencia2;
            string cableconexion;
            string ranura;
            int selec=1;
            Console.WriteLine ("Mother:\n");
            Console.WriteLine ("Ingrese el precio del mother: ");
            precio = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese el modelo de RAM soportado: ");
            modeloram = Console.ReadLine ();
            Console.WriteLine ("Ingrese la cantidad maxima de memoria RAM soportada (en GB): ");
            cantidadram = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese la arquitectura de memoria utilizada: ");
            arquitectura = Console.ReadLine ();
            Console.WriteLine ("Ingrese el rango de frecuencia admitido (maximo): ");
            frecuencia1 = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese el rango de frecuencia admitido (minimo): ");
            frecuencia2 = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese el tipo de cable de interconexion usado: ");
            cableconexion = Console.ReadLine ();
            Console.WriteLine ("Ingrese el tipo de ranura de expansion presente: ");
            ranura = Console.ReadLine ();
            Motherboard mother = new Motherboard (precio, modeloram, cantidadram, arquitectura,
                frecuencia1, frecuencia2, ranura, cableconexion);

            Console.WriteLine ("\nMemoria RAM:");
            Console.WriteLine ("Ingrese el precio de la memoria: ");
            precio = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese el modelo de RAM requerido: ");
            modeloram = Console.ReadLine ();
            Console.WriteLine ("Ingrese el tamaño de la memoria (en GB): ");
            cantidadram = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese la arquitectura de memoria requerida: ");
            arquitectura = Console.ReadLine ();
            Console.WriteLine ("Ingrese la frecuencia de la memoria: ");
            frecuencia1 = Int32.Parse (Console.ReadLine ());
            MemoriaRam memoria = new MemoriaRam (precio, modeloram, cantidadram, arquitectura, frecuencia1);

            Console.WriteLine ("\nDisco HDD:");
            Console.WriteLine ("Ingrese el precio del disco: ");
            precio = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese tipo de cable de conexión requerido: ");
            cableconexion = Console.ReadLine ();
            DiscoHDD discoduro = new DiscoHDD (precio, cableconexion);

            Console.WriteLine ("\nDisco SSD:");
            Console.WriteLine ("Ingrese el precio del disco: ");
            precio = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese tipo de cable de conexión requerido: ");
            cableconexion = Console.ReadLine ();
            DiscoSSD discosolido = new DiscoSSD (precio, cableconexion);

            Console.WriteLine ("\nLectora de CD:");
            Console.WriteLine ("Ingrese el precio de la lectora:");
            precio = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese tipo de cable de conexión requerido: ");
            cableconexion = Console.ReadLine ();
            LectoraDeCD lectora = new LectoraDeCD (precio, cableconexion);

            Console.WriteLine ("\nPlaca de video:");
            Console.WriteLine ("Ingrese el precio de la placa:");
            precio = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese tipo de ranura de expansion requerida: ");
            ranura = Console.ReadLine ();
            PlacaDeVideo placavideo = new PlacaDeVideo (precio, ranura);

            PC gamer = new PC (mother,discoduro, discosolido, lectora, memoria, placavideo);

            while (selec != 0)
            {
                Console.WriteLine ("\n1- Costo total de la PC");
                Console.WriteLine ("2- Ver si es posible armar la PC");
                Console.WriteLine ("0- Salir");
                Console.WriteLine ("\nIngrese una seleccion:");
                selec = Int32.Parse (Console.ReadLine ());

                switch (selec)
                {
                    case 1:
                        Console.WriteLine ("El costo total de la PC es de " + gamer.PrecioTotal ());
                        break;
                    case 2:
                        Console.WriteLine (gamer.SePuedeArmar ());
                        break;
                    default:
                        if (selec != 0)
                            Console.WriteLine ("Ingreso invalido");
                        break;
                }
            }

        }
    }
}