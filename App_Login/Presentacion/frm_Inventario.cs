using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_Inventario : Form
    {
        public frm_Inventario()
        {
            InitializeComponent();
        }

        private void btn_Cerarr_Click(object sender, EventArgs e)
        {
            Visible = false;
            frm_Login obj_Login = new frm_Login();
            obj_Login.Visible = true;
        }
    }
}
