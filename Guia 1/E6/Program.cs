﻿using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int selec=0;
            int num=0;
            int num1=0;
            int salida=0;
            while (selec!=6)
            {
                Console.Write("\n\n1 - Secuencia Fibonacci\n2 - Factorial de un numero");
                Console.Write("\n3 - Mayor de dos numeros\n4 - Menor de dos numeros");
                Console.Write("\n5 - Cubo de un numero\n6 - Salir");

                Console.Write("\nIngrese una seleccion: ");
                selec=Int32.Parse(Console.ReadLine());


                switch (selec)
                {
                    case 1:
                        Console.Write("Ingrese el numero de elementos a mostrar de la secuencia: ");
                        num=Int32.Parse(Console.ReadLine());
                        Console.Write("0 1 ");
                        int ult=1;
                        int penult=0;
                        int actual=0;
                        for (int i = 0; i < num-2; i++)
                            {
                                actual=ult+penult;
                                Console.Write(actual + " ");
                                penult=ult;
                                ult=actual;
                                
                                
                            }

                        break;
                    case 2:
                        Console.Write("Ingrese un numero: ");
                        salida=Matematica.Factorial(Int32.Parse(Console.ReadLine()));
                        Console.WriteLine("El factorial del numero es "+ salida);
                        break;
                    case 3:
                        Console.Write("Ingrese un numero(1 de 2): ");
                        num=Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese un numero(2 de 2): ");
                        num1=Int32.Parse(Console.ReadLine());

                        Console.Write("El numero mayor es "+Matematica.Mayor(num,num1));
                        break;
                    case 4:
                        Console.Write("Ingrese un numero(1 de 2): ");
                        num=Int32.Parse(Console.ReadLine());
                        Console.Write("Ingrese un numero(2 de 2): ");
                        num1=Int32.Parse(Console.ReadLine());

                        Console.Write("El numero menor es "+Matematica.Menor(num,num1));

                        
                        break;
                    case 5:
                        Console.Write("Ingrese un numero: ");
                        num=Int32.Parse(Console.ReadLine());

                        Console.Write("El cubo del numero es "+Matematica.Cubo(num));
                        break;
                    default:
                        if (selec!=6)
                            Console.Write("Seleccion no valida");
                        break;
                }

            }
            
        }
    }   
}
