namespace SistemaSorteio.IHM
{
    partial class TelaCadastro
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
            this.l_titulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_pergunta = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.rb_participante = new System.Windows.Forms.RadioButton();
            this.rb_Sorteador = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_rua = new System.Windows.Forms.TextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_cep = new System.Windows.Forms.MaskedTextBox();
            this.tb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.l_tipoConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Usuário:";
            // 
            // l_titulo
            // 
            this.l_titulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_titulo.Location = new System.Drawing.Point(12, 18);
            this.l_titulo.Name = "l_titulo";
            this.l_titulo.Size = new System.Drawing.Size(548, 22);
            this.l_titulo.TabIndex = 0;
            this.l_titulo.Text = "CADASTRO";
            this.l_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefone:";
            // 
            // l_pergunta
            // 
            this.l_pergunta.AutoSize = true;
            this.l_pergunta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_pergunta.Location = new System.Drawing.Point(44, 201);
            this.l_pergunta.Name = "l_pergunta";
            this.l_pergunta.Size = new System.Drawing.Size(224, 16);
            this.l_pergunta.TabIndex = 5;
            this.l_pergunta.Text = "Você é Participante ou Sorteador?";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(137, 59);
            this.tb_usuario.MaxLength = 200;
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(159, 20);
            this.tb_usuario.TabIndex = 0;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(137, 88);
            this.tb_email.MaxLength = 200;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(159, 20);
            this.tb_email.TabIndex = 1;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(137, 116);
            this.tb_senha.MaxLength = 30;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(159, 20);
            this.tb_senha.TabIndex = 2;
            // 
            // rb_participante
            // 
            this.rb_participante.AutoSize = true;
            this.rb_participante.Checked = true;
            this.rb_participante.Location = new System.Drawing.Point(47, 230);
            this.rb_participante.Name = "rb_participante";
            this.rb_participante.Size = new System.Drawing.Size(81, 17);
            this.rb_participante.TabIndex = 5;
            this.rb_participante.TabStop = true;
            this.rb_participante.Text = "Participante";
            this.rb_participante.UseVisualStyleBackColor = true;
            // 
            // rb_Sorteador
            // 
            this.rb_Sorteador.AutoSize = true;
            this.rb_Sorteador.Location = new System.Drawing.Point(183, 230);
            this.rb_Sorteador.Name = "rb_Sorteador";
            this.rb_Sorteador.Size = new System.Drawing.Size(71, 17);
            this.rb_Sorteador.TabIndex = 6;
            this.rb_Sorteador.Text = "Sorteador";
            this.rb_Sorteador.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rua:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(355, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(355, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Estado:";
            // 
            // tb_rua
            // 
            this.tb_rua.Location = new System.Drawing.Point(412, 59);
            this.tb_rua.Name = "tb_rua";
            this.tb_rua.ReadOnly = true;
            this.tb_rua.Size = new System.Drawing.Size(148, 20);
            this.tb_rua.TabIndex = 17;
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(412, 92);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.ReadOnly = true;
            this.tb_bairro.Size = new System.Drawing.Size(148, 20);
            this.tb_bairro.TabIndex = 18;
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(412, 120);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.ReadOnly = true;
            this.tb_cidade.Size = new System.Drawing.Size(148, 20);
            this.tb_cidade.TabIndex = 19;
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(412, 147);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.ReadOnly = true;
            this.tb_estado.Size = new System.Drawing.Size(148, 20);
            this.tb_estado.TabIndex = 20;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(358, 206);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(202, 46);
            this.btn_Cadastrar.TabIndex = 7;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(326, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(2, 131);
            this.label12.TabIndex = 22;
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(137, 169);
            this.tb_cep.Mask = "00000-000";
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(159, 20);
            this.tb_cep.TabIndex = 4;
            this.tb_cep.TextChanged += new System.EventHandler(this.tb_cep_TextChanged);
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(137, 143);
            this.tb_telefone.Mask = "(00) 00000-0000";
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(159, 20);
            this.tb_telefone.TabIndex = 3;
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_apagar.Location = new System.Drawing.Point(137, 206);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(159, 46);
            this.btn_apagar.TabIndex = 23;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Visible = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // l_tipoConta
            // 
            this.l_tipoConta.AutoSize = true;
            this.l_tipoConta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_tipoConta.Location = new System.Drawing.Point(12, 212);
            this.l_tipoConta.Name = "l_tipoConta";
            this.l_tipoConta.Size = new System.Drawing.Size(117, 16);
            this.l_tipoConta.TabIndex = 24;
            this.l_tipoConta.Text = "TIPO DE CONTA:\r\n";
            this.l_tipoConta.Visible = false;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 264);
            this.Controls.Add(this.l_tipoConta);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.tb_cep);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.tb_bairro);
            this.Controls.Add(this.tb_rua);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rb_Sorteador);
            this.Controls.Add(this.rb_participante);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.l_pergunta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_titulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_pergunta;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.RadioButton rb_participante;
        private System.Windows.Forms.RadioButton rb_Sorteador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_rua;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox tb_cep;
        private System.Windows.Forms.MaskedTextBox tb_telefone;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Label l_tipoConta;
    }
}