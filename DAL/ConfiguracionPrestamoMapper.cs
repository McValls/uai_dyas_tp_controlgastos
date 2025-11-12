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
    public class ConfiguracionPrestamoMapper : Mapper<ConfiguracionPrestamo, int>
    {
        public ConfiguracionPrestamoMapper() : base(
            "id",
            "ObtenerConfiguracionPrestamos",
            "InsertarConfiguracionPrestamos",
            "EditarConfiguracionPrestamos",
            "EliminarConfiguracionPrestamos")
        {
        }

        public override SqlParameter[] ParseData(ConfiguracionPrestamo data)
        {
            if (data.Id == 0)
            {
                return new SqlParameter[]
                {
                    new SqlParameter("@tasainteres", data.TasaInteres),
                    new SqlParameter("@plazomeses", data.PlazoMeses)
                };
            }
            else
            {
                return new SqlParameter[]
                {
                    new SqlParameter("@id", data.Id),
                    new SqlParameter("@tasainteres", data.TasaInteres),
                    new SqlParameter("@plazomeses", data.PlazoMeses)
                };
            }
        }

        public override ConfiguracionPrestamo ParseRow(DataRow row)
        {
            int id = int.Parse(row["Prestamo_Id"].ToString());
            decimal tasaInteres = decimal.Parse(row["Prestamo_TasaInteres"].ToString());
            int plazoMeses = int.Parse(row["Prestamo_PlazoMeses"].ToString());

            return new ConfiguracionPrestamo(id, tasaInteres, plazoMeses);
        }
    }
}

