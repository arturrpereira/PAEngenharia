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
    public partial class FuncionarioView : Form
    {
        public FuncionarioView()
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
        {/*
            var nome_funcionario = txb_nome_funcionario.Text;
            var rg_funcionario = txb_rg_funcionario.Text;
            var cpf_funcionario = txb_cpf_funcionario.Text;
            var endereco_funcionario = txb_endereco_funcionario.Text;
            var numero_endereco_funcionario = nmr_numero_endereco.Value;
            var bairro_funcionario = txb_bairro_funcionario.Text;
            var dataAdmissao_funcionario = txb_dataAdmissao_funcionario.Text;
            var dataNasc_funcionario = txb_dataNasc_funcionario.Text;
            var genero_funcionario = txb_genero_funcionario.Text;
            var telefone_funcionario = txb_telefone_funcionario.Text;
            var fk_id_cargo = nmr_id_cargo.Value;

            FuncionarioController controller = new FuncionarioController();

            try
            {
                controller.save(nome_funcionario, rg_funcionario, cpf_funcionario, endereco_funcionario, (int)numero_endereco_funcionario, bairro_funcionario, dataAdmissao_funcionario, dataAdmissao_funcionario, genero_funcionario, telefone_funcionario, (int)fk_id_cargo);
                MessageBox.Show("Cadastrado com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO: ");
            }*/
        }

        private void txb_endereco_funcionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txb_nome_funcionario.Enabled = true;
            txb_rg_funcionario.Enabled = true;
            txb_cpf_funcionario.Enabled = true;
            cob_genero_funcionario.Enabled = true;
            txb_datanasc_funcionario.Enabled = true;
            txb_dataadmi_funcionario.Enabled = true;
            txb_endereco_funcionario.Enabled = true;
            txb_numero_residencia.Enabled = true;
            txb_bairro_funcionario.Enabled = true;
            txb_telefone_funcionario.Enabled = true;
           
        
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void enviar_funcionario_Click_1(object sender, EventArgs e)
        {
            /* var nome_funcionario = txb_nome_funcionario.Enabled = true;
            var rg_funcionario txb_rg_funcionario.Enabled = true;
            var nome_funcionario txb_cpf_funcionario.Enabled = true;
            var nome_funcionario cob_genero_funcionario.Enabled = true;
            var nome_funcionario txb_datanasc_funcionario.Enabled = true;
            var nome_funcionariotxb_dataadmi_funcionario.Enabled = true;
            var nome_funcionariotxb_endereco_funcionario.Enabled = true;
            var nome_funcionariotxb_numero_residencia.Enabled = true;
            var nome_funcionariotxb_bairro_funcionario.Enabled = true;
            var nome_funcionariotxb_telefone_funcionario.Enabled = true;*/
        }
    }
}
