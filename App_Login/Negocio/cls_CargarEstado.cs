using System;
using Datos;
using System.Data;
namespace Negocio
{
    public class cls_CargarEstado
    {
        private DataTable dt;
        public void fnt_CargarEstado()
        {
            Datos.cls_CargarEstado obj_Estado = new Datos.cls_CargarEstado();
            obj_Estado.fnt_CargarEstado();
            dt = obj_Estado.getDataTable();
        }
        public DataTable getDatatable() { return  dt; }
    }
}