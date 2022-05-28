namespace PA
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            btn_mostrar.Visible = false;
            pictureBox4.Visible = true;

            if (txb_senha.PasswordChar == '*')
            {
                
                txb_senha.PasswordChar = '\0';
            }
           
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            btn_mostrar.Visible = true;
            pictureBox4.Visible = false;

            if (txb_senha.PasswordChar == '\0')
            {

                txb_senha.PasswordChar = '*';
            }
            


        }

        private void txb_senha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_mostrar_MouseDown(object sender, MouseEventArgs e)
        {
            txb_senha.Show();
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            txb_senha.Hide();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {            

        }
    }
}