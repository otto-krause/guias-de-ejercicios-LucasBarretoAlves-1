using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vector = new int[10];
            int suma=0;
            double prom;
            int menor=0;
            int temp;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero ("+ (i+1) + " de 10): ");
                vector[i]= Int32.Parse(Console.ReadLine());
                suma+=vector[i];
                if (i==0)
                menor=vector[i];
                else
                {
                    if (vector[i]<menor)
                    menor=vector[i];
                }
            }
            prom= suma/10;
            Console.WriteLine("La sumatoria de los elementos es "+ suma);
            Console.WriteLine("El menor de los elementos es "+ menor);
            Console.WriteLine("Los elementos del vector, ordenados de menor a mayor son:\n");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (vector[j]>vector[j+1])
                    {
                        temp=vector[j];
                        vector[j]=vector[j+1];
                        vector[j+1]=temp;
                    }
                    

                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vector[i]+ " ");
            }
        }
    }
}
