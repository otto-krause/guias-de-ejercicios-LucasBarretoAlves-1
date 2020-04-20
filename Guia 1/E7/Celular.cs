namespace E7
{
    public class Celular
    {
        bool NFC;
        bool Bluetooth;
        int almacenamiento;
        int aplicaciones;
        Camara camara;
        Camara camara2;
        public Celular(bool NFC, bool Bluetooth, int almacenamiento, int aplicaciones,Camara camara, Camara camara2)
        {
            this.NFC=NFC;
            this.Bluetooth=Bluetooth;
            this.almacenamiento=almacenamiento;
            this.aplicaciones=aplicaciones;
            this.camara=camara;
            this.camara2=camara2;
        }

        public  int MemoriaDisponible()
        {
            return almacenamiento -(camara.PesoTotalDeFotos()+camara2.PesoTotalDeFotos()+aplicaciones*70);
        }

        public bool TeCargaLaSUBE()
        {
            return NFC;
        }
    }
    
}