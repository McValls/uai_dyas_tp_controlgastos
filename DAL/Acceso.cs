using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso
    {

        //private readonly string connectionString = "Data Source=DESKTOP-2MSA6DF;Initial Catalog=Control_Gastos;Integrated Security=True;";
        private readonly string connectionString;
        SqlConnection connection = new SqlConnection();
        SqlTransaction transaccion = null;

        public Acceso()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:\\datasource.xml");
            DataTable table = ds.Tables[0];
            string dataSource = "";
            string initialCatalog = "";

            foreach (DataRow row in table.Rows)
            {
                if (row["environment"].ToString() == "home")
                {
                    dataSource = row["DataSource"].ToString();
                    initialCatalog = row["InitialCatalog"].ToString();
                    break;
                }
            }

            connectionString = $"Data Source={dataSource};Initial Catalog={initialCatalog};Integrated Security=True;";
        }

        private void Conectar()
        {
            connection.ConnectionString = connectionString;
            connection.Open();    
        }

        private void Desconectar()
        {
            connection.Close();
        }

        public void IniciarTransaccion()
        {
            Conectar();
            this.transaccion = connection.BeginTransaction();
        }

        public void CommitTransaccion()
        {
            if (this.transaccion == null)
            {
                throw new Exception("No se puede hacer un commit sin una transacción existente");
            }
            this.transaccion.Commit();
            this.transaccion = null;
            Desconectar();
        }

        public void RollbackTransaccion()
        {
            if (this.transaccion == null)
            {
                throw new Exception("No se puede hacer un rollback sin una transacción existente");
            }
            this.transaccion.Rollback();
            this.transaccion = null;
            Desconectar();
        }

        public int Escribir(string sp)
        {
            return Escribir(sp, null);
        }

        public int Escribir(string sp, SqlParameter[] parametro)
        {
            int affectedRows = 0;

            // Automatically handle transactions for write operations
            bool transactionStarted = false;
            if (this.transaccion == null)
            {
                IniciarTransaccion();
                transactionStarted = true;
            }

            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = this.transaccion;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = sp;
                if (parametro != null)
                {
                    command.Parameters.AddRange(parametro);
                    affectedRows = command.ExecuteNonQuery();
                }
                else
                {
                    affectedRows = command.ExecuteNonQuery();
                }
                command.Parameters.Clear();

                // If we started the transaction, commit it
                if (transactionStarted)
                {
                    CommitTransaccion();
                }

                return affectedRows;
            }
            catch (Exception ex)
            {
                // If we started the transaction, rollback it
                if (transactionStarted)
                {
                    RollbackTransaccion();
                }
                throw ex;
            }
        }

        public DataTable Leer(string sp)
        {
            return Leer(sp, null);
        }

        public DataTable Leer(string sp, SqlParameter[] parametro)
        {
            try
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();
                Conectar();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = sp;

                if (parametro != null)
                {
                    command.Parameters.AddRange(parametro);
                }

                adapter.SelectCommand = command;
                adapter.Fill(dataTable);

                return dataTable;
            }
            finally
            {
                Desconectar();
            }
        }

    }
}
