using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class PetModel
    {
        private int id_pet;
        private string nome_pet; 
        private int idade_pet; 
        private string tipo_pet; 
        private string raca_pet; 
        private string porte_pet; 
        private string cor_pet; 
        private int fk_id_cliente;

        public PetModel() {

            this.nome_pet = nome_pet;
            this.idade_pet = idade_pet;
            this.tipo_pet = tipo_pet;
            this.raca_pet = raca_pet;
            this.porte_pet = porte_pet;
            this.cor_pet = cor_pet;
            this.fk_id_cliente = fk_id_cliente;
        }
    }
}
