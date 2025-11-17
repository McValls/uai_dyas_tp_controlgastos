using BE;
using BE.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PrestamoMapper : Mapper<Prestamo, int>
    {
        private readonly ConfiguracionPrestamoMapper configuracionPrestamoMapper;
        private readonly UsuarioMapper usuarioMapper;

        public PrestamoMapper() : base(
            "id",
            "ObtenerPrestamos",
            "InsertarPrestamos",
            null,
            null)
        {
            this.configuracionPrestamoMapper = new ConfiguracionPrestamoMapper();
            this.usuarioMapper = new UsuarioMapper();
        }

        public override SqlParameter[] ParseData(Prestamo data)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@Monto", data.Monto),
                new SqlParameter("@ConfiguracionPrestamoId", data.ConfiguracionPrestamo.Id),
                new SqlParameter("@FechaCreacion", data.FechaCreacion),
                new SqlParameter("@UsuarioId", data.Usuario.Id)
            };
        }

        public override Prestamo ParseRow(DataRow row)
        {
            int id = int.Parse(row["Prestamos_Id"].ToString());
            decimal monto = decimal.Parse(row["Prestamos_Monto"].ToString());
            DateTime fechaCreacion = DateTime.Parse(row["Prestamos_FechaCreacion"].ToString());

            ConfiguracionPrestamo configuracionPrestamo = configuracionPrestamoMapper.ParseRow(row);
            Usuario usuario = usuarioMapper.ParseRow(row);

            return new Prestamo(id, monto, configuracionPrestamo, fechaCreacion, usuario);
        }
    }
}
