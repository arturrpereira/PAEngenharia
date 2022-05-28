using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Model;

namespace PA.Controller
{
    public class CargoController
    {
        public void save(string desc_cargo, double salario_cargo, int nivel_cargo)
        {
            Cargo model = new Cargo();

            model.desc_cargo = desc_cargo;
            model.salario_cargo = salario_cargo;
            model.nivel_cargo = nivel_cargo;

            model.save();

        }
    }
}
