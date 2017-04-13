using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeInventarios
{
    public partial class Form1 : Form
    {
        Producto miProducto;
        Inventario miInventario = new Inventario();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool existe = miInventario.eliminarProducto(Convert.ToInt16(txtEliminar.Text));

            if (txtEliminar.Text == "")
            {
                MessageBox.Show("Ingrese el número del elemento a eliminar.");
            }
            else if(existe == false)
            {
                MessageBox.Show("No existe el producto con el código: " + txtEliminar.Text);
            }
            else
            {
                miInventario.eliminarProducto(Convert.ToInt16(txtEliminar.Text));
                MessageBox.Show("Producto eliminado");
                txtEliminar.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            miInventario.insertarProducto(miProducto, Convert.ToInt16(txtPosicion.Text));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            miProducto = new Producto(Convert.ToInt16(txtCodigo.Text), txtNombre.Text, Convert.ToInt16(txtCantidad.Text), Convert.ToInt16(txtCosto.Text));
            bool inventario = miInventario.agregarProducto(miProducto);

            if(inventario == true)
            {
                miInventario.agregarProducto(miProducto);
            }
            else
            {
                MessageBox.Show("Ya existe un producto con el código: " + txtCodigo.Text);
            }

            txtCodigo.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtCosto.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtReporte.Text = miInventario.ToString();
        }

        private void btnBuscarPorCodigo_Click(object sender, EventArgs e)
        {
            txtReporte.Text = miInventario.buscarProducto(Convert.ToUInt16(txtBuscarPorCodigo.Text));
        }
    }
}
