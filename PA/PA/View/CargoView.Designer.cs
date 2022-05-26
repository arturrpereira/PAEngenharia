namespace PA.View
{
    partial class CargoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargoView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_desccargo = new System.Windows.Forms.TextBox();
            this.txb_salario = new System.Windows.Forms.TextBox();
            this.txb_nivelcargo = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição de Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel de Cargo";
            // 
            // txb_desccargo
            // 
            this.txb_desccargo.Location = new System.Drawing.Point(58, 102);
            this.txb_desccargo.Name = "txb_desccargo";
            this.txb_desccargo.Size = new System.Drawing.Size(132, 20);
            this.txb_desccargo.TabIndex = 4;
            // 
            // txb_salario
            // 
            this.txb_salario.Location = new System.Drawing.Point(58, 169);
            this.txb_salario.Name = "txb_salario";
            this.txb_salario.Size = new System.Drawing.Size(132, 20);
            this.txb_salario.TabIndex = 5;
            // 
            // txb_nivelcargo
            // 
            this.txb_nivelcargo.Location = new System.Drawing.Point(58, 244);
            this.txb_nivelcargo.Name = "txb_nivelcargo";
            this.txb_nivelcargo.Size = new System.Drawing.Size(132, 20);
            this.txb_nivelcargo.TabIndex = 6;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(58, 288);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(113, 27);
            this.btn_salvar.TabIndex = 7;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // CargoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txb_nivelcargo);
            this.Controls.Add(this.txb_salario);
            this.Controls.Add(this.txb_desccargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CargoView";
            this.Text = "CargoView";
            this.Load += new System.EventHandler(this.CargoView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_desccargo;
        private System.Windows.Forms.TextBox txb_salario;
        private System.Windows.Forms.TextBox txb_nivelcargo;
        private System.Windows.Forms.Button btn_salvar;
    }
}