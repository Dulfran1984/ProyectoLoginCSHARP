using Datos;
using System;

namespace Negocio
{
    public class cls_Login
    {
        private string str_nombre;
        private string str_estado;
        private string str_rol;
        private string str_msn;
        public cls_Login(string user, string password)
        {
            if(user == "" || password == "")
            {
                this.str_msn = "Ingrese la información requerida";
            }
            else
            {
                Datos.cls_Login obj_Login = new Datos.cls_Login();
                obj_Login.fnt_ConsultarU(user, password);
                this.str_estado = obj_Login.getEstado();
                this.str_nombre = obj_Login.getNombre();
                this.str_rol = obj_Login.getRol();
                this.str_msn = obj_Login.getMsn();
            }
        }
        public string getNombre() { return this.str_nombre; }
        public string getEstado() { return this.str_estado; }
        public string getRol() { return this.str_rol; }
        public string getMsn() { return this.str_msn; }
    }
}