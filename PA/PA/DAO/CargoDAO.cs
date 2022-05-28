using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Model;
using Npgsql;

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

            //linha de dar o comando no banco

            //receber os valores do controler

            // executar a query
        }
    }
}
