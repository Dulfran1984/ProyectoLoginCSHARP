using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace Datos
{
    public class cls_Rol
    {
        private DataTable dt;
        public void fnt_CargarEstado()
        {
            string sql = "select PKCodigo,Descripcion from tbl_rol";
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