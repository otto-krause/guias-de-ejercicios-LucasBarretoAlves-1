using System;
using System.Collections.Generic;
namespace E5
{
    class Program
    {
        static void Main (string[] args)
        {
            FalconArmor falconarmor = new FalconArmor ();
            ShadowArmor shadowarmor = new ShadowArmor ();
            XBuster xbuster = new XBuster ();
            X x = new X (xbuster, falconarmor);
            int selec=1;
            int ingreso;
            while (selec!=0)
            {
                Console.WriteLine("\n1 - Consultar bonificacion de armadura\n"+
                "2 - Consultar fuerza de X\n3 - Entrenar\n"+
                "4 - Cambiar armadura a Shadow Armor\n5 - Cambiar armadura a Falcon Armor\n"+
                "0 - Salir");
                selec=Int32.Parse(Console.ReadLine());
                switch (selec)
                {
                    case 1:
                        Console.WriteLine("La bonificacion actual de la armadura es de " + x.Bonificacion());
                        break;
                    case 2:
                        Console.WriteLine("\nLa fuerza actual de X es de "+ x.Fuerza());
                        break;
                    case 3:
                        Console.WriteLine("Ingrese minutos a entrenar: ");
                        ingreso=Int32.Parse(Console.ReadLine());
                        x.Entrenamiento(ingreso);
                        break;
                    case 4:
                        x.CambioDeArmadura(shadowarmor);
                        break;
                    case 5:
                        x.CambioDeArmadura(falconarmor);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}