using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.IO;

namespace Datos
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
        public void fnt_Consultar(string str_id)
        {
            try
            {
                String sql = "select tbl_personas.Nombre as 'Nombre', tbl_personas.Apellido as 'Apellido', tbl_personas.Contacto as 'Contacto', tbl_personas.Correo as 'Correo', tbl_usuarios.FKCodigo_tbl_estado as 'Estado',tbl_usuarios.FKCodigo_tbl_rol as 'Rol' from tbl_usuarios, tbl_personas where tbl_personas.PKId = tbl_usuarios.FKId_tbl_personas and tbl_personas.PKId = '" + str_id + "'";
                cls_Conexion obj_Conectar = new cls_Conexion();
                obj_Conectar.fnt_conectar();

                MySqlCommand comando = new MySqlCommand(sql, obj_Conectar.conex);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    str_nombre = reader["Nombre"].ToString();
                    str_apellido = reader["Apellido"].ToString();
                    str_contacto = reader["Contacto"].ToString();
                    str_correo = reader["Correo"].ToString();
                    int_estado = Convert.ToInt16(reader["Estado"].ToString());
                    int_rol = Convert.ToInt16(reader["Rol"].ToString());
                    this.str_msn = "";
                }
                obj_Conectar.fnt_Desconectar();
            }
            catch (Exception) { this.str_msn = "No se encontraron registros / No hay conexión"; }
        }
        public string getMensaje() { return this.str_msn; }
        public string getNombre() { return this.str_nombre; }
        public string getApellido() { return this.str_apellido; }
        public string getContacto() { return  this.str_contacto; }
        public string getCorreo() { return  this.str_correo; }
        public int getEstado() { return this.int_estado; }
        public int getRol() { return this.int_rol; }
    }
}