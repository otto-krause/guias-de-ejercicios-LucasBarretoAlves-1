using System;
using System.Collections.Generic;
namespace E5
{
    public class Carrito
    {
        public List <Producto> contenidos = new List<Producto>();
        public Carrito(int modif)
        {
            Producto p1= new Producto("Producto 1",1+modif);
            Producto p2= new Producto("Producto 2",5+modif);
            Producto p3= new Producto("Producto 3",2+modif);
            contenidos.Add(p1);
            contenidos.Add(p2);
            contenidos.Add(p3);
        }
    }
}