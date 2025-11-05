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
    public partial class TextoNoVacio : ErrorUserControl, IValidable
    {

        public String TextBox
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public TextoNoVacio()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            return InputValido(() => string.IsNullOrWhiteSpace(textBox.Text), textBox);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
