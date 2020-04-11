using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            int selec=0;
            Camara vidrio_molido=new Camara(1,25);
            Camara vidrio_roto= new Camara(2,30);
            Celular ladrillo=new Celular(false, false, 1024, 10, vidrio_molido, vidrio_roto);
            while (selec!=3)
            {
                Console.Write("\n\n1 - Consultar memoria disponible\n2 - Consultar si el telefono te carga la SUBE");
                Console.Write("\n3 - Salir");
                

                Console.Write("\nIngrese una seleccion: ");
                selec=Int32.Parse(Console.ReadLine());

                switch (selec)
                {
                    case 1:
                        Console.Write("La memoria disponible es de "+ladrillo.MemoriaDisponible()+"MB");
                        break;
                    case 2:
                        Console.Write(ladrillo.TeCargaLaSUBE()?"Su celular es apto para cargar la SUBE":"Su celular es un ladrillo");
                        break;
                    default:
                        if (selec!=3)
                            Console.Write("Seleccion no valida");
                        break;
                }
            }
        }
    }
    class Celular
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
    class Camara
    {
        int megapixeles;
        int cantidadfotos;
        public Camara(int megapixeles, int cantidadfotos)
        {
            this.megapixeles=megapixeles;
            this.cantidadfotos=cantidadfotos;
        }
        public int pesoPorFoto()
        {
            return megapixeles*3;
        }
        public int PesoTotalDeFotos()
        {
            return this.pesoPorFoto()*cantidadfotos;
        }
    }
}
