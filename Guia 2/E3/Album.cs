using System;
using System.Collections.Generic;
namespace E3
{
    public class Album
    {
        List<Figurita> agregadas = new List<Figurita>();
        bool valida;
        int contado;
        public bool AgregarFigurita(Figurita figurita)
        {
            valida=true;
            foreach (Figurita figu in agregadas)
            {
                if (figu.Nombre==figurita.Nombre && figu.Posicion==figurita.Posicion 
                && figu.Pais==figurita.Pais && figu.Numero==figurita.Numero)
                    valida=false;
            }
            if (valida)
                agregadas.Add(figurita);
            return valida;
        }
        public int CuantosDe(string posicion)
        {
            contado=0;
            foreach (Figurita figu in agregadas)
            {
                if (figu.Posicion==posicion)
                    contado++;
            }
            return contado;
        }
        public bool EstaCompleto()
        {
            return (agregadas.Count==352);
        }
    }
}