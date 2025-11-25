using BE;
using BE.ManejoUsuario;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MovimientoBLL
    {
        private MovimientoMapper movimientoMapper;
        public delegate void OnChange();
        public event OnChange OnMovimientoAdded;

        public MovimientoBLL()
        {
            this.movimientoMapper = new MovimientoMapper();
        }

        public List<Movimiento> ListarMovimientos()
        {
            Usuario usuario = SessionManager.Instance.GetUsuario();
            return movimientoMapper.GetMovimientosByUsuario(usuario.Id);
        }

        public List<Movimiento> ListarMovimientosPorMes(int mes, int anio)
        {
            Usuario usuario = SessionManager.Instance.GetUsuario();
            return movimientoMapper.GetMovimientosByUsuarioYMes(usuario.Id, mes, anio);
        }

        public List<Movimiento> BuscarMovimientos(
            int? mes = null, 
            int? anio = null, 
            Moneda? moneda = null, 
            string descripcion = null, 
            DateTime? desde = null, 
            DateTime? hasta = null)
        {
            Usuario usuario = SessionManager.Instance.GetUsuario();
            int? monedaValue = moneda.HasValue ? (int?)moneda.Value : null;
            return movimientoMapper.BuscarMovimientos(usuario.Id, mes, anio, monedaValue, descripcion, desde, hasta);
        }

        public void AgregarMovimiento(string tipo, decimal monto, Moneda moneda, string descripcion)
        {
            Usuario usuario = SessionManager.Instance.GetUsuario();

            // Validations
            if (string.IsNullOrWhiteSpace(tipo))
            {
                throw new ArgumentException("El tipo de movimiento es requerido");
            }

            if (monto <= 0)
            {
                throw new ArgumentException("El monto debe ser mayor a cero");
            }

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException("La descripción es requerida");
            }

            // Use factory method to create the appropriate Movimiento instance
            Movimiento movimiento = Movimiento.Create(tipo, monto, moneda, descripcion, usuario);

            int affectedRows = movimientoMapper.Insertar(movimiento);

            if (affectedRows == 0)
            {
                throw new Exception("No se pudo agregar el movimiento");
            }

            OnMovimientoAdded?.Invoke();
        }

        public decimal CalcularSaldoActual(Moneda moneda)
        {
            List<Movimiento> movimientos = ListarMovimientos().FindAll(movimiento => movimiento.Moneda == moneda);
            return CalcularSaldo(movimientos, moneda);
        }

        public decimal CalcularSaldo(List<Movimiento> movimientos, Moneda moneda)
        {
            List<Movimiento> movimientosFiltrados = movimientos.FindAll(movimiento => movimiento.Moneda == moneda);
            decimal saldoAcumulado = 0;
            movimientosFiltrados.ForEach(movimiento => {
                saldoAcumulado = movimiento.Acumular(saldoAcumulado);
            });

            return saldoAcumulado;
        }
    }
}
