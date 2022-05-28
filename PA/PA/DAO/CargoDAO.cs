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
    public class CargoDAO
    {
        public void insert(Cargo model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Cargo (desc_cargo, salario_cargo, nivel_cargo) " +
                                             "VALUES (@desc_cargo, @salario_cargo, @nivel_cargo)";

            command.Parameters.AddWithValue("@desc_cargo", model.desc_cargo);
            command.Parameters.AddWithValue("@salario_cargo", model.salario_cargo);
            command.Parameters.AddWithValue("@nivel_cargo", model.nivel_cargo);

            ConnectionDB.CRUD(command);
        }

        public void update(Cargo model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Cargo SET desc_cargo=@desc_cargo, salario_cargo=@salario_cargo, nivel_cargo=@nivel_cargo" +
                                                 "WHERE id_cargo=@id_cargo";

            command.Parameters.AddWithValue("@desc_cargo", model.desc_cargo);
            command.Parameters.AddWithValue("@salario_cargo", model.salario_cargo);
            command.Parameters.AddWithValue("@nivel_cargo", model.nivel_cargo);
            command.Parameters.AddWithValue("@id_cargo", model.id_cargo);

            ConnectionDB.CRUD(command);
        }

        /*public void select(UsuarioModel model)
        {
            // colocar a linha de insert

            //linha de dar o comando no banco

            //receber os valores do controler

            // executar a query
        }*/

        /* public void selectById(UsuarioModel model)
        {
            // colocar a linha de insert

            //linha de dar o comando no banco

            //receber os valores do controler

            // executar a query
        }*/

        public void delete(Cargo model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Cargo WHERE id_cargo=@id_cargo";

            command.Parameters.AddWithValue("@id_usuario", model.id_cargo);

            ConnectionDB.CRUD(command);
        }
    }
}
