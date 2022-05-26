namespace PA.View
{
    partial class ClienteView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_nomecliente = new System.Windows.Forms.TextBox();
            this.txb_cpf = new System.Windows.Forms.TextBox();
            this.txb_rg = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_datanascimento = new System.Windows.Forms.MaskedTextBox();
            this.txb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cadastro de Cliente";
            // 
            // txb_nomecliente
            // 
            this.txb_nomecliente.Location = new System.Drawing.Point(118, 56);
            this.txb_nomecliente.Name = "txb_nomecliente";
            this.txb_nomecliente.Size = new System.Drawing.Size(100, 20);
            this.txb_nomecliente.TabIndex = 7;
            // 
            // txb_cpf
            // 
            this.txb_cpf.Location = new System.Drawing.Point(224, 99);
            this.txb_cpf.Name = "txb_cpf";
            this.txb_cpf.Size = new System.Drawing.Size(100, 20);
            this.txb_cpf.TabIndex = 8;
            // 
            // txb_rg
            // 
            this.txb_rg.Location = new System.Drawing.Point(65, 99);
            this.txb_rg.Name = "txb_rg";
            this.txb_rg.Size = new System.Drawing.Size(100, 20);
            this.txb_rg.TabIndex = 9;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(74, 149);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(100, 20);
            this.txb_email.TabIndex = 10;
            // 
            // txb_datanascimento
            // 
            this.txb_datanascimento.Location = new System.Drawing.Point(146, 187);
            this.txb_datanascimento.Mask = "00/00/0000";
            this.txb_datanascimento.Name = "txb_datanascimento";
            this.txb_datanascimento.Size = new System.Drawing.Size(100, 20);
            this.txb_datanascimento.TabIndex = 13;
            this.txb_datanascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txb_telefone
            // 
            this.txb_telefone.Location = new System.Drawing.Point(91, 234);
            this.txb_telefone.Mask = "(99) 00000-0000";
            this.txb_telefone.Name = "txb_telefone";
            this.txb_telefone.Size = new System.Drawing.Size(100, 20);
            this.txb_telefone.TabIndex = 14;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 331);
            this.Controls.Add(this.txb_telefone);
            this.Controls.Add(this.txb_datanascimento);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_rg);
            this.Controls.Add(this.txb_cpf);
            this.Controls.Add(this.txb_nomecliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClienteView";
            this.Text = "ClienteView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_nomecliente;
        private System.Windows.Forms.TextBox txb_cpf;
        private System.Windows.Forms.TextBox txb_rg;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.MaskedTextBox txb_datanascimento;
        private System.Windows.Forms.MaskedTextBox txb_telefone;
    }
}