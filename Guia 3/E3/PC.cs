using System;
using System.Collections.Generic;
namespace E3
{
    public class PC
    {
        private Motherboard mother;
        private DiscoHDD discoduro;
        private DiscoSSD discosolido;
        private LectoraDeCD lectora;
        private MemoriaRam ram;
        private PlacaDeVideo placavideo;
        private List<Componente> pc = new List<Componente> ();

        public PC (Motherboard mother, DiscoHDD discoduro, DiscoSSD discosolido, LectoraDeCD lectora,
            MemoriaRam ram, PlacaDeVideo placavideo)
        {
            this.mother = mother;
            this.discoduro = discoduro;
            this.discosolido = discosolido;
            this.lectora = lectora;
            this.ram = ram;
            this.placavideo = placavideo;
            pc.Add(mother);
            pc.Add(discoduro);
            pc.Add(discosolido);
            pc.Add(lectora);
            pc.Add(ram);
            pc.Add(placavideo);
            
        }
        public int PrecioTotal()
        {
            int total=0;
            foreach (Componente componente in pc)
            {
                total += componente.Precio();
            }
            return total;
        }
        public bool SePuedeArmar()
        {
            foreach (Componente componente in pc)
            {
                if (!componente.EsCompatible(mother))
                    return false;
            }
            return true;
        }
    }
}