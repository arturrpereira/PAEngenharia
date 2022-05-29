using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAO;

namespace PA.Model
{
    public class Pet
    {
        public int id_pet;
        public string nome_pet;
        public int idade_pet;
        public string tipo_pet;
        public string raca_pet;
        public string porte_pet;
        public string cor_pet;
        public int fk_id_cliente;

        public void save()
        {
            PetDAO dao = new PetDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }*/

        }
    }
}
