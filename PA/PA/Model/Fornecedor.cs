﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAO;

namespace PA.Model
{
    public class Fornecedor
    {
        public int id_fornecedor;
        public string nomeFantasia;
        public string razaoSocial;
        public string CNPJFornecedor;
        public string inscEstadual;
        public string tipoContribuinte;
        public string email_fornecedor;
        public string responsavel_fornecedor;
        public string contato_responsavel;
        public string telefone_fornecedor;
        public string endereco_fornecedor;

        public List<Material> materiais = new List<Material>();

        public Fornecedor()
        {
            this.materiais = null;
        }

       /* public void insert()
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }*/

        //}
        /* public void update()
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }*/

        //}
        /*public void select()
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }*/

        }

        /* public void selectById()
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }*/

        }

        /* public void delete()
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.insert(this);

            /* if (this.id_funcionario == null)
            {
                dao.insert(this);
            }*/

       // }
    //}
//}
