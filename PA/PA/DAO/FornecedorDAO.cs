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
    public class FornecedorDAO
    {
        /*public void insert(Fornecedor model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Fornecedor (nome_pet, idade_pet, tipo_pet, raca_pet, porte_pet, cor_pet, fk_id_cliente) " +
                                  "VALUES (@nome_pet, @idade_pet, @tipo_pet, @raca_pet, @porte_pet, @cor_pet, @fk_id_cliente)";

            command.Parameters.AddWithValue("@nome_pet", model.nome_pet);
            command.Parameters.AddWithValue("@idade_pet", model.idade_pet);
            command.Parameters.AddWithValue("@tipo_pet", model.tipo_pet);
            command.Parameters.AddWithValue("@raca_pet", model.raca_pet);
            command.Parameters.AddWithValue("@porte_pet", model.porte_pet);
            command.Parameters.AddWithValue("@cor_pet", model.cor_pet);
            command.Parameters.AddWithValue("@fk_id_cliente", model.fk_id_cliente);

            ConnectionDB.CRUD(command);
        }

        public void update(Pet model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Pet SET nome_pet=@nome_pet, idade_pet=@idade_pet, tipo_pet=@tipo_pet, raca_pet=@raca_pet, porte_pet=@porte_pet, cor_pet=@cor_pet, fk_id_cliente=@fk_id_cliente " +
                                                 "WHERE id_pet=@id_pet";

            command.Parameters.AddWithValue("@nome_pet", model.nome_pet);
            command.Parameters.AddWithValue("@idade_pet", model.idade_pet);
            command.Parameters.AddWithValue("@tipo_pet", model.tipo_pet);
            command.Parameters.AddWithValue("@raca_pet", model.raca_pet);
            command.Parameters.AddWithValue("@porte_pet", model.porte_pet);
            command.Parameters.AddWithValue("@cor_pet", model.cor_pet);
            command.Parameters.AddWithValue("@fk_id_cliente", model.fk_id_cliente);
            command.Parameters.AddWithValue("@id_pet", model.id_pet);

            ConnectionDB.CRUD(command);
        }

        public void select(Pet model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Pet";

            NpgsqlDataReader dr = ConnectionDB.Select(command);

            /* if (dr.HasRows)
            {
                dr.Read();
                Global.id_usuario = (int)dr["id_usuario"];
                Global.login_usuario = (string)dr["login_usuario"];
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void selectById(Pet model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Pet WHERE id_pet=@id_pet";

            command.Parameters.AddWithValue("@id_pet", model.id_pet);

            NpgsqlDataReader dr = ConnectionDB.Select(command);
        }

        public void delete(Pet model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Pet WHERE id_pet=@id_pet";

            command.Parameters.AddWithValue("@id_pet", model.id_pet);

            ConnectionDB.CRUD(command);
        }*/
    }
}
