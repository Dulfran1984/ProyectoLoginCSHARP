using Negocio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void fnt_Login(string user, string password)
        {
            cls_Login obj_Login = new cls_Login(user, password);
            if (obj_Login.getRol() == "Administrador")
            {
                frm_Admin obj_Admin = new frm_Admin();
                obj_Admin.Visible = true;
                obj_Admin.lbl_Encargado.Text = obj_Login.getNombre();
                obj_Admin.lbl_Estado.Text = obj_Login.getEstado();
                obj_Admin.lbl_Rol.Text = obj_Login.getRol();
                Visible = false;
            }
            lbl_Mensaje.Text = obj_Login.getMsn();
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            fnt_Login(txt_Usuario.Text, txt_Contraseña.Text);
        }
    }
}