using BE.ManejoUsuario;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DYAS_Control_Gastos_2025
{
    public partial class ControlDeGastosForm : Form
    {

        private UsuarioBLL usuarioBLL = new UsuarioBLL();
        private Form loginForm;
        private Form movimientoForm;

        public ControlDeGastosForm()
        {
            InitializeComponent();
            SessionManager.Instance.OnLogout += UsuarioDesloguado;
            SessionManager.Instance.OnLogin += UsuarioLogueado;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            UsuarioDesloguado();
        }

        private void UsuarioDesloguado()
        {
            menuStrip1.Enabled = false;
            CerrarForm(movimientoForm);

            loginForm = new LoginForm();
            loginForm.MdiParent = this;
            loginForm.Show();
            loginForm.Enabled = true;
        }

        private void UsuarioLogueado()
        {
            loginForm.Close();
            loginForm = null;

            menuStrip1.Enabled = true;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarioBLL.Logout();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (movimientoForm == null)
            {
                movimientoForm = new MovimientoForm();
                movimientoForm.MdiParent = this;
                movimientoForm.FormClosed += (s, args) => movimientoForm = null;
                movimientoForm.Show();
            }
            else
            {
                movimientoForm.BringToFront();
            }
        }

        private void CerrarForm(Form form)
        {
            if (form != null)
            {
                form.Close();
                form = null;
            }
        }
    }
}
