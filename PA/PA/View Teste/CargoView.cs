using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA.View_Teste
{
    public partial class CargoView : Form
    {
        public CargoView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var desc = txb_descricao.Text;
            var salario = nmr_salario.Value;
            var nivel = nrm_nivel.Value;

             
        }
    }
}
