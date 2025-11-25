using BE;
using BE.Entidades;
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
    public partial class SimuladorPrestamoForm : Form
    {

        private readonly ConfiguracionPrestamoBLL configuracionPrestamoBLL;
        private readonly MovimientoBLL movimientoBLL;
        private readonly PrestamoBLL prestamoBLL;
        private Prestamo prestamo;

        public SimuladorPrestamoForm()
        {
            InitializeComponent();
            configuracionPrestamoBLL = new ConfiguracionPrestamoBLL();
            movimientoBLL = new MovimientoBLL();
            prestamoBLL = new PrestamoBLL();
        }

        private void LlenarCampos()
        {
            DateTime fechaInicio = DateTime.Now.AddYears(-1);
            List<Movimiento> movimientos = movimientoBLL.BuscarMovimientos(null, null, null, null, fechaInicio, DateTime.Now);

            decimal saldoTotal = movimientoBLL.CalcularSaldo(movimientos, Moneda.PESOS) +
                (movimientoBLL.CalcularSaldo(movimientos, Moneda.DOLARES) * prestamoBLL.TipoDeCambio());
            
            saldoTotalTextBox.Text = saldoTotal.ToString("#.00");
            tipoDeCambio.Text = prestamoBLL.TipoDeCambio().ToString("N2");

            ConfiguracionPrestamo configuracionPrestamo = (ConfiguracionPrestamo)configuracionPrestamoComboBox.SelectedValue;

            tasaInteresTextBox.Text = (configuracionPrestamo.TasaInteres * 100).ToString("");
        }

        private void SimuladorPrestamoForm_Load(object sender, EventArgs e)
        {
            configuracionPrestamoComboBox.DataSource = configuracionPrestamoBLL.ListarConfiguraciones();
            configuracionPrestamoComboBox.DisplayMember = "PlazoMeses";

            montoAPrestarTextBox.ReadOnly = true;
            solicitarPrestamoBtn.Enabled = false;
            recalcularBtn.Enabled = false;
            LlenarCampos();
        }

        private void calcularPrestamoButton_Click(object sender, EventArgs e)
        {
            ConfiguracionPrestamo configuracionPrestamo = (ConfiguracionPrestamo)configuracionPrestamoComboBox.SelectedValue;

            try
            {
                Prestamo prestamo = prestamoBLL.CalcularPrestamo(configuracionPrestamo);
                ActualizarPrestamo(prestamo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculando el préstamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ActualizarPrestamo(Prestamo prestamo)
        {
            this.prestamo = prestamo;
            montoAPrestarTextBox.Text = prestamo.Monto.ToString("#.00");
            valorCuotaTextBox.Text = prestamo.GetValorCuota().ToString("#.00");
            cantidadCuotasTextBox.Text = prestamo.GetCantidadCuotas().ToString();
            totalADevolverTextBox.Text = prestamo.GetTotalADevolver().ToString("#.00");

            montoAPrestarTextBox.ReadOnly = false;
            recalcularBtn.Enabled = true;
            solicitarPrestamoBtn.Enabled = true;
        }

        private void configuracionPrestamoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        private void recalcularBtn_Click(object sender, EventArgs e)
        {
            ConfiguracionPrestamo configuracionPrestamo = (ConfiguracionPrestamo)configuracionPrestamoComboBox.SelectedValue;
            decimal monto = decimal.Parse(montoAPrestarTextBox.Text);
            try {
                Prestamo prestamo = prestamoBLL.CalcularPrestamo(configuracionPrestamo, monto);
                ActualizarPrestamo(prestamo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recalculando el préstamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void solicitarPrestamoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                recalcularBtn_Click(sender, e);
                prestamoBLL.CrearPrestamo(prestamo);

                MessageBox.Show("Préstamo acreditado de correctamente");
                this.Dispose();

            } catch (Exception ex)
            {
                MessageBox.Show($"Error creando el préstamo: {ex.Message}");
            }
        }
    }
}
