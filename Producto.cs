using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeInventarios
{
    class Producto
    {
        private int _codigo;
        private string _nombre;
        private int _cantidad;
        private int _costo;

        public Producto(int codigo, string nombre, int cantidad, int costo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.costo = costo;
        }

        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public int costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        public override string ToString()
        {
            string mostrar = "";

            mostrar = "Codigo: " + _codigo + " Nombre: " + _nombre + " Cantidad: " + _cantidad + " Costo: " + _costo + "\r\n";
            return mostrar;
        }
    }
}
