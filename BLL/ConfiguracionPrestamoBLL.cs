using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConfiguracionPrestamoBLL
    {
        private ConfiguracionPrestamoMapper configuracionPrestamoMapper;

        public ConfiguracionPrestamoBLL()
        {
            this.configuracionPrestamoMapper = new ConfiguracionPrestamoMapper();
        }

        public List<ConfiguracionPrestamo> ListarConfiguraciones()
        {
            return configuracionPrestamoMapper.Listar();
        }

        public void AgregarConfiguracion(decimal tasaInteres, int plazoMeses)
        {
            if (tasaInteres <= 0)
            {
                throw new ArgumentException("La tasa de interés debe ser mayor a cero");
            }

            if (plazoMeses <= 0)
            {
                throw new ArgumentException("El plazo en meses debe ser mayor a cero");
            }

            ConfiguracionPrestamo configuracion = new ConfiguracionPrestamo(tasaInteres, plazoMeses);

            int affectedRows = configuracionPrestamoMapper.Insertar(configuracion);

            if (affectedRows == 0)
            {
                throw new Exception("No se pudo agregar la configuración");
            }
        }

        public void EditarConfiguracion(int id, decimal tasaInteres, int plazoMeses)
        {
            if (tasaInteres <= 0)
            {
                throw new ArgumentException("La tasa de interés debe ser mayor a cero");
            }

            if (plazoMeses <= 0)
            {
                throw new ArgumentException("El plazo en meses debe ser mayor a cero");
            }

            ConfiguracionPrestamo configuracion = new ConfiguracionPrestamo(id, tasaInteres, plazoMeses);

            int affectedRows = configuracionPrestamoMapper.Editar(configuracion);

            if (affectedRows == 0)
            {
                throw new Exception("No se pudo editar la configuración");
            }
        }

        public void EliminarConfiguracion(int id)
        {
            int affectedRows = configuracionPrestamoMapper.Eliminar(id);

            if (affectedRows == 0)
            {
                throw new Exception("No se pudo eliminar la configuración");
            }
        }

        //public void CalcularPrestamo(
    }
}

