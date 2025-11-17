using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entidades
{
    public class Prestamo
    {
        private int id;
        private decimal monto;
        private ConfiguracionPrestamo configuracionPrestamo;
        private DateTime fechaCreacion;
        private Usuario usuario;

        public Prestamo(int id, decimal monto, ConfiguracionPrestamo configuracionPrestamo, DateTime fechaCreacion, Usuario usuario)
        {
            this.Id = id;
            this.Monto = monto;
            this.ConfiguracionPrestamo = configuracionPrestamo;
            this.FechaCreacion = fechaCreacion;
            this.Usuario = usuario;
        }

        public Prestamo(decimal monto, ConfiguracionPrestamo configuracionPrestamo, DateTime fechaCreacion, Usuario usuario)
        {
            this.Monto = monto;
            this.ConfiguracionPrestamo = configuracionPrestamo;
            this.FechaCreacion = fechaCreacion;
            this.Usuario = usuario;
        }
        public int Id { get => id; set => id = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public ConfiguracionPrestamo ConfiguracionPrestamo { get => configuracionPrestamo; set => configuracionPrestamo = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public decimal GetValorCuota()
        {
            decimal tasaInteres = configuracionPrestamo.TasaInteres;
            int plazo = configuracionPrestamo.PlazoMeses;

            decimal valorCuota = (monto * (1 + tasaInteres)) / plazo;
            return valorCuota;
        }

        public int GetCantidadCuotas()
        {
            return configuracionPrestamo.PlazoMeses;
        }

        public decimal GetInteres()
        {
            return configuracionPrestamo.TasaInteres * 100;
        }

        public decimal GetTotalADevolver()
        {
            return GetCantidadCuotas() * GetValorCuota();
        }
    }
}
