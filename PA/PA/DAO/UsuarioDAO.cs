using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Model;
using PA.db;
using Npgsql;

namespace PA.DAO
{
    public class UsuarioDAO
    {
        public void insert(Usuario model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Usuario (login_usuario,senha_usuario,fk_id_usuario) " +
                                               "VALUES (@login_usuario,@senha_usuario,@fk_id_funcionario)";

            command.Parameters.AddWithValue("@login_usuario", model.login_usuario);
            command.Parameters.AddWithValue("@senha_usuario", model.senha_usuario);
            command.Parameters.AddWithValue("@fk_id_funcionario", model.fk_id_funcionario);

            ConnectionDB.CRUD(command);
        }

        public void update(Usuario model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Usuario SET login_usuario=@login_usuario, senha_usuario=@senha_usuario, fk_id_funcionario=@fk_id_funcionario " +
                                                 "WHERE id_usuario=@id_usuario"; 
                                               
            command.Parameters.AddWithValue("@login_usuario", model.login_usuario);
            command.Parameters.AddWithValue("@senha_usuario", model.senha_usuario);
            command.Parameters.AddWithValue("@fk_id_funcionario", model.fk_id_funcionario);
            command.Parameters.AddWithValue("@id_usuario", model.id_usuario);

            ConnectionDB.CRUD(command);
        }
        /* public void select(Usuario model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Usuario (login_usuario,senha_usuario,fk_id_usuario) " +
                                               "VALUES (@login_usuario,@senha_usuario,@fk_id_funcionario)";

            command.Parameters.AddWithValue("@login_usuario", model.login_usuario);
            command.Parameters.AddWithValue("@senha_usuario", model.senha_usuario);
            command.Parameters.AddWithValue("@fk_id_funcionario", model.fk_id_funcionario);

            ConnectionDB.CRUD(command);
        }*/ 

        /*public void selectById(Usuario model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Usuario (login_usuario,senha_usuario,fk_id_usuario) " +
                                               "VALUES (@login_usuario,@senha_usuario,@fk_id_funcionario)";

            command.Parameters.AddWithValue("@login_usuario", model.login_usuario);
            command.Parameters.AddWithValue("@senha_usuario", model.senha_usuario);
            command.Parameters.AddWithValue("@fk_id_funcionario", model.fk_id_funcionario);

            ConnectionDB.CRUD(command);
        }*/

        public void delete(Usuario model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Usuario WHERE id_usuario=@id_usuario";

            command.Parameters.AddWithValue("@id_usuario", model.id_usuario);

            ConnectionDB.CRUD(command);
        }
    }
}
