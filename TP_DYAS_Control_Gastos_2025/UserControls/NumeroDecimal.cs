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
    public partial class NumeroDecimal : ErrorUserControl, IValidable
    {
        public NumeroDecimal()
        {
            InitializeComponent();
            textBox.KeyPress += CustomOnKeyPress;
        }
        public String TextBox
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        private void CustomOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        public bool Validar()
        {
            return InputValido(() => string.IsNullOrWhiteSpace(textBox.Text), textBox);
        }
    }
}
