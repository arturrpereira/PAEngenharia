using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class Movimentacao
    {
        public int id_movimentacao;
        public string data_movimentacao;
        public int qtd_movimentacao;
        public string tipo_movimentacao;
        public double valor_movimentacao;
        public int fk_id_material;
        public int fk_id_estoque;
    }
}
