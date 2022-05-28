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
            command.CommandText = "INSERT INTO Time (desc_time, tier_time, abreviacao_time, dono_time, fk_id_usuario) " +
                                  "VALUES (@desc_time, @tier_time, @abreviacao_time, @dono_time, @fk_id_usuario)";

            /* command.Parameters.AddWithValue("@desc_time", model.Desc_time);
            command.Parameters.AddWithValue("@tier_time", model.Tier_time);
            command.Parameters.AddWithValue("@tier_time", model.Tier_time);
            command.Parameters.AddWithValue("@tier_time", model.Tier_time);
            command.Parameters.AddWithValue("@tier_time", model.Tier_time);
            command.Parameters.AddWithValue("@tier_time", model.Tier_time);
            command.Parameters.AddWithValue("@tier_time", model.Tier_time);
            command.Parameters.AddWithValue("@abreviacao_time", model.Abreviacao_time);
            command.Parameters.AddWithValue("@dono_time", model.Dono_time);
            command.Parameters.AddWithValue("@fk_id_usuario", model.Fk_id_usuario);*/ 

            ConnectionDB.CRUD(command);
        }
    }
}
