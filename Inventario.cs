using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeInventarios
{
    class Inventario
    {
        Producto producto;
        private Producto[] _Inventario;
        private int _contador;
        Producto auxiliar;

        public Inventario()
        {
            _Inventario = new Producto[15];
            _contador = 0;
        }

        public bool agregarProducto(Producto producto)
        {
            bool agregar = true;

            for (int i = 0; i < _contador; i++)
            {
                if (producto.codigo == _Inventario[i].codigo)
                {
                    agregar = false;
                }
            }

            if (_contador < 15 && agregar == true)
            {
                _Inventario[_contador] = producto;
                _contador++;
            }

            return agregar;
        }

        public bool eliminarProducto(int posicion)
        {
            bool existe = true;

            for (int i = 0; i < _contador; i++)
            {
                if (_Inventario[i].codigo == posicion)
                {
                    while (i < _contador)
                    {
                        _Inventario[i] = _Inventario[i + 1];
                        i++;
                    }
                    _Inventario[_contador] = null;
                    _contador--;
                }
                else
                {
                    existe = false;
                }
            }
            return existe;
        }

        public string buscarProducto(int posicion)
        {
            string mostrar = "";
            for (int i = 0; i < _contador; i++)
            {
                if (posicion - 1 == i)
                {
                    mostrar = _Inventario[i].ToString();
                }
            }
            return mostrar;
        }

        public void insertarProducto(Producto producto, int posicion)
        {
            Producto producto2;
            posicion = posicion - 1;
            _contador++;

            for (int i = posicion; i <_contador; i++)
            {
                //_Inventario[i] = _Inventario[i - 1];
                auxiliar = _Inventario[i];
                _Inventario[i] = producto;
                producto = auxiliar;
            }
            //_contador++;
            //_Inventario[posicion] = producto;
        }

        public override string ToString()
        {
            string mostrar = "";
            for (int i = 0; i < _contador; i++)
            {
                mostrar += _Inventario[i].ToString();
            }
            return mostrar;
        }
    }
}
