using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Model;

namespace PA.Controller
{
    public class ClienteController
    {
        public void save(string nome_cliente, string rg_cliente, string email_cliente, string cpf_cliente, string telefone_cliente, string datanasc_cliente, string endereco_cliente, int numero_endereco_cliente, string bairro_cliente, int fk_id_usuario)
        {
            Cliente model = new Cliente();

            model.nome_cliente = nome_cliente;
            model.rg_cliente = rg_cliente;
            model.email_cliente = email_cliente;
            model.cpf_cliente = cpf_cliente;
            model.telefone_cliente = telefone_cliente;
            model.dataNasc_cliente = datanasc_cliente;
            model.endereco_cliente = endereco_cliente;
            model.numero_endereco_cliente = numero_endereco_cliente;
            model.bairro_cliente = bairro_cliente;
            model.fk_id_usuario = fk_id_usuario;

            model.save();
        }
    }
}
