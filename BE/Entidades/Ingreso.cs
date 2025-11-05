using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Ingreso : Movimiento
    {
        public Ingreso(decimal monto, Moneda moneda, string descripcion, Usuario usuario) : base(monto, moneda, descripcion, usuario)
        {
        }

        public Ingreso(int id, decimal monto, Moneda moneda, string descripcion, DateTime fecha, Usuario usuario) 
            : base(id, monto, moneda, descripcion, fecha, usuario)
        {
        }

        public override string GetTipo()
        {
            return "Ingreso";
        }

        public override decimal Acumular(decimal montoOriginal)
        {
            return montoOriginal + monto;
        }

        protected override string GetSigno()
        {
            return "+";
        }
    }
}
