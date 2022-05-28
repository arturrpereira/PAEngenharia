﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PA.View
{
    public partial class index : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraServico_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }
        private void AbrirNOPrincipal(object form)
        {
            if (this.Principal.Controls.Count > 0)
                this.Principal.Controls.RemoveAt(0);
            Form principal = form as Form;
            principal.TopLevel = false;
            principal.Dock = DockStyle.Fill;
            this.Principal.Controls.Add(principal);
            this.Principal.Tag = principal;
            principal.Show();

        }

        private void btnCadPet_Click(object sender, EventArgs e)
        {

        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            AbrirNOPrincipal(new funcionarios());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }
    }
}
