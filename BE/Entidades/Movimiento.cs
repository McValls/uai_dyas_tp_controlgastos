using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Movimiento
    {
        protected readonly int id;
        protected readonly string descripcion;
        protected readonly decimal monto;
        protected readonly Moneda moneda;
        protected readonly DateTime fecha;
        protected readonly Usuario usuario;

        public Movimiento(decimal monto, Moneda moneda, string descripcion, Usuario usuario )
        {
            this.monto = monto;
            this.moneda = moneda;
            this.descripcion = descripcion;
            this.fecha = DateTime.Now;
            this.usuario = usuario;
        }

        public Movimiento(int id, decimal monto, Moneda moneda, string descripcion, DateTime fecha, Usuario usuario)
        {
            this.id = id;
            this.monto = monto;
            this.moneda = moneda;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.usuario = usuario;
        }

        public int Id
        {
            get { return id; }
        }
        public string Descripcion
        {
            get { return descripcion; }
        }
        public decimal Monto
        {
            get { return monto; }
        }
        public Moneda Moneda
        {
            get { return moneda; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
        }
        public Usuario Usuario
        {
            get { return usuario; }
        }

        // Factory method to create the appropriate concrete instance
        public static Movimiento Create(string tipo, int id, decimal monto, Moneda moneda, string descripcion, DateTime fecha, Usuario usuario)
        {
            if (tipo == "Gasto")
            {
                return new Gasto(id, monto, moneda, descripcion, fecha, usuario);
            }
            else if (tipo == "Ingreso")
            {
                return new Ingreso(id, monto, moneda, descripcion, fecha, usuario);
            }
            else
            {
                throw new ArgumentException($"Tipo de movimiento desconocido: {tipo}");
            }
        }

        // Factory method overload for new instances (without id)
        public static Movimiento Create(string tipo, decimal monto, Moneda moneda, string descripcion, Usuario usuario)
        {
            if (tipo == "Gasto")
            {
                return new Gasto(monto, moneda, descripcion, usuario);
            }
            else if (tipo == "Ingreso")
            {
                return new Ingreso(monto, moneda, descripcion, usuario);
            }
            else
            {
                throw new ArgumentException($"Tipo de movimiento desconocido: {tipo}");
            }
        }

        // Method to get the tipo string from an instance
        public abstract string GetTipo();
        protected abstract string GetSigno();

        public abstract decimal Acumular(decimal montoOriginal);

        public virtual string GetMontoAsString()
        {
            return $"{GetSigno()}{MonedaExtensions.ToStringCustom(moneda)} {monto}";
        }
    }
}
