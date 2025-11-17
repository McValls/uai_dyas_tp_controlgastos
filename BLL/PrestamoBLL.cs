using BE;
using BE.Entidades;
using BE.ManejoUsuario;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PrestamoBLL
    {
        private PrestamoMapper prestamoMapper;
        private MovimientoBLL movimientoBLL;

        /**
            Se toma el saldo excedente de los últimos 12 meses como el posible ahorro del usuario.
            Luego, se toma que ese ahorro representa el 20% del total de sus ingresos, y se multiplica por 3 para obtener el máximo posible a prestar.
            Esto es para que el usuario no se endeude demasiado y pueda pagar sus cuotas.
            El factor 3 es un factor de seguridad para que el usuario no se endeude demasiado y pueda pagar sus cuotas.
        */
        private readonly decimal PORCENTAJE_AHORRADO_PROMEDIO = 0.2m;
        private readonly decimal FACTOR_MAX_PRESTAMO = 3;
        private readonly int tipoDeCambio = 1400;

        public PrestamoBLL()
        {
            this.prestamoMapper = new PrestamoMapper();
            this.movimientoBLL = new MovimientoBLL();        
        }

        public Prestamo CalcularPrestamo(ConfiguracionPrestamo configuracionPrestamo)
        {
            return CalcularPrestamo(configuracionPrestamo, null);
        }

        public Prestamo CalcularPrestamo(ConfiguracionPrestamo configuracionPrestamo, decimal? monto)
        {
            decimal montoAPrestar;
            if (monto.HasValue)
            {
                montoAPrestar = monto.Value;
            } else
            {
                montoAPrestar = CalcularMaximoDisponible();
            }

            Usuario usuario = SessionManager.Instance.GetUsuario();

            Prestamo prestamo = new Prestamo(montoAPrestar, configuracionPrestamo, DateTime.Now, usuario);

            return prestamo;
        }

        private decimal CalcularMaximoDisponible()
        {
            DateTime desde = DateTime.Now.AddYears(-1);
            DateTime hasta = DateTime.Now;
            List<Movimiento> movimientos = movimientoBLL.BuscarMovimientos(null, null, null, null, desde, hasta);

            decimal saldoPesos = movimientoBLL.CalcularSaldo(movimientos, Moneda.PESOS);
            decimal saldoDolares = movimientoBLL.CalcularSaldo(movimientos, Moneda.DOLARES);

            decimal saldoTotalUltimoAnio = saldoPesos + (saldoDolares * tipoDeCambio);
            return (saldoTotalUltimoAnio / PORCENTAJE_AHORRADO_PROMEDIO) * FACTOR_MAX_PRESTAMO;
        }

        public void CrearPrestamo(Prestamo prestamo)
        {
            if (prestamo.Monto > CalcularMaximoDisponible())
            {
                throw new Exception("No se puede crear un préstamo que supere el máximo disponible");
            }
            int affectedRows = prestamoMapper.Insertar(prestamo);
            if (affectedRows == 0)
            {
                throw new Exception("Ocurrió un error creando el préstamo");
            }
        }

        public int TipoDeCambio() { return tipoDeCambio; }
    }
}
