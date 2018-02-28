using PortalImo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalImo.Infrastructure.Data.Initializer
{
    public class UserDataBaseInitializer
    {
        public static List<Usuario> GetUsuario()
        {
            var usuarios = new List<Usuario>
            {
                new Usuario
                {
                    codusuario = 1,
                    email = "jmdneto@gmail.com",
                    senha = "123",
                    datahora= DateTime.Now,
                    ultimoacesso= DateTime.Now
                }
            };
            return usuarios;
        }
    }
}
