using System;
using System.Linq;
using System.Collections.Generic;
namespace E8
{
    public class Matematicas2
    {
        public Matematicas2()
        {
        }
        public List<int> Primos(List<int> numeros){
            List<int> aux = new List<int>();
            
            foreach(int numeroAux in numeros){
                int contador = 0;
                for(int j=1; j < (numeroAux+1); j++){
                    if(numeroAux % j == 0)
                        contador++;
                }
                if(contador == 2 || numeroAux == 1)
                    aux.Add(numeroAux);
            }
            return aux;
        }
        public List<int> Pares (List<int> numeros){
            return numeros.Where(numeroAux => numeroAux % 2 == 0).ToList();
        }
        public List<int> Aplanar(List<int> numeros){
            return numeros.Distinct().ToList();
        }
        public int Suma(List<int> numeros){
            int num = numeros.Sum();
            return num;
        }
        public int SumaDePrimos(List<int> numeros){
            return Primos(numeros).Sum();
        }
        public int Maximo(List<int> numeros){
            return numeros.Max();
        }
        public int Minimo(List<int> numeros){
            return numeros.Min();
        }
       
    }
}