using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class Material
    {
        public int id_material;
        public string desc_material;
        public double preco_material;
        public int qtd_minima;
        public int qtd_maxima;

        public List<Fornecedor> fornecedores = new List<Fornecedor>();

        public Material()
        {
            this.fornecedores = null;
        }

    }
}
