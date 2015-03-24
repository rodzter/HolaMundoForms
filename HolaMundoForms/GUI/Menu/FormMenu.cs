using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolaMundoForms.Catalogos;
namespace HolaMundoForms.GUI.Menu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Usuario Ventana_Usuario = new Usuario();
            Ventana_Usuario.ShowDialog();
            Ventana_Usuario.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            FormProductos Ventana_Productos = new FormProductos();

            Ventana_Productos.ShowDialog();
            Ventana_Productos.Dispose();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes Ventana_clientes = new Clientes();
            Ventana_clientes.ShowDialog();
            Ventana_clientes.Dispose();
        }

        private void btn_almacen_Click(object sender, EventArgs e)
        {
            Almacen Ventana_Almacen = new Almacen();
            Ventana_Almacen.ShowDialog();
            Ventana_Almacen.Dispose();
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Proveedores Ventana_Proveedores = new Proveedores();
            Ventana_Proveedores.ShowDialog();
            Ventana_Proveedores.Dispose();
        }

        private void btn_sucursales_Click(object sender, EventArgs e)
        {
            Sucursales Ventana_Sucursales = new Sucursales();
            Ventana_Sucursales.ShowDialog();
            Ventana_Sucursales.Dispose();
        }
    }
}
