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

namespace TP_DYAS_Control_Gastos_2025
{
    public partial class SimuladorPrestamoForm : Form
    {

        private readonly ConfiguracionPrestamoBLL configuracionPrestamoBLL;
        private readonly MovimientoBLL movimientoBLL;
        private readonly int valorTipoDeCambio = 1350;

        public SimuladorPrestamoForm()
        {
            InitializeComponent();
            configuracionPrestamoBLL = new ConfiguracionPrestamoBLL();
            movimientoBLL = new MovimientoBLL();
            LlenarCampos();
        }

        private void LlenarCampos()
        {
            DateTime fechaInicio = DateTime.Now.AddYears(-1);
            List<Movimiento> movimientos = movimientoBLL.ListarMovimientos().Where(movimiento => movimiento.Fecha >= fechaInicio).ToList();

            List<Movimiento> ingresos = movimientos.Where(movimiento => movimiento.GetTipo() == "Ingreso").ToList();
            List<Movimiento> gastos = movimientos.Where(movimiento => movimiento.GetTipo() == "Gasto").ToList();

            decimal totalIngresosPesos = movimientoBLL.CalcularSaldo(ingresos, Moneda.PESOS);
            decimal totalGastosPesos = movimientoBLL.CalcularSaldo(gastos, Moneda.PESOS);

            decimal totalIngresosDolares = movimientoBLL.CalcularSaldo(ingresos, Moneda.DOLARES);
            decimal totalGastosDolares = movimientoBLL.CalcularSaldo(gastos, Moneda.DOLARES);

            promedioGastos.Text = ((totalGastosPesos + (totalGastosDolares * valorTipoDeCambio)) / 12).ToString("N2");
            promedioIngresos.Text = ((totalIngresosPesos + (totalIngresosDolares * valorTipoDeCambio)) / 12).ToString("N2");
            tipoDeCambio.Text = valorTipoDeCambio.ToString("N2");
        }

        private void SimuladorPrestamoForm_Load(object sender, EventArgs e)
        {
            configuracionPrestamoComboBox.DataSource = configuracionPrestamoBLL.ListarConfiguraciones();
            configuracionPrestamoComboBox.DisplayMember = "PlazoMeses";
        }

        private void calcularPrestamoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
