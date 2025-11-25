using BE;
using BE.Entidades;
using BE.ManejoUsuario;
using DAL;
using SERVICES;
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
        private TipoDeCambioService tipoDeCambioService;

        /**
            Se toma el saldo excedente de los últimos 12 meses como el posible ahorro del usuario.
            Se interpreta que el usuario ahorra aproximadamente el 20% de su salario
            Luego:
            prestamo maximo = (saldo excedente / 20%) * 3
            prestamo maximo = salario aproximado * 3
        */
        private readonly decimal PORCENTAJE_AHORRADO_PROMEDIO = 0.2m;
        private readonly decimal FACTOR_MAX_PRESTAMO = 3;
        private readonly decimal tipoDeCambio;

        public PrestamoBLL()
        {
            this.prestamoMapper = new PrestamoMapper();
            this.movimientoBLL = new MovimientoBLL();      
            this.tipoDeCambioService = new TipoDeCambioService();

            tipoDeCambio = tipoDeCambioService.GetTipoDeCambioOficial();
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
            decimal maximoDisponible = (saldoTotalUltimoAnio / PORCENTAJE_AHORRADO_PROMEDIO) * FACTOR_MAX_PRESTAMO;

            if (maximoDisponible <= 0)
            {
                throw new Exception("Usuario insolvente, no se habilita préstamo");
            }

            return maximoDisponible;
        }

        public void CrearPrestamo(Prestamo prestamo)
        {
            // Validar que el usuario no tenga ya un préstamo
            List<Prestamo> prestamosExistentes = ObtenerPrestamosByUsuario(prestamo.Usuario.Id);
            if (prestamosExistentes.Count > 0)
            {
                throw new Exception("El usuario ya tiene un préstamo activo");
            }

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

        public List<Prestamo> ObtenerPrestamosByUsuario(int usuarioId)
        {
            return prestamoMapper.ObtenerPrestamosByUsuario(usuarioId);
        }

        public decimal TipoDeCambio() { return tipoDeCambio; }
    }
}
