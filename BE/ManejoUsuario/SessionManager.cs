using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.ManejoUsuario
{
    public class SessionManager
    {
        private static readonly Lazy<SessionManager> instance = 
            new Lazy<SessionManager>(() => new SessionManager());

        private Usuario usuario;

        public delegate void OnLoginDelegate();
        public delegate void OnLogoutDelegate();
        public event OnLoginDelegate OnLogin;
        public event OnLogoutDelegate OnLogout;

        private SessionManager()
        {
            // Constructor privado para evitar instanciación externa
        }

        public static SessionManager Instance => instance.Value;

        public void SetUsuario(Usuario usr)
        {
            usuario = usr;
            if (usr != null)
            {
                OnLogin?.Invoke();
            } else
            {
                OnLogout?.Invoke();
            }
        }

        public Usuario GetUsuario()
        {
            return usuario;
        }
    }
}
