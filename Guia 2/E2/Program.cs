using System;
using System.Collections.Generic;
namespace E2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string especialidad;
            bool estaAtendido=false;
            Clinica sanatoriofebril = new Clinica();
            Console.Write("Ingrese la especialidad deseada: ");
            especialidad=Console.ReadLine();
            foreach (Medico medico in sanatoriofebril.medicos)
            {
                if (especialidad==medico.especialidad && medico.EstaDisponible() && !estaAtendido)
                {
                    Console.WriteLine("Lo atendera " + medico.nombre + " " + medico.apellido);
                    estaAtendido=true;
                }
            }
            if (estaAtendido==false)
                Console.WriteLine("Intente de nuevo mas tarde");
        }
    }
}
