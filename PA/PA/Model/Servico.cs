using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class Servico
    {
        public int id_servico;
        public string desc_servico;
        public double valor_servico;

        public List<Funcionario> funcionarios = new List<Funcionario>();

        public Servico()
        {
            this.funcionarios = null;
        }


    }
}
