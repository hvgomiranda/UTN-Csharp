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

        public string getMarca()
        {
            return _marca;
        }

        public float getPrecio()
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
            return p._marca == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p._marca == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1 == p2;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator string(Producto p)
        {
            return p._codigoDeBarra;
        }
        #endregion
    }
}
