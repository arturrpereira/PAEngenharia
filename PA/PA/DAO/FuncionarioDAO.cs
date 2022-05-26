using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PA.DAO
{
    public class FuncionarioDAO
    {
        public string conexao;

        public FuncionarioDAO()
        {

        }

        public void insert(FuncionarioModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Funcionario (nome_funcionario, rg_funcionario, cpf_funcionario, endereco_funcionario, dataAdmissao_funcionario, dataNasc_funcionario, genero_funcionario, telefone_funcionario, fk_id_cargo) " +
                                                   "VALUES (@nome_funcionario, @rg_funcionario, @cpf_funcionario, @endereco_funcionario, @dataAdmissao_funcionario, @dataNasc_funcionario, @genero_funcionario, @telefone_funcionario, @fk_id_cargo)";

            command.Parameters.AddWithValue("@nome_funcionario", model.nome_funcionario);
            command.Parameters.AddWithValue("@rg_funcionario", model.rg_funcionario);
            command.Parameters.AddWithValue("@cpf_funcionario", model.cpf_funcionario);
            command.Parameters.AddWithValue("@endereco_funcionario", model.endereco_funcionario);
            command.Parameters.AddWithValue("@dataAdmissao_funcionario", model.dataAdmissao_funcionario);
            command.Parameters.AddWithValue("@dataNasc_funcionario", model.dataNasc_funcionario);
            command.Parameters.AddWithValue("@genero_funcionario", model.genero_funcionario);
            command.Parameters.AddWithValue("@telefone_funcionario", model.telefone_funcionario);
            command.Parameters.AddWithValue("@fk_id_cargo", model.fk_id_cargo);
          
            ConnectionDB.CRUD(command);
        }

        public void update(FuncionarioModel model)
        { 
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Funcionario SET nome_funcionario=@nome_funcionario, rg_funcionario=@rg_funcionario, cpf_funcionario=@cpf_funcionario, endereco_funcionario=@endereco_funcionario, dataAdmissao_funcionario=@dataAdmissao_funcionario, dataNasc_funcionario=@dataNasc_funcionario, genero_funcionario=@genero_funcionario, telefone_funcionario=@telefone_funcionario, fk_id_cargo=@fk_id_cargo WHERE id_funcionario=@id_funcionario";

            command.Parameters.AddWithValue("@id_funcionario", model.id_funcionario);
            command.Parameters.AddWithValue("@nome_funcionario", model.nome_funcionario);
            command.Parameters.AddWithValue("@rg_funcionario", model.rg_funcionario);
            command.Parameters.AddWithValue("@cpf_funcionario", model.cpf_funcionario);
            command.Parameters.AddWithValue("@endereco_funcionario", model.endereco_funcionario);
            command.Parameters.AddWithValue("@dataAdmissao_funcionario", model.dataAdmissao_funcionario);
            command.Parameters.AddWithValue("@dataNasc_funcionario", model.dataNasc_funcionario);
            command.Parameters.AddWithValue("@genero_funcionario", model.genero_funcionario);
            command.Parameters.AddWithValue("@telefone_funcionario", model.telefone_funcionario);
            command.Parameters.AddWithValue("@fk_id_cargo", model.fk_id_cargo);
          
            ConnectionDB.CRUD(command);
        }
        

        public void select(FuncionarioModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Funcionario";
        }

        public void selectById(FuncionarioModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Funcionario WHERE id_funcionario=@id_funcionario";

            command.Parameters.AddWithValue("@id_funcionario", model.id_funcionario);
          
            ConnectionDB.CRUD(command);
        }

        public void delete(FuncionarioModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Funcionario WHERE id_funcionario=@id_funcionario";

            command.Parameters.AddWithValue("@id_funcionario", model.id_funcionario);
          
            ConnectionDB.CRUD(command);
        }
    }
}
