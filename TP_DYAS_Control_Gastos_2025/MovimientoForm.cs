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
    public partial class MovimientoForm : Form
    {
        MovimientoBLL movimientoBLL = new MovimientoBLL();
        public MovimientoForm()
        {
            InitializeComponent();
            movimientoBLL.OnMovimientoAdded += RefrescarTabla;
            movimientoBLL.OnMovimientoAdded += LimpiarCampos;
            movimientoBLL.OnMovimientoAdded += ActualizarSaldoActual;
        }

        private void MovimientoForm_Load(object sender, EventArgs e)
        {
            monedaComboBox.DataSource = Enum.GetValues(typeof(BE.Moneda));
            monedaSaldoActualComboBox.DataSource = Enum.GetValues(typeof(BE.Moneda));
            RefrescarTabla();
            ActualizarSaldoActual();
        }

        private void movimientosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guardarButton_click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is IValidable validableControl)
                {
                    if (!validableControl.Validar())
                    {
                        return;
                    }
                }
            }

            string tipo = null;
            if (gastoRadioButton.Checked)
            {
                tipo = "Gasto";
            }
            else if (ingresoRadioButton.Checked)
            {
                tipo = "Ingreso";

            }
            decimal monto = decimal.Parse(montoTextBox.TextBox);
            Moneda moneda = (Moneda)monedaComboBox.SelectedItem;
            string descripcion = descripcionTextBox.TextBox;

            movimientoBLL.AgregarMovimiento(tipo, monto, moneda, descripcion);
        }

        private void RefrescarTabla()
        {
            movimientosDataGridView.DataSource = movimientoBLL.ListarMovimientos()
                .Select(movimiento => new MovimientoDataSource(movimiento))
                .ToList();
        }

        private void LimpiarCampos()
        {
            gastoRadioButton.Checked = false;
            ingresoRadioButton.Checked = false;
            montoTextBox.TextBox = "";
            monedaComboBox.SelectedIndex = -1;
            descripcionTextBox.TextBox = "";
        }

        private void ActualizarSaldoActual()
        {
            Moneda monedaSeleccionada = (Moneda)monedaSaldoActualComboBox.SelectedItem;
            decimal saldoActual = movimientoBLL.CalcularSaldoActual(monedaSeleccionada);
            saldoActualTextBox.Text = $"Saldo Actual: {saldoActual:C}";
        }
        
        private void MonedaSaldoActualComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ActualizarSaldoActual();
        }

        public class MovimientoDataSource
        {
            private DateTime fecha;
            private string descripcion;
            private string monto;

            public MovimientoDataSource(Movimiento movimiento)
            {
                this.Fecha = movimiento.Fecha;
                this.Descripcion = movimiento.Descripcion;
                this.Monto = movimiento.GetMontoAsString();
            }

            public DateTime Fecha { get => fecha; set => fecha = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
            public string Monto { get => monto; set => monto = value; }
        }

        private void numeroDecimal1_Load(object sender, EventArgs e)
        {

        }
    }
}
