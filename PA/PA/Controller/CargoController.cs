using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Controller
{
    public class PetController
    {
        public void save(string desc_time, string abreviacao_time)
        {
            PetModel model = new TimeModel();

            model.Desc_time = desc_time;
            model.Abreviacao_time = abreviacao_time;

            model.save();

        }

        public int verifyUser(string login_usuario, string senha_usuario)
        {
            UsuarioModel model = new UsuarioModel();

            model.Login_usuario = login_usuario;
            model.Senha_usuario = senha_usuario;

            model.verifyUser();

            return model.verifyUser();
        }
    }
}
