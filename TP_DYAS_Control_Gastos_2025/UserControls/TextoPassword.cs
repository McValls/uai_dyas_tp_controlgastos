using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DYAS_Control_Gastos_2025.UserControls
{
    public partial class TextoPassword : ErrorUserControl, IValidable
    {
        public TextoPassword()
        {
            InitializeComponent();
        }
        public String TextBox
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public bool Validar()
        {
            return InputValido(() => string.IsNullOrWhiteSpace(textBox.Text) || !ValidarPassword(textBox.Text), textBox);
        }
        private bool ValidarPassword(string password)
        {
            bool result = true;
            if (password.Length < 8)
                result = false;
            if (!password.Any(char.IsUpper))
                result = false;
            if (!password.Any(char.IsLower))
                result = false;
            if (!password.Any(char.IsDigit))
                result = false;

            if (!result)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluyendo una letra mayúscula, una letra minúscula y un número.", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }
    }

}
