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
            if(id == "")
            {
                this.str_msn = "Debe ingresar el criterio de busqueda";
            }
            else
            {
                Datos.cls_ConsultarPersona obj_Consultar = new Datos.cls_ConsultarPersona();
                obj_Consultar.fnt_Consultar(id);
                str_nombre = obj_Consultar.getNombre();
                str_apellido = obj_Consultar.getApellido();
                str_contacto = obj_Consultar.getContacto();
                str_correo = obj_Consultar.getCorreo();
                int_estado = obj_Consultar.getEstado();
                int_rol = obj_Consultar.getRol();
                this.str_msn = obj_Consultar.getMensaje();
            }
        }
        public string get_nombre() { return str_nombre; }
        public string get_apellido() {  return str_apellido; }
        public string get_contacto() {  return str_contacto; }
        public string get_correo() {  return str_correo; }
        public int get_estado() {  return int_estado; }
        public int getrol() { return int_rol; }
        public string getMensaje() { return  this.str_msn; }
    }
}