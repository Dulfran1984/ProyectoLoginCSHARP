using System;
using Datos;
namespace Negocio
{
    public class cls_ConsultarPersona
    {
        private string str_nombre;
        private string str_apellido;
        private string str_contacto;
        private string str_correo;
        private int int_estado;
        private int int_rol;
        private string str_msn;
        public void fnt_Consultar(string id)
        {
            Datos.cls_ConsultarPersona obj_Consultar = new Datos.cls_ConsultarPersona();
            obj_Consultar.fnt_Consultar(id);
            str_nombre = obj_Consultar.getNombre();
            str_apellido = obj_Consultar.getApellido();
            str_contacto = obj_Consultar.getContacto();
            str_correo = obj_Consultar.getCorreo();
            int_estado = obj_Consultar.getEstado();
            int_rol = obj_Consultar.getRol();
            str_msn = obj_Consultar.getMensaje();
        }
    }
}