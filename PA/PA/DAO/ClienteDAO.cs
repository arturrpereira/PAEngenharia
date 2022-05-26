using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PA.DAO
{
    public class ClienteDAO
    {
        public string conexao;

        public ClienteDAO()
        {

        }

        public void insert(ClienteModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Cliente (nome_cliente, rg_cliente, email_cliente, cpf_cliente, telefone_cliente, datanasc_cliente) " +
                                               "VALUES (@nome_cliente, @rg_cliente, @email_cliente, @cpf_cliente, @telefone_cliente, @datanasc_cliente)";

            command.Parameters.AddWithValue("@nome_cliente", model.nome_cliente);
            command.Parameters.AddWithValue("@rg_cliente", model.rg_cliente);
            command.Parameters.AddWithValue("@email_cliente", model.email_cliente);
            command.Parameters.AddWithValue("@cpf_cliente", model.cpf_cliente);
            command.Parameters.AddWithValue("@telefone_cliente", model.telefone_cliente);
            command.Parameters.AddWithValue("@datanasc_cliente", model.datanasc_cliente);
          
            ConnectionDB.CRUD(command);
        }

        public void update(ClienteModel model)
        { 
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Cliente SET nome_cliente=@nome_cliente, rg_cliente=@rg_cliente, email_cliente=@email_cliente, cpf_cliente=@cpf_cliente, telefone_cliente=@telefone_cliente datanasc_cliente=@datanasc_cliente WHERE id_cliente=@id_cliente";

            command.Parameters.AddWithValue("@nome_cliente", model.nome_cliente);
            command.Parameters.AddWithValue("@rg_cliente", model.rg_cliente);
            command.Parameters.AddWithValue("@email_cliente", model.email_cliente);
            command.Parameters.AddWithValue("@cpf_cliente", model.cpf_cliente);
            command.Parameters.AddWithValue("@telefone_cliente", model.telefone_cliente);
            command.Parameters.AddWithValue("@datanasc_cliente", model.datanasc_cliente);
            command.Parameters.AddWithValue("@id_cliente", model.id_cliente);
          
            ConnectionDB.CRUD(command);
        }
        

        public void select(ClienteModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Cargo";
        }

        public void selectById(ClienteModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Cliente WHERE id_cliente=@id_cliente";

            command.Parameters.AddWithValue("@id_cliente", model.id_cliente);
          
            ConnectionDB.CRUD(command);
        }

        public void delete(ClienteModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Cliente WHERE id_cliente=@id_cliente";

            command.Parameters.AddWithValue("@id_cliente", model.id_cliente);
          
            ConnectionDB.CRUD(command);
        }
    }
}
