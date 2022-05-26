using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PA.DAO
{
    public class PetDAO
    {
        public string conexao;

        public PetDAO()
        {

        }

        public void insert(PetModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Pet (nome_pet, idade_pet, tipo_pet, raca_pet, porte_pet, cor_pet, fk_id_cliente) " +
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

        public void update(PetModel model)
        { 
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Pet SET nome_pet=@nome_pet, idade_pet=@idade_pet, tipo_pet=@tipo_pet, raca_pet=@raca_pet, porte_pet=@porte_pet, cor_pet=@cor_pet, fk_id_cliente=@fk_id_cliente";

            command.Parameters.AddWithValue("@nome_pet", model.nome_pet);
            command.Parameters.AddWithValue("@idade_pet", model.idade_pet);
            command.Parameters.AddWithValue("@tipo_pet", model.tipo_pet);
            command.Parameters.AddWithValue("@raca_pet", model.raca_pet);
            command.Parameters.AddWithValue("@porte_pet", model.porte_pet);
            command.Parameters.AddWithValue("@cor_pet", model.cor_pet);
            command.Parameters.AddWithValue("@fk_id_cliente", model.fk_id_cliente);
          
            ConnectionDB.CRUD(command);
        }
        

        public void select(PetModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Usuario WHERE login_usuario=@login_usuario AND senha_usuario=@senha_usuario";
        }

        public void selectById(PetModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Pet WHERE id_pet=@id_pet";

            command.Parameters.AddWithValue("@id_pet", model.id_pet);
          
            ConnectionDB.CRUD(command);
        }

        public void delete(UsuarioModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Pet WHERE id_pet=@id_pet";

            command.Parameters.AddWithValue("@id_pet", model.id_pet);
          
            ConnectionDB.CRUD(command);
        }
    }
}
