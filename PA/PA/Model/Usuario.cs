using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAO;

namespace PA.Model
{
    public class Usuario
    {
        public int id_usuario;
        public string login_usuario;
        public string senha_usuario;
        public int fk_id_funcionario;

        public void save()
        {
            UsuarioDAO dao = new UsuarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }*/

        }
    }
}
