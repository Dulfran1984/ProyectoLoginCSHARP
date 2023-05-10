using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Datos
{
    public class cls_Login
    {
        private string str_nombre;
        private string str_estado;
        private string str_rol;
        private string str_msn;
        public void fnt_ConsultarU(string usuario, string contraseña)
        {
                cls_Conexion obj_Conectar = new cls_Conexion();
                obj_Conectar.fnt_conectar();
                string SQLbuscar;
                SQLbuscar = "select tbl_personas.Nombre as NombrePersona, tbl_estado.Descripcion as Estado , tbl_rol.Descripcion as Rol from tbl_personas,tbl_estado,tbl_rol,tbl_usuarios where tbl_estado.PKCodigo = tbl_usuarios.FKCodigo_tbl_estado and tbl_rol.PKCodigo = tbl_usuarios.FKCodigo_tbl_rol and tbl_usuarios.PKCorreo = '"+usuario+"' and tbl_usuarios.Contraseña = '"+contraseña+ "' and tbl_estado.PKCodigo = '1' and tbl_personas.PKId = tbl_usuarios.FKId_tbl_personas";
                MySqlCommand cmd = new MySqlCommand(SQLbuscar, obj_Conectar.conex);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader lectura = cmd.ExecuteReader();
                if (lectura.Read() == true)
                {
                    str_nombre = lectura["NombrePersona"].ToString();
                    str_estado = lectura["Estado"].ToString();
                    str_rol = lectura["Rol"].ToString();
                    this.str_msn = "";
                }
                else
                {
                    this.str_msn = "Credenciales de acceso no validas";
                }
                obj_Conectar.fnt_Desconectar();
        }
        public string getNombre() { return this.str_nombre; }
        public string getEstado() { return this.str_estado; }
        public string getRol() { return this.str_rol; }
        public string getMsn() { return this.str_msn; }
    }
}