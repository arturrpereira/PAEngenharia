using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Model;
using Npgsql;
using PA.db;

namespace PA.DAO
{
    public class ClienteDAO
    {
        public void insert(Cliente model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Usuario (nome_cliente,rg_cliente,email_cliente,cpf_cliente,telefone_cliente,datanasc_cliente,endereco_cliente,numero_endereco_cliente,bairro_cliente,fk_id_usuario) " +
                                               "VALUES (@nome_cliente,@rg_cliente,@email_cliente,@cpf_cliente,@telefone_cliente,@datanasc_cliente,@endereco_cliente,@numero_endereco_cliente,@bairro_cliente,@fk_id_usuario)";

            command.Parameters.AddWithValue("@nome_cliente", model.nome_cliente);
            command.Parameters.AddWithValue("@rg_cliente", model.rg_cliente);
            command.Parameters.AddWithValue("@email_cliente", model.email_cliente);
            command.Parameters.AddWithValue("@cpf_cliente", model.cpf_cliente);
            command.Parameters.AddWithValue("@telefone_cliente", model.telefone_cliente);
            command.Parameters.AddWithValue("@datanasc_cliente", model.dataNasc_cliente);
            command.Parameters.AddWithValue("@endereco_cliente", model.endereco_cliente);
            command.Parameters.AddWithValue("@numero_endereco_cliente", model.numero_endereco_cliente);
            command.Parameters.AddWithValue("@bairro_cliente", model.bairro_cliente);
            command.Parameters.AddWithValue("@fk_id_usuario", model.fk_id_usuario);

            ConnectionDB.CRUD(command);
        }

        public void update(Cliente model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Cliente SET nome_cliente=@nome_cliente, rg_cliente=@rg_cliente, email_cliente=@email_cliente, cpf_cliente=@cpf_cliente, telefone_cliente=@telefone_cliente, datanasc_cliente=@datanasc_cliente, endereco_cliente=@endereco_cliente, numero_endereco_cliente=@numero_endereco_cliente, bairro_cliente=@bairro_cliente, fk_id_usuario=@fk_id_usuario" +
                                                 "WHERE id_cliente=@id_cliente";

            command.Parameters.AddWithValue("@nome_cliente", model.nome_cliente);
            command.Parameters.AddWithValue("@rg_cliente", model.rg_cliente);
            command.Parameters.AddWithValue("@email_cliente", model.email_cliente);
            command.Parameters.AddWithValue("@cpf_cliente", model.cpf_cliente);
            command.Parameters.AddWithValue("@telefone_cliente", model.telefone_cliente);
            command.Parameters.AddWithValue("@datanasc_cliente", model.dataNasc_cliente);
            command.Parameters.AddWithValue("@endereco_cliente", model.endereco_cliente);
            command.Parameters.AddWithValue("@numero_endereco_cliente", model.numero_endereco_cliente);
            command.Parameters.AddWithValue("@bairro_cliente", model.bairro_cliente);
            command.Parameters.AddWithValue("@fk_id_usuario", model.fk_id_usuario);

            command.Parameters.AddWithValue("@id_cliente", model.id_cliente);

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

        public void delete(Cliente model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Cliente WHERE id_cliente=@id_cliente";

            command.Parameters.AddWithValue("@id_cliente", model.id_cliente);

            ConnectionDB.CRUD(command);
        }
    }
}
