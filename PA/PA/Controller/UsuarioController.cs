using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Model;

namespace PA.Controller
{
    public class UsuarioController
    {
        public void save(string login_usuario, string senha_usuario, int fk_id_funcionario)
        {
            Usuario model = new Usuario();

            model.login_usuario = login_usuario;
            model.senha_usuario= senha_usuario;
            model.fk_id_funcionario = fk_id_funcionario;
           
            model.save();
        }
    }
}
