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
    }
}
