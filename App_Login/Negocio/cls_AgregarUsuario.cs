using System;
using Datos;
namespace Negocio
{
    public class cls_AgregarUsuario
    {
        private string str_msn;
        private string str_id;
        private string str_nombre;
        private string str_apellido;
        private string str_contacto;
        private string str_correo;
        private int int_estado;
        private int int_rol;
        private int int_tipoMensaje;

        public cls_AgregarUsuario(string str_id, string str_nombre, string str_apellido, string str_contacto, string str_correo, int int_estado, int int_rol)
        {
            this.str_id = str_id;
            this.str_nombre = str_nombre;
            this.str_apellido = str_apellido;
            this.str_contacto = str_contacto;
            this.str_correo = str_correo;
            this.int_estado = int_estado;
            this.int_rol = int_rol;
            if(str_id == "" || str_nombre == "" || str_contacto == "" || str_apellido == "" || str_correo == "")
            {
                this.str_msn = "Debe ingresar toda la información requerida";
                int_tipoMensaje = 0;
            }
            else
            {
                Datos.cls_AgregarUsuario obj_Agregar = new Datos.cls_AgregarUsuario(str_id, str_nombre, str_apellido, str_contacto, str_correo, int_estado, int_rol);
                int_tipoMensaje= obj_Agregar.getTipoMensaje();
                this.str_msn = obj_Agregar.getstrMsn();
            }
        }
        public string getMensaje() {return this.str_msn;}
        public int getTipoMensaje() { return  this.int_tipoMensaje;}
    }
}