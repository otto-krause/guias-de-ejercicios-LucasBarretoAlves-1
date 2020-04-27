using System;
using System.Collections.Generic;
namespace E6
{
    public class Steam
    {
        List<Juego> steam = new List<Juego> ();
        List<Juego> busqueda = new List<Juego> ();
        public List<Juego> Busqueda { get => busqueda; }
        public Steam ()
        {
            Juego carlosduty = new Juego ("Carlos Duty", "FPS", 2);
            Juego mediavida = new Juego ("Media Vida", "Aventura", 1);
            Juego miconfeccion = new Juego ("Mi Confeccion", "Sandbox", 0);
            steam.Add (carlosduty);
            steam.Add (mediavida);
            steam.Add (miconfeccion);
        }
        public void PorGenero (string genero)
        {
            foreach (Juego juego in steam)
            {
                if (juego.Genero == genero)
                    busqueda.Add (juego);
            }
        }
        public void PorCalificacion (string calificacion)
        {
            foreach (Juego juego in steam)
            {
                switch (calificacion)
                {
                    case "Alta":
                        if (juego.CalificacionGeneral () >= 4)
                            busqueda.Add (juego);
                        break;
                    case "Media":
                        if (juego.CalificacionGeneral () == 3)
                            busqueda.Add (juego);
                        break;
                    case "Baja":
                        if (juego.CalificacionGeneral () <= 2)
                            busqueda.Add (juego);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}