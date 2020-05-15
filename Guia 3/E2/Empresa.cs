using System;
using System.Collections.Generic;
namespace E2
{
    public class Empresa
    {
        private int presupuesto;
        public int Presupuesto {get => presupuesto;}
        private int horasDeTrabajo;
        private List<Contratista> lista = new List<Contratista>();
        private int total;
    
        public Empresa(int presupuesto, int horasDeTrabajo)
        {
            this.presupuesto=presupuesto;
            this.horasDeTrabajo=horasDeTrabajo;
            this.total=0;
            Pintor juanperez = new Pintor();
            Pintor carlosgomez = new Pintor();
            Pintor joseaguirre = new Pintor();
            Pintor leandroseca = new Pintor();
            Plomero sebastianvega = new Plomero();
            Plomero lucassandoval = new Plomero();
            Plomero facundorafo = new Plomero();
            Plomero marianolago = new Plomero();
            Albanil ernestoquiroga = new Albanil(20, true);
            Albanil estebanquito = new Albanil(31, false);
            Albanil armandoparedes = new Albanil(50, true);
            Albanil ramonvilla = new Albanil(85, true);
            Albanil manuelnaro = new Albanil(40, false);
            Albanil estanislaopato = new Albanil(15, false);
            Albanil trabajador = new Albanil(8, true);
            lista.Add(juanperez);
            lista.Add(carlosgomez);
            lista.Add(joseaguirre);
            lista.Add(leandroseca);
            lista.Add(sebastianvega);
            lista.Add(lucassandoval);
            lista.Add(facundorafo);
            lista.Add(marianolago);
            lista.Add(ernestoquiroga);
            lista.Add(estebanquito);
            lista.Add(armandoparedes);
            lista.Add(ramonvilla);
            lista.Add(manuelnaro);
            lista.Add(estanislaopato);
            lista.Add(trabajador);
        }

        public int GastoTotal()
        {
            foreach (Contratista contratista in lista)
            {
                contratista.Trabajar(horasDeTrabajo);
                total+=(contratista.Cobrar());
            }
            return total;
        }
        
    }
}