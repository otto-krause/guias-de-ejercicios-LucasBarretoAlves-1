using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Niño : Participante_s
    {
        protected List<ElementoSusto> elementos;
        protected int actitud;

        protected bool estaEmpachado;
        protected bool estaEnCama;        

        public Niño(List<ElementoSusto> elementos, int actitud, int caramelos)
        {
            this.elementos = elementos;
            this.actitud = actitud;
            this.caramelos = caramelos;
        }

        public override int CapacidadDeAsustar()
        {
            int actitudF = estaEnCama ? 0 : estaEmpachado ? actitud/2 : actitud;  //Variable usada para aplicar punto D(Alimentación)
            
            return elementos.Sum(elemento => elemento.SustoCausado()) * actitudF;
        }

    
        public override void Asustar(Adulto adulto)
        {
            RecibirCaramelos( adulto.IntentoDeSusto( CapacidadDeAsustar(), MasDe15Caramelos() ) );
        }

        public void ComerCaramelos (int cantidad)
        {
            estaEmpachado = caramelos >= cantidad && cantidad > 10 ? true : false ;
            caramelos = caramelos >= cantidad && !estaEnCama ? caramelos - cantidad : 0;
            
        }

        
    }
}