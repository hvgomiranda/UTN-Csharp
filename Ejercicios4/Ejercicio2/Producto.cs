using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;

        public Producto(string marca, string codigo, float precio)
        {
            _marca = marca;
            _codigoDeBarra = codigo;
            _precio = precio;
        }

        public string GetCodigoDeBarras()
        {
            return _codigoDeBarra;
        }

        public string GetMarca()
        {
            return _marca;
        }

        public float GetPrecio()
        {
            return _precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{p._marca}");
            sb.Append("\t");
            sb.Append($"{p._codigoDeBarra}");
            sb.Append("\t");
            sb.Append($"{p._precio}");

            return sb.ToString();
        }

        #region SOBRECARGA
        public static bool operator ==(Producto p, string marca)
        {
            bool dev = false;
            if (p is not null)
            {
                dev = (p._marca == marca);
            }
            return dev;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool dev = false;
            if (p1 is not null && p2 is not null)
            {
                dev = (p1._marca == p2._marca && p1._codigoDeBarra == p2._codigoDeBarra);
            }
            return dev;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" ");
            if (p is not null)
            {
                sb.Clear();
                sb.Append($"{p._codigoDeBarra}");
            }
            return sb.ToString();
        }

        #endregion
    }
}
