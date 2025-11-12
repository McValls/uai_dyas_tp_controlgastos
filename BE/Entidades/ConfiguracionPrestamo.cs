using System;

namespace BE
{
    public class ConfiguracionPrestamo
    {
        private int id;
        private decimal tasaInteres;
        private int plazoMeses;

        public ConfiguracionPrestamo(int id, decimal tasaInteres, int plazoMeses)
        {
            this.id = id;
            this.tasaInteres = tasaInteres;
            this.plazoMeses = plazoMeses;
        }

        public ConfiguracionPrestamo(decimal tasaInteres, int plazoMeses)
        {
            this.id = 0;
            this.tasaInteres = tasaInteres;
            this.plazoMeses = plazoMeses;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal TasaInteres
        {
            get { return tasaInteres; }
            set { tasaInteres = value; }
        }

        public int PlazoMeses
        {
            get { return plazoMeses; }
            set { plazoMeses = value; }
        }
    }
}

