using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MovimientoMapper : Mapper<Movimiento, int>
    {
        private readonly UsuarioMapper usuarioMapper;

        public MovimientoMapper() : base(
            "id",
            "ObtenerMovimientos",
            "InsertarMovimientos",
            "EditarMovimientos",
            "EliminarMovimientos")
        {
            this.usuarioMapper = new UsuarioMapper();
        }

        public override SqlParameter[] ParseData(Movimiento data)
        {
            string tipo = data.GetTipo();
            
            if (data.Id == 0)
            {
                return new SqlParameter[]
                {
                    new SqlParameter("@tipo", tipo),
                    new SqlParameter("@monto", data.Monto),
                    new SqlParameter("@moneda", (int)data.Moneda),
                    new SqlParameter("@descripcion", data.Descripcion),
                    new SqlParameter("@fecha", data.Fecha),
                    new SqlParameter("@usuarioid", data.Usuario.Id)
                };
            }
            else
            {
                return new SqlParameter[]
                {
                    new SqlParameter("@id", data.Id),
                    new SqlParameter("@tipo", tipo),
                    new SqlParameter("@monto", data.Monto),
                    new SqlParameter("@moneda", (int)data.Moneda),
                    new SqlParameter("@descripcion", data.Descripcion),
                    new SqlParameter("@fecha", data.Fecha),
                    new SqlParameter("@usuarioid", data.Usuario.Id)
                };
            }
        }

        public override Movimiento ParseRow(DataRow row)
        {
            int id = int.Parse(row["Movimientos_id"].ToString());
            string tipo = row["Movimientos_tipo"].ToString();
            decimal monto = decimal.Parse(row["Movimientos_monto"].ToString());
            Moneda moneda = (Moneda)int.Parse(row["Movimientos_moneda"].ToString());
            string descripcion = row["Movimientos_descripcion"].ToString();
            DateTime fecha = DateTime.Parse(row["Movimientos_fecha"].ToString());

            Usuario usuario = usuarioMapper.ParseRow(row);

            // Use factory method to create the appropriate instance
            return Movimiento.Create(tipo, id, monto, moneda, descripcion, fecha, usuario);
        }

        public List<Movimiento> GetMovimientosByUsuario(int usuarioId)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@usuarioid", usuarioId)
            };
            return Buscar("ObtenerMovimientosPorUsuario", parametros);
        }

        public List<Movimiento> GetMovimientosByUsuarioYMes(int usuarioId, int mes, int anio)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@usuarioid", usuarioId),
                new SqlParameter("@mes", mes),
                new SqlParameter("@anio", anio)
            };
            return Buscar("ObtenerMovimientosPorUsuarioYMesYAnio", parametros);
        }

        public List<Movimiento> BuscarMovimientos(int usuarioId, int mes, int anio, int? moneda, string descripcion)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@usuarioid", usuarioId),
                new SqlParameter("@mes", mes),
                new SqlParameter("@anio", anio),
                new SqlParameter("@moneda", moneda.HasValue ? (object)moneda.Value : DBNull.Value),
                new SqlParameter("@descripcion", string.IsNullOrWhiteSpace(descripcion) ? (object)DBNull.Value : descripcion)
            };
            return Buscar("BuscarMovimientos", parametros);
        }
    }
}
