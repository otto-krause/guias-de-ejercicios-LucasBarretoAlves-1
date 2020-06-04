using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1;
            int lado2;
            int lado3;
            int selec=0;
            Console.WriteLine("Ingrese el primer lado del triangulo: ");
            lado1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo lado del triangulo: ");
            lado2=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer lado del triangulo: ");
            lado3=Int32.Parse(Console.ReadLine());
            Triangulo triangulo=new Triangulo(lado1, lado2, lado3);
            while (selec!=5)
            {
                Console.Write("\n\n1 - Consultar si el triangulo es escaleno\n2 - Consultar si el triangulo es isosceles");
                Console.Write("\n3 - Consultar si el triangulo es equilatero\n4 - Consultar si el triangulo es rectangulo");
                Console.Write("\n5 - Salir");

                Console.Write("\nIngrese una seleccion: ");
                selec=Int32.Parse(Console.ReadLine());

                switch (selec)
                {
                    case 1:
                        if (triangulo.EsEscaleno())
                            Console.Write("El triangulo es escaleno");
                        else
                            Console.Write("El triangulo no es escaleno");
                        break;
                    case 2:
                        if (triangulo.EsIsosceles())
                            Console.Write("El triangulo es isosceles");
                        else
                            Console.Write("El triangulo no es isosceles");
                        break;
                    case 3:
                        if (triangulo.EsEquilatero())
                            Console.Write("El triangulo es equilatero");
                        else
                            Console.Write("El triangulo no es equilatero");
                        break;
                    case 4:
                        if (triangulo.EsTrianguloRectangulo())
                            Console.Write("El triangulo es rectangulo");
                        else
                            Console.Write("El triangulo no es rectangulo");
                        break;
                    default:
                        if (selec!=5)
                            Console.Write("Seleccion no valida");
                        break;
                }
            }
            
            
        }
    }
    
}
