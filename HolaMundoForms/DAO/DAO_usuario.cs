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
    class DAO_usuario
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

            Sys_usuario objetoTablaProducto = (Sys_usuario)elNuevoRegistro;

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
            instruccionSQL = "INSERT INTO sys_usuarios (" +
                "usuario, contrasenia, nombre_completo, tipo_usuario" +
                ") VALUES ( " +
                pcs(objetoTablaProducto.Usuario) + "," +
                pcs(objetoTablaProducto.Contrasenia) + "," +
                pcs(objetoTablaProducto.Nombre_completo) + "," +
                pcs(objetoTablaProducto.Tipo_usuario)  +
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
