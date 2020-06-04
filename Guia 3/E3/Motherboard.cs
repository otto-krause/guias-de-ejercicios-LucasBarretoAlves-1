using System;
using System.Collections.Generic;
namespace E3
{
    public class Motherboard : Componente
    {
        private int costo;
        public int Costo { get => costo; }
        private string modeloRam;
        public string ModeloRam { get => modeloRam; }
        private int ramSoportada;
        public int RamSoportada { get => ramSoportada; }
        private string arquitecturaDeMemoria;
        public string ArquitecturaDeMemoria { get => arquitecturaDeMemoria; }
        private int maximofrecuencia;
        public int Maximofrecuencia { get => maximofrecuencia; }
        private int minimofrecuencia;
        public int Minimofrecuencia { get => minimofrecuencia; }
        private string cableDeInterconexion;
        public string CableDeInterconexion { get => cableDeInterconexion; }
        private string ranuraDeExpansion;
        public string RanuraDeExpansion { get => ranuraDeExpansion; }
       
        public Motherboard (int precio, string modeloRam, int ramSoportada, string arquitecturaDeMemoria,
            int maximofrecuencia, int minimofrecuencia, string ranuraDeExpansion, string cableDeInterconexion)
        {
            this.costo = precio;
            this.modeloRam = modeloRam;
            this.ramSoportada = ramSoportada;
            this.arquitecturaDeMemoria = arquitecturaDeMemoria;
            this.maximofrecuencia=maximofrecuencia;
            this.minimofrecuencia=minimofrecuencia;
            this.ranuraDeExpansion = ranuraDeExpansion;
            this.cableDeInterconexion = cableDeInterconexion;

        }
        public int Precio ()
        {
            return costo;
        }
        public bool EsCompatible (Motherboard mother)
        {
            return true;
        }
    }
}