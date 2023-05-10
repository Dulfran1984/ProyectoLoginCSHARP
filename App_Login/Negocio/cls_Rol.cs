using System;
using System.Data;

namespace Negocio
{
    public class cls_Rol
    {
        private DataTable dt;
        public void fnt_CargarRol()
        {
            Datos.cls_Rol obj_Rol = new Datos.cls_Rol();
            obj_Rol.fnt_CargarEstado();
            dt = obj_Rol.getDataTable();
        }
        public DataTable getDatatable() { return dt; }
    }
}