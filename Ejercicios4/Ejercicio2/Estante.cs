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

        public Producto[] Productos
        {
            get { return _productos; }
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Producto p in e.Productos)
            {
                sb.AppendLine(Producto.MostrarProducto(p));
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool dev = false;

            foreach(Producto producto in e.Productos)
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
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool sePuedeAgregar = false;
            int tam = e.Productos.Length;
            for(int i=0; i <tam; i++)
            {
                if (e.Productos[i] is null)
                {
                    e.Productos[i] = p;
                    sePuedeAgregar = true;
                    break;
                }
            }
            return sePuedeAgregar;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                int conteo = 0;
                foreach(Producto producto in e.Productos)
                {
                    if(producto == p)
                    {
                        e.Productos[conteo] = null;
                        break;
                    }
                    conteo++;
                }
            }
            return e;
        }

    }
}
