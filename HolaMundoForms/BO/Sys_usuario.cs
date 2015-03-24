using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HolaMundoForms.BO
{
    class Sys_usuario
    {
        //PROPIEDADES DE LA TABLA
        long id;
        string usuario;
        string contrasenia;
        string nombre_completo;
        string tipo_usuario;

        //METODOS DE ACCESO 
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public string Nombre_completo
        {
            get { return nombre_completo; }
            set { nombre_completo = value; }
        }

        public string Tipo_usuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }



    }

}
