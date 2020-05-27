using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int selec=1;
            int energia;
            Animal salchicha = new Perro(30);
            Animal carpintero = new Pajaro(50);

            while (selec!=0)
            {
                Console.WriteLine("\n1 - Dar de comer al perro\n"+
                "2 - Jugar con el perro\n3 - Consultar energia del perro\n"+
                "4 - Dar de comer al pajaro\n5 - Jugar con el pajaro\n"+
                "6 - Consultar energia del pajaro\n7 - Hacer dormir al perro\n"+
                "8 - Hacer dormir al pajaro\n0 - Salir");
                selec=Int32.Parse(Console.ReadLine());
                switch (selec)
                {
                    case 1:
                        salchicha.Comer();
                        break;
                    case 2:
                        salchicha.Jugar();
                        break;
                    case 3:
                        Console.WriteLine("El perro tiene "+salchicha.Energia()+" de energia\n");
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        carpintero.Comer();
                        break;
                    case 5:
                        carpintero.Jugar();
                        break;
                    case 6:
                        Console.WriteLine("El pajaro tiene "+carpintero.Energia()+" de energia\n");
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Ingrese cantidad de energia a recuperar con el descanso: ");
                        energia=Int32.Parse(Console.ReadLine());
                        salchicha.Dormir(energia);
                        break;
                    case 8:
                        Console.WriteLine("Ingrese cantidad de energia a recuperar con el descanso: ");
                        energia=Int32.Parse(Console.ReadLine());
                        carpintero.Dormir(energia);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
