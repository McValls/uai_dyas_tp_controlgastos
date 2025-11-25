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
using TP_DYAS_Control_Gastos_2025.UserControls;

namespace TP_DYAS_Control_Gastos_2025
{
    public partial class LoginForm : Form
    {
        private UsuarioBLL usuarioBLL = new UsuarioBLL();

        public LoginForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            
            if (ValidarInputs())
            {
                return;
            }

            string username = usernameTextBox.TextBox;
            string password = passwordTextBox.TextBox;

            try
            {
                usuarioBLL.Login(username, password);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void crearAdministradorButton_Click(object sender, EventArgs e)
        {

            if (ValidarInputs())
            {
                return;
            }

            string password = passwordTextBox.TextBox;

            try
            {
                usuarioBLL.InitAdmin(password);
                SessionManager.Instance.SetUsuario(null);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creando usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool ValidarInputs()
        {
            bool error = false;
            foreach (Control control in this.Controls)
            {
                if (control is IValidable validableControl)
                {
                    if (!validableControl.Validar())
                    {
                        error = true;
                    }
                }
            }
            return error;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            bool existeAdmin = usuarioBLL.ExisteUsuarioAdministrador();
            if (!existeAdmin)
            {
                usernameTextBox.TextBox = "admin";
                usernameTextBox.Enabled = false;
                confirmarBtn.Enabled = false;
                crearAdministradorButton.Visible = true;
            }
        }
    }
}
