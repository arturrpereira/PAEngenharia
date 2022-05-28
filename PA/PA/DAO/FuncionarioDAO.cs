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
    public class FuncionarioDAO
    {
        public void insert(Funcionario model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Funcionario (nome_funcionario,rg_funcionario,cpf_funcionario,endereco_funcionario,numero_endereco_funcionario,bairro_funcionario,dataadmissao_funcionario,datanasc_funcionario,genero_funcionario,telefone_funcionario,fk_id_cargo) " +
                                  "VALUES (@nome_funcionario,@rg_funcionario,@cpf_funcionario,@endereco_funcionario,@numero_endereco_funcionario,@bairro_funcionario,@dataadmissao_funcionario,@datanasc_funcionario,@genero_funcionario,@telefone_funcionario,@fk_id_cargo)";

            command.Parameters.AddWithValue("@nome_funcionario", model.nome_funcionario);
            command.Parameters.AddWithValue("@rg_funcionario", model.rg_funcionario);
            command.Parameters.AddWithValue("@cpf_funcionario", model.cpf_funcionario);
            command.Parameters.AddWithValue("@endereco_funcionario", model.endereco_funcionario);
            command.Parameters.AddWithValue("@numero_endereco_funcionario", model.numero_endereco_funcionario);
            command.Parameters.AddWithValue("@bairro_funcionario", model.bairro_funcionario);
            command.Parameters.AddWithValue("@dataadmissao_funcionario", model.dataAdmissao_funcionario);
            command.Parameters.AddWithValue("@datanasc_funcionario", model.dataNasc_funcionario);
            command.Parameters.AddWithValue("@genero_funcionario", model.genero_funcionario);
            command.Parameters.AddWithValue("@telefone_funcionario", model.telefone_funcionario);
            command.Parameters.AddWithValue("@fk_id_cargo", model.fk_id_cargo);

            ConnectionDB.CRUD(command);
        }
    }
}
