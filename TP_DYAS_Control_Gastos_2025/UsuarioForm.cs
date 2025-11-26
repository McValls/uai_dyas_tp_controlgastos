using BE;
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
    public partial class UsuarioForm : Form
    {

        private UsuarioBLL usuarioBLL;

        public UsuarioForm()
        {
            InitializeComponent();
            this.usuarioBLL = new UsuarioBLL();
            this.RefrescarTabla();

            usuarioBLL.NuevoUsuarioEvent += RefrescarTabla;
            usuarioBLL.UsuarioBorradoEvent += RefrescarTabla;
        }

        private void crearUsuarioBtn_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            string username = usernameTextBox.TextBox;
            string password = passwordTextBox.TextBox;

            try
            {
                usuarioBLL.CrearUsuario(username, password);
                usernameTextBox.TextBox = "";
                passwordTextBox.TextBox = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al crear usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool Validar()
        {
            bool esValido = true;
            foreach (Control control in this.Controls)
            {
                if (control is IValidable)
                {
                    if (!((IValidable)control).Validar())
                    {
                        esValido = false;
                    }
                }
            }
            return esValido;
        }

        private void RefrescarTabla()
        {
            List<UsuarioDataSource> usuarios = usuarioBLL.Usuarios().Select(usuario => new UsuarioDataSource(usuario)).ToList();
            dataGridView.DataSource = usuarios;
        }

        public class UsuarioDataSource
        {
            private int id;
            private string username;
            private string tipo;

            public UsuarioDataSource(Usuario usuario)
            {
                this.Id = usuario.Id;
                this.Username = usuario.Username;
                this.Tipo = usuario.Tipo.ToString();
            }

            public int Id { get => id; set => id = value; }
            public string Username { get => username; set => username = value; }
            public string Tipo { get => tipo; set => tipo = value; }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].HeaderText == "Eliminar")
            {
                UsuarioDataSource usuario = (UsuarioDataSource)dataGridView.Rows[e.RowIndex].DataBoundItem;
                try
                {
                    usuarioBLL.Borrar(usuario.Id);
                } catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo borrar el usuario: {ex.Message}", "Error borrando al usuario", MessageBoxButtons.OK);
                }
            }
        }

    }
}
