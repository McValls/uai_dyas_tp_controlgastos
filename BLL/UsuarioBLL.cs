using BE;
using BE.ManejoUsuario;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {

        private UsuarioMapper usuarioMapper;
        private CryptoManager cryptoManager;

        public UsuarioBLL()
        {
            this.usuarioMapper = new UsuarioMapper();
            this.cryptoManager = new CryptoManager();
        }

        public void Login(string username, string password)
        {
            Usuario usuario = usuarioMapper.GetUsuarioByUsername(username);
            if (usuario == null)
            {
                throw new Exception("Error de autenticación");
            }

            bool passwordCorrecta = cryptoManager.Comparar(password, usuario.Password);
            if (!passwordCorrecta)
            {
                throw new Exception("Error de autenticación");
            }

            SessionManager.Instance.SetUsuario(usuario);
        }

        public void Logout()
        {
            SessionManager.Instance.SetUsuario(null);
        }

        public void CrearUsuario(string username, string password)
        {
            CrearUsuario(username, password, TipoUsuario.Usuario);
        }

        private void CrearUsuario(string username, string password, TipoUsuario tipoUsuario)
        {
            if (usuarioMapper.GetUsuarioByUsername(username) != null)
            {
                throw new Exception("El nombre de usuario ya existe");
            }
            Usuario usuario = new Usuario(username, cryptoManager.Hash(password), tipoUsuario);
            int affectedRows = usuarioMapper.Insertar(usuario);

            if (affectedRows == 0)
            {
                throw new Exception("No se pudo crear el usuario");
            }
            SessionManager.Instance.SetUsuario(usuarioMapper.GetUsuarioByUsername(username));
        }

        public void InitAdmin(string password) {
            if (usuarioMapper.GetUsuarioByUsername("admin") == null) 
            {
                CrearUsuario("admin", password, TipoUsuario.Admin);
            }
        }

        public bool ExisteUsuarioAdministrador()
        {
            return usuarioMapper.Listar().Exists(u => u.Tipo == TipoUsuario.Admin);
        }
    }
}
