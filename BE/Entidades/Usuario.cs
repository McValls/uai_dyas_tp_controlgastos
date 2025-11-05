using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private readonly int id;
        private readonly string username;
        private readonly string password;
        private readonly TipoUsuario tipo;

        public Usuario(string username, string password, TipoUsuario tipo)
        {
            this.username = username;
            this.password = password;
            this.tipo = tipo;
        }

        public Usuario(int id, string username, string password, TipoUsuario tipo)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.tipo = tipo;
        }

        public int Id { get { return id; } }
        public string Username { get { return username; } }
        public string Password { get { return password; } }
        public TipoUsuario Tipo { get { return tipo; } }
    }
}
