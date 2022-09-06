using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        private Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            _ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return _productos;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool dev = false;

            foreach(Producto producto in e.GetProductos())
            {
                if(producto.Equals(p))
                {
                    dev = true;
                    break;
                }
            }

            return dev;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            bool dev = true;

            foreach (Producto producto in e.GetProductos())
            {
                if (producto.Equals(p))
                {
                    dev = false;
                    break;
                }
            }

            return dev;
        }

        public static bool operator +(Estante e, Producto p)
        {
            if(e.GetProductos().Length > )
        }
    }
}
