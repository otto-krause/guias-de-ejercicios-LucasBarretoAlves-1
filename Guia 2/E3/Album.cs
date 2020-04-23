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
                if (figu.nombre==figurita.nombre && figu.posicion==figurita.posicion 
                && figu.pais==figurita.pais && figu.numero==figurita.numero)
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
                if (figu.posicion==posicion)
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