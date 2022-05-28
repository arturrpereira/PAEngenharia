using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PA.Controller;

namespace PA.View
{
    public partial class funcionarios : Form
    {
        public funcionarios()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxRG_KeyPress(object sender, KeyPressEventArgs e)

        {

            if (!char.IsDigit(e.KeyChar))

            {
                e.Handled = true;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void enviar_funcionario_Click(object sender, EventArgs e)
        {
            var nome_funcionario = txb_nome_funcionario.Text;
            var rg_funcionario = txb_rg_funcionario.Text;
            var cpf_funcionario = txb_cpf_funcionario.Text;
            var endereco_funcionario = txb_rua_funcionario.Text;
            var numero_endereco_funcionario = nrm_numero_endereco.Value;
            var bairro_funcionario = txb_bairro_funcionario.Text;
            var dataAdmissao_funcionario = data_admissao_funcionario.Text;
            var dataNasc_funcionario = data_nascimento_funcionario.Text;
            var genero_funcionario = txb_genero_funcionario.Text;
            var telefone_funcionario = numerotel_funcionario;
            // var fk_id_cargo = nmr_fk_cargo;


            FuncionarioController controller = new FuncionarioController();
            // controller.save(nome_funcionario, rg_funcionario, cpf_funcionario, endereco_funcionario, numero_endereco_funcionario, bairro_funcionario, dataAdmissao_funcionario, dataNasc_funcionario, genero_funcionario, telefone_funcionario);



        }
    }
}
