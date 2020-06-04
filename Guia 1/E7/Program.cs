using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            int selec=0;
            Camara vidrio_molido=new Camara(1,25);3
            Camara vidrio_roto= new Camara(2,30);
            Celular ladrillo=new Celular(false, false, 1024, 10, vidrio_molido, vidrio_roto);
            while (selec!=3)
            {
                Console.Write("\n\n1 - Consultar memoria disponible\n2 - Consultar si el telefono te carga la SUBE");
                Console.Write("\n3 - Salir");
                

                Console.Write("\nIngrese una seleccion: ");
                selec=Int32.Parse(Console.ReadLine());

                switch (selec)
                {
                    case 1:
                        Console.Write("La memoria disponible es de "+ladrillo.MemoriaDisponible()+"MB");
                        break;
                    case 2:
                        Console.Write(ladrillo.TeCargaLaSUBE()?"Su celular es apto para cargar la SUBE":"Su celular es un ladrillo");
                        break;
                    default:
                        if (selec!=3)
                            Console.Write("Seleccion no valida");
                        break;
                }
            }
        }
    }
    
}
