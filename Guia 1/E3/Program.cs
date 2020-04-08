using System;

namespace E3
{
    class Program
    {
        public static bool esPar(int num)
        {
            return (num%2==0);
        }
        public static bool esPrimo(int num)
        {
            int divisor=1;
            int divisores=0;
            do{
                if(num % divisor == 0){
                divisores++;
                }
                divisor++;
            }while(divisor <= num);
            return (divisores==2);
        }

        static void Main()
        {
            int num;
            int selec;
            Console.Write("Ingrese un numero: ");
            num=Int32.Parse(Console.ReadLine());
            Console.WriteLine("1- Ver si el numero es par\n2- Ver si el numero es primo");
            selec=Int32.Parse(Console.ReadLine());
            if (selec==1)
            {
                if (esPar(num))
                    Console.WriteLine("El numero es par");
                else
                    Console.WriteLine("El numero es impar");
            }
            if (selec==2)
            {
                if (esPrimo(num))
                    Console.WriteLine("El numero es primo");
                else    
                    Console.WriteLine("El numero no es primo");
            }


        }
        
    }
}
