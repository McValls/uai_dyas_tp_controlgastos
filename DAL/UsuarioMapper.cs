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
    public class UsuarioMapper : Mapper<Usuario, int>
    {
        public UsuarioMapper(): base(
            "id", 
            "ObtenerUsuarios", 
            "InsertarUsuarios", 
            "EditarUsuarios", 
            "EliminarUsuarios")
        {
        }

        public override SqlParameter[] ParseData(Usuario data)
        {
            if (data.Id == 0)
            {
                return new SqlParameter[]
                {
                    new SqlParameter("@username", data.Username),
                    new SqlParameter("@password", data.Password),
                    new SqlParameter("@tipo", data.Tipo)
                };
            }
            else
            {
                return new SqlParameter[]
                {
                    new SqlParameter("@id", data.Id),
                    new SqlParameter("@username", data.Username),
                    new SqlParameter("@password", data.Password),
                    new SqlParameter("@tipo", data.Tipo)
                };
            }
        }

        public override Usuario ParseRow(DataRow row)
        {
            int id = int.Parse(row["Usuarios_id"].ToString());
            string username = row["Usuarios_username"].ToString();
            string password = row["Usuarios_password"].ToString();
            int tipo = int.Parse(row["Usuarios_tipo"].ToString());
            return new Usuario(id, username, password, (TipoUsuario)tipo);
        }

        public Usuario GetUsuarioByUsername(string username)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@username", username)
            };
            List<Usuario> usuarios = Buscar("ObtenerUsuarioPorUsername", parametros);
            return usuarios.FirstOrDefault();
        }
    }
}
