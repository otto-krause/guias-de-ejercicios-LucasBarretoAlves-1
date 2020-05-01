using System;
using System.Collections.Generic;
namespace E7
{
    public class Argentina
    {
        List <Alfajor> alfajores = new List <Alfajor>();
        public Argentina()
        {
            Alfajor triplefruta = new Alfajor("Triple Fruta", 50, "Wuaymayen");
            Alfajor simplechoco = new Alfajor("Simple chocolate", 200, "Jabana");
            Alfajor mani = new Alfajor("Mani", 2, "Fulbito");
            alfajores.Add(triplefruta);
            alfajores.Add(simplechoco);
            alfajores.Add(mani);
        }
        public void BajarPetroleo()
        {
            foreach (Alfajor alfajor in alfajores)
            {
                alfajor.Subida(1);
            } 
        }
        public void MillaiHablaPorTV ()
        {
            foreach (Alfajor alfajor in alfajores)
            {
                alfajor.Subida(2);
            } 
        }
        public void CoronaVairas ()
        {
            foreach (Alfajor alfajor in alfajores)
            {
                if (alfajor.Empresa!="Waymayen")
                    alfajor.Subida(3);
            } 
        }
        public int PrecioGlobal()
        {
            int suma=0;
            foreach (Alfajor alfajor in alfajores)
            {
                suma+=alfajor.Precio;
            }
            return suma;
        }
        public bool UnProductor()
        {
            string productor=null;
            bool unaSola=false;
            foreach (Alfajor alfajor in alfajores)
            {
                if (productor==null)
                    productor=alfajor.Empresa;
                unaSola=(productor==alfajor.Empresa)? true : false;

            }
            return (unaSola)? true : false;
        }
    }
}