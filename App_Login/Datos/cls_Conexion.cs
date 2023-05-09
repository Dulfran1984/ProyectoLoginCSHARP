using MySql.Data.MySqlClient;
using System;

namespace Datos
{
    public class cls_Conexion
    {
        public MySqlConnection conex;
        string cadenaconexion;
        public void fnt_conectar()
        {
            conex = new MySqlConnection();
            //************* CONEXION BASE DATOS ******************
            String servidor = "10.230.16.121";
            String bd = "dbs_login_dulfran";
            String usuario = "yoyito";
            String contraseña = "Sena2023";
            String puerto = "3306";
            cadenaconexion = "server=" + servidor + ";port=" + puerto + ";user id=" + usuario + ";password=" + contraseña + ";database=" + bd + ";";

            try
            {
                conex.ConnectionString = cadenaconexion;
                conex.Open();
                //MessageBox.Show("Conexión establecida con el servidor de bases de datos");
            }
            catch (Exception)
            {
                //MessageBox.Show("No hay conexión", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return conex;
            }
        }
        public void fnt_Desconectar() { conex.Close(); }
    }
}