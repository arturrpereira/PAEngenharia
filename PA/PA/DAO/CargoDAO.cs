using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PA.DAO
{
    public class CargoDAO
    {
        public string conexao;

        public PetDAO()
        {

        }

        public void insert(CargoModel model)
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

        public void update(CargoModel model)
        { 
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE Cargo SET desc_cargo=@desc_cargo, salario_cargo=@salario_cargo, nivel_cargo=@nivel_cargo WHERE id_cargo=@id_cargo";

            command.Parameters.AddWithValue("@desc_cargo", model.desc_cargo);
            command.Parameters.AddWithValue("@salario_cargo", model.salario_cargo);
            command.Parameters.AddWithValue("@nivel_cargo", model.nivel_cargo);
            command.Parameters.AddWithValue("@id_cargo", model.id_cargo);
            
            ConnectionDB.CRUD(command);
        }
        

        public void select(CargoModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Cargo";
        }

        public void selectById(PetModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Cargo WHERE id_cargo=@id_cargo";

            command.Parameters.AddWithValue("@id_cargo", model.id_cargo);
          
            ConnectionDB.CRUD(command);
        }

        public void delete(CargoModel model)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Cargo WHERE id_cargo=@id_cargo";

            command.Parameters.AddWithValue("@id_cargo", model.id_cargo);
          
            ConnectionDB.CRUD(command);
        }
    }
}
