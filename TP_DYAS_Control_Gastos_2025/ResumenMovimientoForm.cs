using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace TP_DYAS_Control_Gastos_2025
{
    public partial class ResumenMovimientoForm : Form
    {
        private MovimientoBLL movimientoBLL;

        public ResumenMovimientoForm()
        {
            InitializeComponent();
            this.movimientoBLL = new MovimientoBLL();
            List<Mes> meses = new List<Mes>();
            for (int i = 1; i <= 12; i++)
            {
                Mes mes = new Mes(i, new DateTime(1, i, 1).ToString("MMMM"));
                meses.Add(mes);
            }
            mesesComboBox.DataSource = meses;
            mesesComboBox.DisplayMember = "Nombre";

            List<int> anios = new List<int>();
            List<Movimiento> todosLosMovimientos = movimientoBLL.ListarMovimientos();
            if (todosLosMovimientos.Count > 0)
            {
                int primerAnio = todosLosMovimientos.Min(m => m.Fecha.Year);
                int anioActual = DateTime.Now.Year;
                for (int i = primerAnio; i <= anioActual; i++)
                {
                    anios.Add(i);
                }
            }
            else
            {
                anios.Add(DateTime.Now.Year);
            }
            aniosComboBox.DataSource = anios;

            List<MonedaItem> monedas = new List<MonedaItem>();
            monedas.Add(new MonedaItem(null, "Todas"));
            monedas.Add(new MonedaItem(Moneda.PESOS, "Pesos"));
            monedas.Add(new MonedaItem(Moneda.DOLARES, "Dólares"));
            monedaComboBox.DataSource = monedas;
            monedaComboBox.DisplayMember = "Nombre";
        }

        private void ResumenMovimientoForm_Load(object sender, EventArgs e)
        {
            RefrescarTabla(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void RefrescarTabla(int mes, int anio, Moneda? moneda = null, string descripcion = null)
        {
            List<Movimiento> movimientos = movimientoBLL.BuscarMovimientos(mes, anio, moneda, descripcion, null, null);
            dataGridView.DataSource = movimientos.Select(movimiento => new MovimientoDataSource(movimiento)).ToList();

            decimal acumuladoPesos = movimientoBLL.CalcularSaldo(movimientos, Moneda.PESOS);

            decimal acumuladoDolares = movimientoBLL.CalcularSaldo(movimientos, Moneda.DOLARES);

            acumuladoPesosTextBox.Text = acumuladoPesos.ToString("C2");
            acumuladoDolaresTextBox.Text = acumuladoDolares.ToString("C2");
        }
        private void aplicarButton_Click(object sender, EventArgs e)
        {
            int anioSeleccionado = (int)aniosComboBox.SelectedItem;
            int mesSeleccionado = ((Mes)mesesComboBox.SelectedItem).Numero;
            Moneda? monedaSeleccionada = ((MonedaItem)monedaComboBox.SelectedItem).Valor;
            string descripcionBuscada = descripcionTextBox.Text;

            RefrescarTabla(mesSeleccionado, anioSeleccionado, monedaSeleccionada, descripcionBuscada);
        }

        public class MovimientoDataSource
        {
            private readonly DateTime fecha;
            private readonly string monto;
            private readonly string descripcion;

            public MovimientoDataSource(Movimiento movimiento)
            {
                this.fecha = movimiento.Fecha;
                this.monto = movimiento.GetMontoAsString();
                this.descripcion = movimiento.Descripcion;
            }

            public DateTime Fecha { get { return fecha; } }
            public string Monto { get { return monto; } }

            public string Descripcion
            {
                get { return descripcion; }
            }
        }

        public class Mes
        {
            private readonly int numero;
            private readonly string nombre;

            public Mes(int numero, string nombre)
            {
                this.numero = numero;
                this.nombre = nombre;
            }

            public int Numero => numero;

            public string Nombre => nombre;
        }

        public class MonedaItem
        {
            private readonly Moneda? valor;
            private readonly string nombre;

            public MonedaItem(Moneda? valor, string nombre)
            {
                this.valor = valor;
                this.nombre = nombre;
            }

            public Moneda? Valor => valor;

            public string Nombre => nombre;
        }

    }
}
