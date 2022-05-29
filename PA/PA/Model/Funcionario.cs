using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAO;

namespace PA.Model
{
    public class Funcionario
    {
        public int id_funcionario;
        public string nome_funcionario;
        public string rg_funcionario;
        public string cpf_funcionario;
        public string endereco_funcionario;
        public int numero_endereco_funcionario;
        public string bairro_funcionario;
        public string dataAdmissao_funcionario;
        public string dataNasc_funcionario;
        public string genero_funcionario;
        public string telefone_funcionario;
        public int fk_id_cargo;

        public List<Servico> servicos = new List<Servico>();

        public Funcionario()
        {
            this.servicos = null;
        }

        public void save()
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }*/

        }

        /*public void save()
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }

        }*/

        /*public void save()
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }

        }*/

        /*public void save()
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }

        }*/

        /* public void save()
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }

        }*/
    }
}
