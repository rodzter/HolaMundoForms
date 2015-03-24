using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using HolaMundoForms.DB;
using System.Data;
using HolaMundoForms.BO;
namespace HolaMundoForms.DAO
{
    class DAO_proveedor
    {
        //PROPIEDADES
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsProductos = null;
        string instruccionSQL;
        MySqlCommand comandoMYSQL;
        MySqlDataAdapter datAdapterMYSQL;

        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS

        public int agregarNuevoRegistro(object elNuevoRegistro)
        {
            //CONVERTIMOS NUESTRO OBJETO GENERICO A UNO DE LA CLASE 

            Cat_proveedores objetoTablaProducto = (Cat_proveedores)elNuevoRegistro;

            //PREPARAMOS EL COMANDO DE MYSQL

            comandoMYSQL = new MySqlCommand();

            //PREPARAR EL DATASET
            dsProductos = new DataSet();

            //PREPARAR EL DATAADAPTER....
            datAdapterMYSQL = new MySqlDataAdapter();

            //ESTABLECER LA CONEXION
            comandoMYSQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            //ARMAR LA INSTRUCCION MYSQL: INSERT
            instruccionSQL = "INSERT INTO cat_proveedores (" +
                "razon_social, rfc, calle, num_exterior, num_interior, referencia, colonia, codigo_postal, municipio, estado, telefono, correo" +
                ") VALUES ( " +
                pcs(objetoTablaProducto.Razon_social) + "," +
                pcs(objetoTablaProducto.Rfc) + "," +
                pcs(objetoTablaProducto.Calle) + "," +
                pcs(objetoTablaProducto.Num_exterior) + "," +
                pcs(objetoTablaProducto.Num_interior) + "," +
                pcs(objetoTablaProducto.Referencia) + "," +
                pcs(objetoTablaProducto.Colonia) + "," +
                pcs(objetoTablaProducto.Codigo_postal) + "," +
                pcs(objetoTablaProducto.Municipio) + "," +
                pcs(objetoTablaProducto.Estado) + "," +
                pcs(objetoTablaProducto.Telefono) + "," +
                pcs(objetoTablaProducto.Correo)+
                ")";

            comandoMYSQL.CommandText = instruccionSQL;

            int resultadodelComando = comandoMYSQL.ExecuteNonQuery();

            if (resultadodelComando <= 0)
            {
                return 0; //HAY UN ERROR
            }



            return 1;
        }

        public String pcs(string Valor)
        {
            return "'" + Valor + "'";
        }
    }
}
