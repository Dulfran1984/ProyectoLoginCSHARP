using Negocio;
using System;
using System.Windows.Forms;
namespace Presentacion
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }
        private void fnt_ConsultarEstado()
        {
            cls_CargarEstado obj_Estado = new cls_CargarEstado();
            obj_Estado.fnt_CargarEstado();
            cbx_Estado.ValueMember = "PKCodigo";
            cbx_Estado.DisplayMember = "Descripcion";
            cbx_Estado.DataSource = obj_Estado.getDatatable();
        }
        private void fnt_ConsultarRol()
        {
            cls_Rol obj_Rol = new cls_Rol();
            obj_Rol.fnt_CargarRol();
            cbx_Rol.ValueMember = "PKCodigo";
            cbx_Rol.DisplayMember = "Descripcion";
            cbx_Rol.DataSource = obj_Rol.getDatatable();
        }
        private void fnt_ConsultarUser()
        {
            cls_dtgUsuarios obj_Usuarios = new cls_dtgUsuarios();
            obj_Usuarios.fnt_consultarUsuarios();
            dtg_Usuarios.DataSource = obj_Usuarios.dt_consultarUsuarios();
        }
        private void btn_Cerarr_Click(object sender, EventArgs e)
        {
            Visible = false;
            frm_Login obj_Login = new frm_Login();
            obj_Login.Visible = true;
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            fnt_ConsultarEstado();
            fnt_ConsultarRol();
            fnt_ConsultarUser();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Apellidos.Clear();
            txt_Contacto.Clear();
            txt_Correo.Clear();
            txt_Identificacion.Clear();
            txt_Nombres.Clear();
            cbx_Estado.SelectedIndex = 0;
            cbx_Rol.SelectedIndex = 0;
            txt_Identificacion.Focus();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            cls_AgregarUsuario obj_Agregar = new cls_AgregarUsuario(txt_Identificacion.Text,txt_Nombres.Text,txt_Apellidos.Text,txt_Contacto.Text,txt_Correo.Text,cbx_Estado.SelectedIndex + 1, cbx_Rol.SelectedIndex + 1);
            if(obj_Agregar.getTipoMensaje() == 0)
            {
                MessageBox.Show("" + obj_Agregar.getMensaje(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("" + obj_Agregar.getMensaje(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            cls_ConsultarPersona obj_Consultar = new cls_ConsultarPersona();
            obj_Consultar.fnt_Consultar(txt_Identificacion.Text);
            txt_Nombres.Text = obj_Consultar.get_nombre();
            txt_Apellidos.Text = obj_Consultar.get_apellido();
            txt_Contacto.Text = obj_Consultar.get_contacto();
            txt_Correo.Text = obj_Consultar.get_correo();
            cbx_Estado.SelectedIndex = obj_Consultar.get_estado() - 1;
            cbx_Rol.SelectedIndex = obj_Consultar.getrol() - 1;
            if(obj_Consultar.getMensaje() != "")
            {
                MessageBox.Show(obj_Consultar.getMensaje(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_Usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dtg_Usuarios.CurrentRow.Index;
            MessageBox.Show(""+fila);
            txt_Nombres.Text = Convert.ToString(dtg_Usuarios.Rows[fila].Cells[0].Value);
        }
    }
}