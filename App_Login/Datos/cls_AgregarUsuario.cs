using MySql.Data.MySqlClient;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Datos
{
    public class cls_AgregarUsuario
    {
        private string str_msn;
        private string str_id;
        private string str_nombre;
        private string str_apellido;
        private string str_contacto;
        private string str_correo;
        private int int_estado;
        private int int_rol;
        private int int_tipoMensaje;
        cls_Conexion obj_conexion = new cls_Conexion();

        public cls_AgregarUsuario(string str_id, string str_nombre, string str_apellido, string str_contacto, string str_correo, int int_estado, int int_rol)
        {
            obj_conexion.fnt_conectar();
            this.str_id = str_id;
            this.str_nombre = str_nombre;
            this.str_apellido = str_apellido;
            this.str_contacto = str_contacto;
            this.str_correo = str_correo;
            this.int_estado = int_estado;
            this.int_rol = int_rol;
            fnt_RegistrarPersona();
            obj_conexion.fnt_Desconectar();
        }

        public void fnt_RegistrarPersona()
        {
            try
            {
                string comando = "insert into tbl_personas values " +
                "(@PKId,@Nombre,@Apellido,@Contacto,@Correo)";
                MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
                cmd.Parameters.AddWithValue("@PKId", this.str_id);
                cmd.Parameters.AddWithValue("@Nombre", this.str_nombre);
                cmd.Parameters.AddWithValue("@Apellido", this.str_apellido);
                cmd.Parameters.AddWithValue("@Contacto", this.str_contacto);
                cmd.Parameters.AddWithValue("@Correo", this.str_contacto);
                cmd.ExecuteNonQuery();
                str_msn = "Registro exitoso";
                this.int_tipoMensaje = 1;
                fnt_RegistrarUser();
            }
            catch (Exception) { this.str_msn = "Usuario ya registrado / problemas de conexión"; int_tipoMensaje = 0;
    }
        }
        private void fnt_RegistrarUser()
        {
            string comando = "insert into tbl_usuarios values " +
                "(@PKCorreo,@Contraseña,@FKCodigo_tbl_estado,@FKCodigo_tbl_rol,@FKId_tbl_personas)";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKCorreo", this.str_correo);
            cmd.Parameters.AddWithValue("@Contraseña", this.str_id);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", this.int_estado);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_rol", this.int_rol);
            cmd.Parameters.AddWithValue("@FKId_tbl_personas", this.str_id);
            cmd.ExecuteNonQuery();
        }
        public string getstrMsn() { return this.str_msn; }
        public int getTipoMensaje() { return this.int_tipoMensaje;}
    }
}