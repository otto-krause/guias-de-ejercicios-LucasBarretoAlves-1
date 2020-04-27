using System;
using System.Collections.Generic;
namespace E6
{
    public class Juego
    {
        string titulo;
        public string Titulo { get => titulo; }
        string genero;
        public string Genero { get => genero; }
        List<Calificacion> calificaciones = new List<Calificacion> ();
        public Juego (string titulo, string genero, int modif)
        {
            this.titulo = titulo;
            this.genero = genero;
            Calificacion calif1 = new Calificacion (3 + modif, "me gusto");
            Calificacion calif2 = new Calificacion (1 + modif, "no me gusto");
            Calificacion calif3 = new Calificacion (2 + modif, "si");
            calificaciones.Add (calif1);
            calificaciones.Add (calif2);
            calificaciones.Add (calif3);
        }
        public double CalificacionGeneral ()
        {
            int suma = 0;
            int cuenta = 0;
            foreach (Calificacion calif in calificaciones)
            {
                suma += calif.Valor;
                cuenta++;
            }
            return suma / cuenta;
        }
    }
}