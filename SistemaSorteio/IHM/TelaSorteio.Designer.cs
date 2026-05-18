namespace SistemaSorteio.IHM
{
    partial class TelaSorteio
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
            this.l_tituloTela = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_salvarSorteio = new System.Windows.Forms.Button();
            this.tb_nomeJogo = new System.Windows.Forms.TextBox();
            this.dtp_dataLimite = new System.Windows.Forms.DateTimePicker();
            this.cb_Genero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // l_tituloTela
            // 
            this.l_tituloTela.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_tituloTela.Location = new System.Drawing.Point(15, 21);
            this.l_tituloTela.Name = "l_tituloTela";
            this.l_tituloTela.Size = new System.Drawing.Size(234, 22);
            this.l_tituloTela.TabIndex = 1;
            this.l_tituloTela.Text = "Criar/Editar Sorteio";
            this.l_tituloTela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Jogo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selecione o gênero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data limite:";
            // 
            // btn_salvarSorteio
            // 
            this.btn_salvarSorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarSorteio.Location = new System.Drawing.Point(58, 229);
            this.btn_salvarSorteio.Name = "btn_salvarSorteio";
            this.btn_salvarSorteio.Size = new System.Drawing.Size(132, 52);
            this.btn_salvarSorteio.TabIndex = 3;
            this.btn_salvarSorteio.Text = "salvar";
            this.btn_salvarSorteio.UseVisualStyleBackColor = true;
            this.btn_salvarSorteio.Click += new System.EventHandler(this.btn_salvarSorteio_Click);
            // 
            // tb_nomeJogo
            // 
            this.tb_nomeJogo.Location = new System.Drawing.Point(15, 80);
            this.tb_nomeJogo.Name = "tb_nomeJogo";
            this.tb_nomeJogo.Size = new System.Drawing.Size(234, 20);
            this.tb_nomeJogo.TabIndex = 0;
            // 
            // dtp_dataLimite
            // 
            this.dtp_dataLimite.Location = new System.Drawing.Point(15, 165);
            this.dtp_dataLimite.Name = "dtp_dataLimite";
            this.dtp_dataLimite.Size = new System.Drawing.Size(234, 20);
            this.dtp_dataLimite.TabIndex = 2;
            // 
            // cb_Genero
            // 
            this.cb_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Genero.FormattingEnabled = true;
            this.cb_Genero.Items.AddRange(new object[] {
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
            this.cb_Genero.Location = new System.Drawing.Point(15, 122);
            this.cb_Genero.Name = "cb_Genero";
            this.cb_Genero.Size = new System.Drawing.Size(234, 21);
            this.cb_Genero.TabIndex = 1;
            // 
            // TelaSorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 293);
            this.Controls.Add(this.cb_Genero);
            this.Controls.Add(this.dtp_dataLimite);
            this.Controls.Add(this.tb_nomeJogo);
            this.Controls.Add(this.btn_salvarSorteio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_tituloTela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaSorteio";
            this.Text = "Sorteio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_tituloTela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_salvarSorteio;
        private System.Windows.Forms.TextBox tb_nomeJogo;
        private System.Windows.Forms.DateTimePicker dtp_dataLimite;
        private System.Windows.Forms.ComboBox cb_Genero;
    }
}