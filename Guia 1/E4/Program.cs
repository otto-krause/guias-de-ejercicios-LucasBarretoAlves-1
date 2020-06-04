using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int selec=0;
            Gatito pepe= new Gatito("pepe", true, 35);
            while (selec!=6)
            {
                Console.Write("\n\n1 - Consultar nombre del gatito\n2 - Consultar si esta vacunado\n");
                Console.Write("3 - Jugar con el gatito\n4 - Darle de comer al gatito\n");
                Console.Write("5 - Consultar si el gatito se encuentra saludable\n6 - Salir\n\n");
                Console.Write("Ingrese una seleccion: ");
                selec=Int32.Parse(Console.ReadLine());
                switch (selec)
                {
                    case 1:
                        Console.Write("El nombre del gatito es " + pepe.Nombre());
                        break;
                    case 2:
                        if (pepe.EstaVacunado())
                            Console.Write("El gatito esta vacunado");
                        else
                            Console.Write("El gatito no esta vacunado");
                        break;
                    case 3:
                        Console.Write("Ingrese cantidad de minutos que desea jugar con el gatito: ");
                        pepe.Jugar(Int32.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        pepe.Comer();
                        break;
                    case 5:
                        if (pepe.EstaSaludable())
                            Console.Write("El gatito esta saludable");
                        else
                            Console.Write("El gatito no esta saludable");
                        break;
                    default:
                        if (selec!=6)
                            Console.Write("Ingrese una seleccion valida");
                        break;
                
                }
            }
        }
    }
    class Gatito
    {
        string nombre;
        bool vacunas;
        int energia;
        public Gatito(string nombre, bool vacunas, int energia)
        {
            this.nombre=nombre;
            this.vacunas=vacunas;
            this.energia=energia;
        }

        public string Nombre()
        {
            return nombre;
        }

        public bool EstaVacunado()
        {
            return vacunas;
        }

        public void Jugar (int minutos)
        {
            if (energia>=2*minutos)
            {
                Console.Write("Se jugo exitosamente con el gatito! (afecto+2)(no realmente)");
                energia -= 2*minutos;
            }

                
            else
                Console.Write("El gatito no tuvo energia suficiente (F)");
        }

        public void Comer()
        {
            energia+=50;
            Console.Write("El gatito fue alimentado forzadamente");
        }

        public bool EstaSaludable ()
        {
            return vacunas && energia>30;
        }
    }
}
