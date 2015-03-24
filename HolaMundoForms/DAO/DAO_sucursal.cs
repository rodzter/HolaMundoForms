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
    class DAO_sucursal
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

            Cat_sucursales objetoTablaProducto = (Cat_sucursales)elNuevoRegistro;

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
            instruccionSQL = "INSERT INTO cat_sucursales (" +
                "codigo, nombre_sucursal, direccion, responsable" +
                ") VALUES ( " +
                pcs(objetoTablaProducto.Codigo) + "," +
                pcs(objetoTablaProducto.Nombre_sucursal) + "," +
                pcs(objetoTablaProducto.Direccion) + "," +
                pcs(objetoTablaProducto.Responsable)  +
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
