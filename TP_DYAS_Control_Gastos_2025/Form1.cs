using BE;
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
        private Form usuarioForm;

        public ControlDeGastosForm()
        {
            InitializeComponent();
            SessionManager.Instance.OnLogout += UsuarioDesloguado;
            SessionManager.Instance.OnLogout += HabilitarMenues;
            
            SessionManager.Instance.OnLogin += UsuarioLogueado;
            SessionManager.Instance.OnLogin += HabilitarMenues;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            UsuarioDesloguado();
            HabilitarMenues();
        }

        private void UsuarioDesloguado()
        {
            menuStrip1.Enabled = false;
            CerrarForm(movimientoForm);
            CerrarForm(usuarioForm);

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

        private void HabilitarMenues()
        {
            Usuario usuarioLogueado = SessionManager.Instance.GetUsuario();
            if (usuarioLogueado == null || usuarioLogueado.Tipo != TipoUsuario.Admin)
            {
                movimientosToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = false;
            } else
            {
                movimientosToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = true;
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarioBLL.Logout();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearForm(movimientoForm, () => new MovimientoForm(), (form) => movimientoForm = form);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearForm(usuarioForm, () => new UsuarioForm(), (form) => usuarioForm = form);
        }

        private void CrearForm(Form form, Func<Form> creatorFunc, Func<Form, Form> assignorFunc)
        {
            if (form == null)
            {
                form = creatorFunc();
                form.MdiParent = this;
                form.FormClosed += (s, args) => movimientoForm = null;
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
            assignorFunc(form);
        }

        private void CerrarForm(Form form)
        {
            if (form != null)
            {
                form.Dispose();
                form.Close();
                form = null;
            }
        }

    }
}
