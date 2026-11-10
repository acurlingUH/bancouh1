using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace bancouh1.CapaDatos
{
    public class Cls_Usuarios
    {
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Cls_Usuarios(string correo, string clave, string nombre)
        {
            this.correo = correo;
            this.clave = clave;
            this.nombre = nombre;
        }

        public  Cls_Usuarios () { }

    }
}