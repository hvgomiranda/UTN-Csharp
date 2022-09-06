using System.Text;
namespace Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto alfajor = new Producto(1, "Alfajor", 150, 100);
            Producto chupetin = new Producto(1, "Chupetin", 10, 65);

            int stockTotal = alfajor.Stock * alfajor.Precio + chupetin.Stock * chupetin.Precio;

            Console.WriteLine("Stock total {0}", stockTotal);

            int stockTotal2 = alfajor + chupetin;

            Console.WriteLine("Stock total {0}", stockTotal);
        }
    }

    public class Persona
    {
        private int _dni;
        private string _nombre;
        private string _legajo;

        public Persona()
        {
            _dni = 0;
            _nombre = "";
        }

        public Persona(string nombre)
        {
            _nombre = nombre;
        }

        public Persona(string nombre, int dni) : this(nombre)
        {
            _dni = dni;
        }

        public Persona(int dni, string nombre, string legajo) : this(nombre, dni)
        {
            _legajo = legajo;
        }
    }
    
    public class Producto
    {
        private int _id;
        private string _nombre;
        private int _precio;
        private int _stock;

        #region CONSTRUCTORES
        public Producto(int id)
        {
            _id = id;
            _nombre = "";
            _precio = 0;
            _stock = 0;
        }

        public Producto(int id, string nombre) : this(id)
        {
            _nombre = nombre;
            _precio = 0;
            _stock = 0;
        }

        public Producto(int id, string nombre, int precio) : this(id,nombre)
        {
            _precio = precio;
            _stock = 0;
        }

        public Producto(int id, string nombre, int precio, int stock) : this(id, nombre, precio)        {
            _stock = stock;
        }
        #endregion

        #region PROPS
        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public int Precio { get { return _precio; } set { _precio = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        #endregion

        #region METODOS
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("PRODUCTO");
            sb.Append("\t");
            sb.Append("ID");
            sb.Append("\t");
            sb.Append("NOMBRE");
            sb.Append("\t");
            sb.Append("PRECIO");
            sb.Append("\t");
            sb.Append("STOCK");
            sb.Append("\t");

        }

        public void Mostrar(ConsoleColor backColor)
        {
            Console.BackgroundColor = backColor;
            Mostrar();
        }

        #endregion

        #region SOBRECARGA
        public static int operator +(Producto p1, Producto p2)
        {
            return p1.Stock * p1.Precio + p2.Stock * p2.Precio;
        }

        public static int operator +(Producto p1, int n1)
        {
            return p1.Stock + n1;
        }

        public static bool operator ==(Producto p1, int id)
        {
            return p1.Id == id;
        }

        public static bool operator !=(Producto p1, int id)
        {
            return !(p1 == id); //sobrecarga de ==
        }

        public static implicit operator string(Producto p1)
        {
            return p1.Nombre;

            //string name = producto1;
        }

        #endregion
    }
}

/*

    getter y setter

    public int MyProperty 
    { 
        set {this.puertas = value;} 
        get {return this.puertas;} 
    }
    
    v1.MyProperty = 5;
    puertas2 = v1.MyProperty;

    sobrecarga
    
    Es una técnica que nos permitirá la reutilización de código y una mayor legibilidad
    Permite escribir varios métodos-constructores-operadores-indexadores de la misma manera
    
    métodos
    public int Sumar(int operando1, int operando2)
    public int Sumar(int operando1, int operando2, int operando3)

    constructores
    public Impresora()
    public Impresora(string marca, string modelo)
    

*/