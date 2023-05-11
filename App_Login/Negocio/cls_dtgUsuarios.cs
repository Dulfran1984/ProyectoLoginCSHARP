using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_dtgUsuarios
    {
        private DataTable dt;
        public void fnt_consultarUsuarios()
        {
            Datos.cls_dtgUsuarios objUsuarios = new Datos.cls_dtgUsuarios();
            objUsuarios.fnt_CargarUsuarios();
            this.dt = objUsuarios.getDataTable();
        }
        public DataTable dt_consultarUsuarios() { return  dt; }
    }
}