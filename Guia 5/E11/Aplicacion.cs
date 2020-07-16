using System;
using System.Linq;
using System.Collections.Generic;
namespace E11
{
    public class Aplicacion
    {
        protected string nombre;
        protected int tiempoDeUso;
        protected int cantidadDeToquesEnLaPantalla;
        protected List<string> permisos;
        protected int tiempoDeUsoDelTeclado;
        public Aplicacion(string nombre, int tiempoDeUso, int cantidadDeToquesEnLaPantalla, List <string> permisos, int tiempoDeUsoDelTeclado)
        {
            this.nombre=nombre;
            this.tiempoDeUso=tiempoDeUso;
            this.cantidadDeToquesEnLaPantalla=cantidadDeToquesEnLaPantalla;
            this.permisos=permisos;
            this.tiempoDeUsoDelTeclado=tiempoDeUsoDelTeclado;
        }
        public string Nombre {get => nombre;}
        public List<string> Permisos {get => permisos;}

        public int Interaccion()
        {
            return cantidadDeToquesEnLaPantalla/tiempoDeUso;
        }

        public int InteraccionConElTeclado()
        {
            return tiempoDeUsoDelTeclado/tiempoDeUso;
        }
            
    }
}