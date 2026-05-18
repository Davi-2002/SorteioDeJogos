namespace SistemaSorteio.IHM
{
    partial class TelaMenuParticipante
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
            this.dgv_ListaSorteios = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.l_conta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_editarUsuario = new System.Windows.Forms.Button();
            this.btn_SorteiosGanhos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cb_Genero = new System.Windows.Forms.ComboBox();
            this.tb_nomeJogo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaSorteios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListaSorteios
            // 
            this.dgv_ListaSorteios.AllowUserToResizeColumns = false;
            this.dgv_ListaSorteios.AllowUserToResizeRows = false;
            this.dgv_ListaSorteios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListaSorteios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaSorteios.Location = new System.Drawing.Point(13, 12);
            this.dgv_ListaSorteios.Name = "dgv_ListaSorteios";
            this.dgv_ListaSorteios.ReadOnly = true;
            this.dgv_ListaSorteios.RowHeadersVisible = false;
            this.dgv_ListaSorteios.Size = new System.Drawing.Size(775, 363);
            this.dgv_ListaSorteios.TabIndex = 30;
            this.dgv_ListaSorteios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListaSorteios_CellContentClick);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(-12, 426);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(841, 61);
            this.label12.TabIndex = 31;
            // 
            // l_conta
            // 
            this.l_conta.AutoSize = true;
            this.l_conta.BackColor = System.Drawing.SystemColors.Desktop;
            this.l_conta.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_conta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_conta.Location = new System.Drawing.Point(14, 446);
            this.l_conta.Name = "l_conta";
            this.l_conta.Size = new System.Drawing.Size(84, 22);
            this.l_conta.TabIndex = 32;
            this.l_conta.Text = "CONTA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(488, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "SORTEIOS GANHOS:";
            // 
            // btn_editarUsuario
            // 
            this.btn_editarUsuario.Location = new System.Drawing.Point(104, 437);
            this.btn_editarUsuario.Name = "btn_editarUsuario";
            this.btn_editarUsuario.Size = new System.Drawing.Size(90, 37);
            this.btn_editarUsuario.TabIndex = 34;
            this.btn_editarUsuario.Text = "EDITAR";
            this.btn_editarUsuario.UseVisualStyleBackColor = true;
            this.btn_editarUsuario.Click += new System.EventHandler(this.btn_editarUsuario_Click);
            // 
            // btn_SorteiosGanhos
            // 
            this.btn_SorteiosGanhos.Location = new System.Drawing.Point(698, 437);
            this.btn_SorteiosGanhos.Name = "btn_SorteiosGanhos";
            this.btn_SorteiosGanhos.Size = new System.Drawing.Size(90, 37);
            this.btn_SorteiosGanhos.TabIndex = 35;
            this.btn_SorteiosGanhos.Text = "VISUALIZAR";
            this.btn_SorteiosGanhos.UseVisualStyleBackColor = true;
            this.btn_SorteiosGanhos.Click += new System.EventHandler(this.btn_SorteiosGanhos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Gênero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nome do Jogo:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(698, 381);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(90, 40);
            this.btn_buscar.TabIndex = 39;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cb_Genero
            // 
            this.cb_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Genero.FormattingEnabled = true;
            this.cb_Genero.Items.AddRange(new object[] {
            "",
            "Ação",
            "Aventura",
            "RPG",
            "Ritmo",
            "Esportes",
            "Corrida",
            "Luta",
            "FPS",
            "Simulação",
            "Plataforma",
            "Puzzle",
            "Terror"});
            this.cb_Genero.Location = new System.Drawing.Point(361, 399);
            this.cb_Genero.Name = "cb_Genero";
            this.cb_Genero.Size = new System.Drawing.Size(331, 21);
            this.cb_Genero.TabIndex = 38;
            // 
            // tb_nomeJogo
            // 
            this.tb_nomeJogo.Location = new System.Drawing.Point(13, 399);
            this.tb_nomeJogo.Name = "tb_nomeJogo";
            this.tb_nomeJogo.Size = new System.Drawing.Size(342, 20);
            this.tb_nomeJogo.TabIndex = 37;
            // 
            // TelaMenuParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cb_Genero);
            this.Controls.Add(this.tb_nomeJogo);
            this.Controls.Add(this.btn_SorteiosGanhos);
            this.Controls.Add(this.btn_editarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_conta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgv_ListaSorteios);
            this.MaximizeBox = false;
            this.Name = "TelaMenuParticipante";
            this.Text = "MenuParticipante";
            this.Load += new System.EventHandler(this.TelaMenuParticipante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaSorteios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListaSorteios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label l_conta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editarUsuario;
        private System.Windows.Forms.Button btn_SorteiosGanhos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox cb_Genero;
        private System.Windows.Forms.TextBox tb_nomeJogo;
    }
}