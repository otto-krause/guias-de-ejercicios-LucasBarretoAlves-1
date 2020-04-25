using System;
using System.Collections.Generic;
namespace E5
{
    public class Supermercado
    {
        List <Carrito> ventas = new List <Carrito>();
        public Supermercado()
        {
            Carrito v1 = new Carrito(2);
            Carrito v2 = new Carrito(1);
            Carrito v3 = new Carrito(8);
            ventas.Add(v1);
            ventas.Add(v2);
            ventas.Add(v3);
        }
        public int Ventas()
        {
            int acu=0;
            foreach (Carrito venta in ventas)
            {
                foreach (Producto prod in venta.contenidos)
                {
                    acu+=prod.precio;
                }
            }
            return acu;
        }
    }
}