using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEV0102.DAL
{
    public class usuarioDAL
    {
        public tabUsuario consultarUsuarioPorEmail(string email)
        {
            using (DEV0102Entities ctx = new DEV0102Entities())
            {
                return ctx.tabUsuario.Where(c => c.email == email).FirstOrDefault();
            }
        }

        public void cadastrarUsuario(tabUsuario objU)
        {
            using (DEV0102Entities ctx = new DEV0102Entities())
            {
                ctx.tabUsuario.Add(objU);
                ctx.SaveChanges();
            }
        }

    }
}