namespace SistemaSorteio.IHM
{
    partial class TelaMenuSorteador
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
            this.label12 = new System.Windows.Forms.Label();
            this.l_conta = new System.Windows.Forms.Label();
            this.btn_editarUsuario = new System.Windows.Forms.Button();
            this.btn_criarSorteio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ListaSorteios = new System.Windows.Forms.DataGridView();
            this.tb_nomeJogo = new System.Windows.Forms.TextBox();
            this.cb_Genero = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaSorteios)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(-1, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(805, 61);
            this.label12.TabIndex = 23;
            // 
            // l_conta
            // 
            this.l_conta.AutoSize = true;
            this.l_conta.BackColor = System.Drawing.SystemColors.Desktop;
            this.l_conta.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_conta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_conta.Location = new System.Drawing.Point(21, 20);
            this.l_conta.Name = "l_conta";
            this.l_conta.Size = new System.Drawing.Size(84, 22);
            this.l_conta.TabIndex = 24;
            this.l_conta.Text = "CONTA:";
            // 
            // btn_editarUsuario
            // 
            this.btn_editarUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.btn_editarUsuario.Location = new System.Drawing.Point(111, 12);
            this.btn_editarUsuario.Name = "btn_editarUsuario";
            this.btn_editarUsuario.Size = new System.Drawing.Size(90, 37);
            this.btn_editarUsuario.TabIndex = 25;
            this.btn_editarUsuario.Text = "EDITAR";
            this.btn_editarUsuario.UseVisualStyleBackColor = true;
            this.btn_editarUsuario.Click += new System.EventHandler(this.btn_editarUsuario_Click);
            // 
            // btn_criarSorteio
            // 
            this.btn_criarSorteio.Location = new System.Drawing.Point(698, 12);
            this.btn_criarSorteio.Name = "btn_criarSorteio";
            this.btn_criarSorteio.Size = new System.Drawing.Size(90, 37);
            this.btn_criarSorteio.TabIndex = 27;
            this.btn_criarSorteio.Text = "CRIAR";
            this.btn_criarSorteio.UseVisualStyleBackColor = true;
            this.btn_criarSorteio.Click += new System.EventHandler(this.btn_criarSorteio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(527, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "NOVO SORTEIO:";
            // 
            // dgv_ListaSorteios
            // 
            this.dgv_ListaSorteios.AllowUserToResizeColumns = false;
            this.dgv_ListaSorteios.AllowUserToResizeRows = false;
            this.dgv_ListaSorteios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListaSorteios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaSorteios.Location = new System.Drawing.Point(12, 111);
            this.dgv_ListaSorteios.Name = "dgv_ListaSorteios";
            this.dgv_ListaSorteios.ReadOnly = true;
            this.dgv_ListaSorteios.RowHeadersVisible = false;
            this.dgv_ListaSorteios.Size = new System.Drawing.Size(775, 363);
            this.dgv_ListaSorteios.TabIndex = 29;
            this.dgv_ListaSorteios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListaSorteios_CellContentClick);
            // 
            // tb_nomeJogo
            // 
            this.tb_nomeJogo.Location = new System.Drawing.Point(12, 86);
            this.tb_nomeJogo.Name = "tb_nomeJogo";
            this.tb_nomeJogo.Size = new System.Drawing.Size(232, 20);
            this.tb_nomeJogo.TabIndex = 30;
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
            this.cb_Genero.Location = new System.Drawing.Point(250, 86);
            this.cb_Genero.Name = "cb_Genero";
            this.cb_Genero.Size = new System.Drawing.Size(218, 21);
            this.cb_Genero.TabIndex = 31;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(698, 68);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(90, 40);
            this.btn_buscar.TabIndex = 32;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome do Jogo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Gênero:";
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "",
            "Aberto",
            "Fechado"});
            this.cb_status.Location = new System.Drawing.Point(474, 86);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(218, 21);
            this.cb_status.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Status:";
            // 
            // TelaMenuSorteador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cb_Genero);
            this.Controls.Add(this.tb_nomeJogo);
            this.Controls.Add(this.dgv_ListaSorteios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_criarSorteio);
            this.Controls.Add(this.btn_editarUsuario);
            this.Controls.Add(this.l_conta);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaMenuSorteador";
            this.Text = "MenuSorteador";
            this.Load += new System.EventHandler(this.TelaMenuSorteador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaSorteios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label l_conta;
        private System.Windows.Forms.Button btn_editarUsuario;
        private System.Windows.Forms.Button btn_criarSorteio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ListaSorteios;
        private System.Windows.Forms.TextBox tb_nomeJogo;
        private System.Windows.Forms.ComboBox cb_Genero;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label4;
    }
}