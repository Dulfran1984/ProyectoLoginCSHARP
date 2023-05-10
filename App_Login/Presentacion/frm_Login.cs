using Negocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            lbl_Mensaje.Visible = false;
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
            if (obj_Login.getRol() == "Ventas")
            {
                frm_Ventas obj_ventas = new frm_Ventas();
                obj_ventas.Visible = true;
                obj_ventas.lbl_Encargado.Text = obj_Login.getNombre();
                obj_ventas.lbl_Estado.Text = obj_Login.getEstado();
                obj_ventas.lbl_Rol.Text = obj_Login.getRol();
                Visible = false;
            }
            if (obj_Login.getRol() == "Inventario")
            {
                frm_Inventario obj_inventario = new frm_Inventario();
                obj_inventario.Visible = true;
                obj_inventario.lbl_Encargado.Text = obj_Login.getNombre();
                obj_inventario.lbl_Estado.Text = obj_Login.getEstado();
                obj_inventario.lbl_Rol.Text = obj_Login.getRol();
                Visible = false;
            }
            lbl_Mensaje.ForeColor = Color.Red;
            lbl_Mensaje.Text = obj_Login.getMsn();
            lbl_Mensaje.Visible = true;
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            fnt_Login(txt_Usuario.Text, txt_Contraseña.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}