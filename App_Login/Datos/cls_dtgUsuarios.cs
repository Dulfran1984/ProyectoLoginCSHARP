using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_dtgUsuarios
    {
        private DataTable dt;
        public void fnt_CargarUsuarios()
        {
            string sql = "select tbl_personas.Nombre as 'Persona', tbl_usuarios.PKCorreo as 'Usuario', tbl_estado.Descripcion as 'Estado', tbl_rol.Descripcion as 'Rol' from tbl_usuarios,tbl_personas,tbl_estado,tbl_rol where tbl_rol.PKCodigo = tbl_usuarios.FKCodigo_tbl_rol and tbl_estado.PKCodigo = tbl_usuarios.FKCodigo_tbl_estado and tbl_personas.PKId = tbl_usuarios.FKId_tbl_personas";
            cls_Conexion objConecta = new cls_Conexion();
            objConecta.fnt_conectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objConecta.conex);
                dt = new DataTable();
                MySqlDataAdapter Data = new MySqlDataAdapter(comando);
                Data.Fill(dt);
            }
            catch (Exception)
            {
                objConecta.fnt_Desconectar();
            }
        }
        public DataTable getDataTable() { return dt; }
    }
}