using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolaMundoForms.DAO;
using HolaMundoForms.BO;
namespace HolaMundoForms.Catalogos
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        private bool HAY_DATOS_VACIOS_EN_TEXTBOXES()
        {
            bool HAY_TEXTBOX_VACIOS = false;
            foreach (Control ctrl in this.Controls) //PARA CADA CONTROL DENTRO DEL FORMULARIO
            {
                if ((object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox))) &
               (!HAY_TEXTBOX_VACIOS))
                {
                    if (ctrl.Text.Trim() == String.Empty)
                    {
                        HAY_TEXTBOX_VACIOS = true;
                        break;
                    }
                }
            }
            return HAY_TEXTBOX_VACIOS;
        }
        public void VALIDA_CARACTERES_EN_TEXTBOXES(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case
                '\'': //COMILLA SENCILLA
                    e.Handled = true;
                    break;
                case
                '\\': // DIAGONAL INVERTIDA
                    e.Handled = true;
                    break;
                case
                'à':
                    e.Handled = true;
                    break;
                case
                'È':
                    e.Handled = true;
                    break;
                case
                '`':
                    e.Handled = true;
                    break;
                case
                '´':
                    e.Handled = true;
                    break;
                case
                '&':
                    e.Handled = true;
                    break;
                case
                'û':
                    e.Handled = true;
                    break;
                case
                '^':
                    e.Handled = true;
                    break;
                case
                '|':
                    e.Handled = true;
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }
        public void ENVIAR_DATOS_NUEVO_REGISTRO()
        {
            int i = 0;
            //NUEVO OBJETO DE LA CLASE PRODUCTO de la carpeta BO (Cat_productos)
            Cat_clientes oProducto = new Cat_clientes();
            //Nuevo OBJETO DE LA CLASE DAO_producto de la carpeta DAO
            DAO_cliente oProductoDAO = new DAO_cliente();
            //LLENAR PROPIEDADES DEL OBJETO PRODUCTO, CON CADA DATO CAPTURADO EN LA PANTALLA
            //Objeto.Propiedad = Pantalla.ComponenteVisual.Valor;
            oProducto.Rfc = this.txt_Rfc.Text.Trim();
            oProducto.Razon_social = this.txt_Razon_Social.Text.Trim();
            oProducto.Calle = this.txt_Calle.Text.Trim();
            oProducto.Num_exterior = this.Txt_num_exterior.Text.Trim();
            oProducto.Num_interior = this.txt_num_interior.Text.Trim();
            oProducto.Referencia = this.txt_Referencia.Text.Trim();
            oProducto.Colonia = this.txt_colonia.Text.Trim();
            oProducto.Codigo_postal = this.txt_CP.Text.Trim();
            oProducto.Municipio = this.txt_munucipio.Text.Trim();
            oProducto.Estado = this.txt_estado.Text.Trim();
            oProducto.Telefono = this.txt_telefono.Text.Trim();
            oProducto.Correo = this.txt_mail.Text.Trim();
            //LLAMAMOS AL METODO DE LA CLASE DAO QUE HACE EL INSERT, le enviamos como parametro el objeto oProducto que
            //ya llenamos con los valores de la pantalla
            i = oProductoDAO.agregarNuevoRegistro(oProducto);
            //VERIFICAMOS SI SE HA EJECUTADO CORRECTAMENTE LA ACCION SOLICITADA
            if (i == 0)
            {
                MessageBox.Show("El proceso no se pudo realizar");
            }
            else
            {
                MessageBox.Show("El proceso se genero con éxito");
            }
            //MATAMOS A LOS OBJETOS UTILIZADOS
            oProducto = null;
            oProductoDAO = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_AGREGAR_REGISTRO_Click(object sender, EventArgs e)
        {
            if (HAY_DATOS_VACIOS_EN_TEXTBOXES()) //SI FALTA POR CAPTURAR UN DATO
 {
 MessageBox.Show("Hay datos sin capturar, favor de revisar su pantalla de datos.", "Error",
 MessageBoxButtons.OK, MessageBoxIcon.Stop);
 }
 else
 {
 DialogResult dr = MessageBox.Show("¿Desea continuar y agregar un nuevo registro?.", "Agregar Nuevo Registro", MessageBoxButtons.YesNo);
 switch (dr)
 {
 case DialogResult.Yes:
 ENVIAR_DATOS_NUEVO_REGISTRO();
this.Close();
break;
 case DialogResult.No:
 break;
 }
 }
        }
    }
}
