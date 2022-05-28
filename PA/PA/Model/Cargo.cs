using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAO;

namespace PA.Model
{
    public class Cargo
    {
        public int id_cargo;
        public string desc_cargo;
        public double salario_cargo;
        public int nivel_cargo;

        public void save()
        {
            CargoDAO dao = new CargoDAO();

            dao.insert(this);


           /* if (this.id_cargo == null)
            {
                dao.insert(this);
            }
            else
            {
                //dao.update(this);
            }*/
        }
    }
}
